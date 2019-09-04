using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using AutoMapper;
using FanucCnc;
using LaserEngineHmi.Model;

namespace LaserEngineHmi.ViewModel
{
    public class ManualFindSideViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadPageCommand { get; set; }
        public ICommand UnLoadPageCommand { get; set; }

        private System.Timers.Timer timerR = new System.Timers.Timer();
        
        public ICommand GetP1Command { get; set; }
        public ICommand GetP2Command { get; set; }
        public ICommand GetP3Command { get; set; }

        public ICommand ResetCmd { get; set; }

        public ICommand LoadCmd { get; set; }

        public ICommand TestCmd { get; set; }

        #region 属性
        private bool m_P1Clicked;
        public bool P1Clicked
        {
            get { return m_P1Clicked; }
            set
            {
                if (m_P1Clicked != value)
                {
                    m_P1Clicked = value;
                    RaisePropertyChanged(() => P1Clicked);
                }
            }
        }

        private bool m_P2Clicked;
        public bool P2Clicked
        {
            get { return m_P2Clicked; }
            set
            {
                if (m_P2Clicked != value)
                {
                    m_P2Clicked = value;
                    RaisePropertyChanged(() => P2Clicked);
                }
            }
        }

        private bool m_P3Clicked;
        public bool P3Clicked
        {
            get { return m_P3Clicked; }
            set
            {
                if (m_P3Clicked != value)
                {
                    m_P3Clicked = value;
                    RaisePropertyChanged(() => P3Clicked);
                }
            }
        }

        private double m_P1_X;
        public double P1_X
        {
            get { return m_P1_X; }
            set
            {
                if (m_P1_X != value)
                {
                    m_P1_X = value;
                    RaisePropertyChanged(() => P1_X);
                }
            }
        }

        private double m_P1_Y;
        public double P1_Y
        {
            get { return m_P1_Y; }
            set
            {
                if (m_P1_Y != value)
                {
                    m_P1_Y = value;
                    RaisePropertyChanged(() => P1_Y);
                }
            }
        }

        private double m_P2_X;
        public double P2_X
        {
            get { return m_P2_X; }
            set
            {
                if (m_P2_X != value)
                {
                    m_P2_X = value;
                    RaisePropertyChanged(() => P2_X);
                }
            }
        }

        private double m_P2_Y;
        public double P2_Y
        {
            get { return m_P2_Y; }
            set
            {
                if (m_P2_Y != value)
                {
                    m_P2_Y = value;
                    RaisePropertyChanged(() => P2_Y);
                }
            }
        }

        private double m_P3_X;
        public double P3_X
        {
            get { return m_P3_X; }
            set
            {
                if (m_P3_X != value)
                {
                    m_P3_X = value;
                    RaisePropertyChanged(() => P3_X);
                }
            }
        }

        private double m_P3_Y;
        public double P3_Y
        {
            get { return m_P3_Y; }
            set
            {
                if (m_P3_Y != value)
                {
                    m_P3_Y = value;
                    RaisePropertyChanged(() => P3_Y);
                }
            }
        }

        private double m_WpZeroX;
        public double WpZeroX
        {
            get { return m_WpZeroX; }
            set
            {
                if (m_WpZeroX != value)
                {
                    m_WpZeroX = value;
                    RaisePropertyChanged(() => WpZeroX);
                }
            }
        }

        private double m_WpZeroY;
        public double WpZeroY
        {
            get { return m_WpZeroY; }
            set
            {
                if (m_WpZeroY != value)
                {
                    m_WpZeroY = value;
                    RaisePropertyChanged(() => WpZeroY);
                }
            }
        }

        private double m_WpAngle;
        public double WpAngle
        {
            get { return m_WpAngle; }
            set
            {
                if (m_WpAngle != value)
                {
                    m_WpAngle = value;
                    RaisePropertyChanged(() => WpAngle);
                }
            }
        }

        private ManualFindSideInfoDto m_ManualFindSide_Info = new ManualFindSideInfoDto();
        public ManualFindSideInfoDto ManualFindSide_Info
        {
            get { return m_ManualFindSide_Info; }
            set
            {
                if (m_ManualFindSide_Info != value)
                {
                    m_ManualFindSide_Info = value;
                    RaisePropertyChanged(() => ManualFindSide_Info);
                }
            }
        }

        #endregion


        #region ctor
        public ManualFindSideViewModel(IMapper mapper, Fanuc fanuc)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;

            LoadPageCommand = new RelayCommand(ON_LoadPageCommand);
            UnLoadPageCommand = new RelayCommand(ON_UnLoadPageCommand);
            GetP1Command = new RelayCommand(OnGetP1Command);
            GetP2Command = new RelayCommand(OnGetP2Command);
            GetP3Command = new RelayCommand(OnGetP3Command);

            ResetCmd = new RelayCommand(OnResetCmd);
            LoadCmd = new RelayCommand(OnLoadCmd);
            TestCmd= new RelayCommand(OnTestCmd);

            P1Clicked = false;
            P2Clicked = false;
            P3Clicked = false;

            P1_X = 0;
            P1_Y = 0;
            P2_X = 0;
            P2_Y = 0;
            P3_X = 0;
            P3_Y = 0;

            WpZeroX = 0;
            WpZeroY = 0;
            WpAngle = 0;


            Messenger.Default.Register<ManualFindSideInfo>(this, "ManualFindSideInfoMsg", OnRefreshManualFindSideInfo);

        }

        #endregion

        private void OnRefreshManualFindSideInfo(ManualFindSideInfo info)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                ManualFindSide_Info = _mapper.Map<ManualFindSideInfo, ManualFindSideInfoDto>(info);
            });
        }

        private void OnGetP1Command()
        {
            double xpos = 0;
            double ypos = 0;
            var  ret = _fanuc.GetMachinePosition(ref xpos, ref ypos);
            if (ret != 0)
            {
                Messenger.Default.Send<string>("获得机械坐标失败，返回" + ret.ToString(), "OperateNotice");
                return;
            }

            P1_X = xpos;
            P1_Y = ypos;
            P1Clicked = true;
        }
        private void OnGetP2Command()
        {
            double xpos = 0;
            double ypos = 0;
            var ret = _fanuc.GetMachinePosition(ref xpos, ref ypos);
            if (ret != 0)
            {
                Messenger.Default.Send<string>("获得机械坐标失败，返回" + ret.ToString(), "OperateNotice");
                return;
            }

            if(P1Clicked==false)
            {
                Messenger.Default.Send<string>("请先获取P1位置", "OperateNotice");
                return;
            }

            P2_X = xpos;
            P2_Y = ypos;

            if (P2_X == P1_X)
            {
                Messenger.Default.Send<string>("P2点与P1点X坐标相同", "OperateNotice");
                return;
            }
            WpAngle = Math.Atan((P1_Y - P2_Y) / (P1_X - P2_X)) / Math.PI * 180.0;
            
            P2Clicked = true;
        }
        private void OnGetP3Command()
        {
            double xpos = 0;
            double ypos = 0;
            var ret = _fanuc.GetMachinePosition(ref xpos, ref ypos);
            if (ret != 0)
            {
                Messenger.Default.Send<string>("获得机械坐标失败，返回" + ret.ToString(), "OperateNotice");
                return;
            }

            if (P1Clicked == false)
            {
                Messenger.Default.Send<string>("请先获取P1位置", "OperateNotice");
                return;
            }

            P3_X = xpos;
            P3_Y = ypos;
            

            if (P2Clicked==false)
            {

                if (P3_X == P1_X)
                {
                    Messenger.Default.Send<string>("P3点与P1点X坐标相同", "OperateNotice");
                    return;
                }
                WpAngle = Math.Atan((P3_Y - P1_Y) / (P3_X - P1_X)) / Math.PI * 180.0;
            }

            WpZeroX = P3_X;
            WpZeroY = P3_Y;
            
            P3Clicked = true;

        }

        private void OnResetCmd()
        {
            P1Clicked = false;
            P2Clicked = false;
            P3Clicked = false;

            P1_X = 0;
            P1_Y = 0;
            P2_X = 0;
            P2_Y = 0;
            P3_X = 0;
            P3_Y = 0;

            WpZeroX = 0;
            WpZeroY = 0;
            WpAngle = 0;
        }

        private void OnLoadCmd()
        {
            var ret = _fanuc.ManualFindSide_SET_XD(WpZeroX);
            if(ret!=0)
            {
                Messenger.Default.Send<string>("设定板材原点X失败", "OperateNotice");
                return;
            }

            ret = _fanuc.ManualFindSide_SET_YD(WpZeroY);
            if (ret != 0)
            {
                Messenger.Default.Send<string>("设定板材原点Y失败", "OperateNotice");
                return;
            }

            ret = _fanuc.ManualFindSide_SET_SITA(WpAngle);
            if (ret != 0)
            {
                Messenger.Default.Send<string>("设定板材倾斜角度失败", "OperateNotice");
                return;
            }

        }

        private void OnTestCmd()
        {
            var ret = _fanuc.ManualFindSide_Test();
            if (ret != 0)
            {
                Messenger.Default.Send<string>("程序调用失败，请检查操作方式", "OperateNotice");
            }
        }

        private void ON_LoadPageCommand()
        {
            _fanuc.ScannerManualFindSide_Start();
        }

        private void ON_UnLoadPageCommand()
        {
            _fanuc.ScannerManualFindSide_Cancel();
        }

    }
}
