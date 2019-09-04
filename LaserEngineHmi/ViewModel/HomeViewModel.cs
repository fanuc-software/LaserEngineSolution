using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using AutoMapper;
using FanucCnc;
using LaserEngineHmi.Model;
using LaserEngineHmi.Hook;

namespace LaserEngineHmi.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        private DateTime m_newKeyPressLastTime = DateTime.MinValue;
        private byte m_newKeyPressLastByte = 0;

        private DateTime m_newMyKeyPressLastTime = DateTime.MinValue;
        private string m_newMyKeyPressLastStr = "";

        private System.Windows.Forms.KeyPressEventHandler m_keypressEvent;
        private LaserEngineHmi.Hook.NewKeyboardHook.MyKeyPressEventHandler m_mykeypressEvent;

        private NewKeyboardHook k_hook = NewKeyboardHook.CreateInstance();

        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadPageCommand { get; set; }
        public ICommand UnLoadPageCommand { get; set; }

        public ICommand RIGHTSOFTKEY_CMD{ get; set; }

        private string m_SafeNetLimitVisible;
        public string SafeNetLimitVisible
        {
            get { return m_SafeNetLimitVisible; }
            set
            {
                if (m_SafeNetLimitVisible != value)
                {
                    m_SafeNetLimitVisible = value;
                    RaisePropertyChanged(() => SafeNetLimitVisible);
                }
            }
        }

        #region ctor
        public HomeViewModel(IMapper mapper, Fanuc fanuc)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;

            SafeNetLimitVisible = "Hidden";

            m_keypressEvent = new System.Windows.Forms.KeyPressEventHandler(hook_newKeyPress);
            m_mykeypressEvent = new LaserEngineHmi.Hook.NewKeyboardHook.MyKeyPressEventHandler(hook_newMyKeyPress);
            

            LoadPageCommand = new RelayCommand(OnLoadPageCommand);
            UnLoadPageCommand = new RelayCommand(OnUnLoadPageCommand);
            RIGHTSOFTKEY_CMD = new RelayCommand(OnRIGHTSOFTKEY_CMD);

            Messenger.Default.Register<string>(this, "SoftwareLimitMsgBySafeNet", msg =>
             {
                 SafeNetLimitVisible = "Hidden";
             });

            Messenger.Default.Register<string>(this, "SoftwareNoLimitMsgBySafeNet", msg =>
            {
                SafeNetLimitVisible = "Visible";
            });
        }

        #endregion

        private void OnRIGHTSOFTKEY_CMD()
        {
            Messenger.Default.Send<string>("SVF1", "CsdSoftKeyMsg");
        }

        private void OnLoadPageCommand()
        {
            k_hook.KeyPressEvent += m_keypressEvent;
            k_hook.MyKeyPressEvent += m_mykeypressEvent;
            

            k_hook.Start();
        }

        private void OnUnLoadPageCommand()
        {
            k_hook.KeyPressEvent -= m_keypressEvent;
            k_hook.MyKeyPressEvent -= m_mykeypressEvent;

            k_hook.Stop();
        }

        private void hook_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            byte key = (byte)e.KeyChar;
            Messenger.Default.Send<byte>(key, "CsdKeyMsg");
            //var csd = CncScreenDisplay.CreateInstance();
            //csd.OnKey(key);
        }

        private void hook_newKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            DateTime curTime = DateTime.Now;

            byte key = (byte)e.KeyChar;
            if (key != m_newKeyPressLastByte)
            {
                Messenger.Default.Send<byte>(key, "CsdKeyMsg");
                m_newKeyPressLastTime = curTime;
                m_newKeyPressLastByte = key;
            }
            else
            {
                if((curTime - m_newKeyPressLastTime) > TimeSpan.FromMilliseconds(100))
                {
                    Messenger.Default.Send<byte>(key, "CsdKeyMsg");
                    m_newKeyPressLastTime = curTime;
                    m_newKeyPressLastByte = key;
                }
            }
        }


        private void hook_MyKeyPress(object sender, string e)
        {
            Messenger.Default.Send<string>(e, "CsdMenuKeyMsg");

            //var csd = CncScreenDisplay.CreateInstance();
            //csd.OnMenuKey(e);
        }

        private void hook_newMyKeyPress(object sender, string e)
        {
            DateTime curTime = DateTime.Now;
            
            if (e != m_newMyKeyPressLastStr)
            {
                Messenger.Default.Send<string>(e, "CsdMenuKeyMsg");
                m_newMyKeyPressLastTime = curTime;
                m_newMyKeyPressLastStr = e;
            }
            else
            {
                if ((curTime - m_newMyKeyPressLastTime) > TimeSpan.FromMilliseconds(100))
                {
                    Messenger.Default.Send<string>(e, "CsdMenuKeyMsg");
                    m_newMyKeyPressLastTime = curTime;
                    m_newMyKeyPressLastStr = e;
                }
            }
        }
    }
}
