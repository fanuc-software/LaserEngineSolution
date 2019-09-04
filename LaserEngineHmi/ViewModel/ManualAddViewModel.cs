using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using AutoMapper;
using FanucCnc;
using LaserEngineHmi.Model;
using DataCenter.Services;
using DataCenter.Model;
using LaserEngineHmi.View;

namespace LaserEngineHmi.ViewModel
{
    public class ManualAddViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;
        private ManualService _mSrv;

        public ICommand CancelCmd { get; set; }
        public ICommand ConfirmCmd { get; set; }


        
        private ManualDto m_Manual=new ManualDto();
        public ManualDto Manual
        {
            get { return m_Manual; }
            set
            {
                if (m_Manual != value)
                {
                    m_Manual = value;
                    RaisePropertyChanged(() => Manual);
                }
            }
        }

        public ManualAddViewModel(IMapper mapper, Fanuc fanuc, ManualService mSrv)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;
            this._mSrv = mSrv;

            CancelCmd = new RelayCommand(OnCancelCmd);
            ConfirmCmd = new RelayCommand(OnConfirmCmd);

            Messenger.Default.Register<string>(this, "SetManualFilePathMsg", msg =>
            {

                System.Windows.Forms.OpenFileDialog file = new System.Windows.Forms.OpenFileDialog();
                if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK || file.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                {
                    Manual.Path = System.IO.Path.GetFullPath(file.FileName);
                }
            });
        }

        public void OnConfirmCmd()
        {
            var sourcepath = Manual.Path;
            var despath = @"C:\ProgramData\BFM\Manual\" + System.IO.Path.GetFileName(sourcepath);

            try
            {
                System.IO.File.Copy(sourcepath, despath);
            }
            catch
            {
                Messenger.Default.Send<string>("文件创建失败，可能存在同名称文件", "OperateNotice");
                return;
            }

            Manual.Path = despath;

            try
            {
                _mSrv.Add(Manual);
            }
            catch
            {
                Messenger.Default.Send<string>("文件创建失败，保存至数据库失败", "OperateNotice");
                return;
            }
            
            Messenger.Default.Send<bool>(true, "ManualAddQuitMsg");
        }

        public void OnCancelCmd()
        {
            Messenger.Default.Send<bool>(false, "ManualAddQuitMsg");
        }
    }
}
