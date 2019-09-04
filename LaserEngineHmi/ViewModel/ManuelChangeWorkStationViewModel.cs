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
    public class ManuelChangeWorkStationViewModel: ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        #region command
        public ICommand LoadPageCommand { get; set; }
        public ICommand UnLoadPageCommand { get; set; }

        public ICommand MainUpMouseDownCommand { get; set; }
        public ICommand MainUpMouseUpCommand { get; set; }
        public ICommand MainLeftMouseDownCommand { get; set; }
        public ICommand MainLeftMouseUpCommand { get; set; }
        public ICommand MainRightMouseDownCommand { get; set; }
        public ICommand MainRightMouseUpCommand { get; set; }
        public ICommand MainDownMouseDownCommand { get; set; }
        public ICommand MainDownMouseUpCommand { get; set; }
        public ICommand SubUpMouseDownCommand { get; set; }
        public ICommand SubUpMouseUpCommand { get; set; }
        public ICommand SubLeftMouseDownCommand { get; set; }
        public ICommand SubLeftMouseUpCommand { get; set; }
        public ICommand SubRightMouseDownCommand { get; set; }
        public ICommand SubRightMouseUpCommand { get; set; }
        public ICommand SubDownMouseDownCommand { get; set; }
        public ICommand SubDownMouseUpCommand { get; set; }

        private ICommand StartCommand { get; set; }


        #endregion

        #region 属性
        private WorkStationInfoDto m_WorkStation_Info = new WorkStationInfoDto();
        public WorkStationInfoDto WorkStationInfo
        {
            get { return m_WorkStation_Info; }
            set
            {
                if (m_WorkStation_Info != value)
                {
                    m_WorkStation_Info = value;
                    RaisePropertyChanged(() => WorkStationInfo);
                }
            }
        }

        private double m_Z_Limit;
        public double Z_Limit
        {
            get { return m_Z_Limit; }
            set
            {
                if (m_Z_Limit != value)
                {
                    ConfigCenter.ConfigHelper config = new ConfigCenter.ConfigHelper();
                    var ret = config.SetWorkStationZLimit(value.ToString());
                    if (ret != 0)
                    {

                        Z_Limit = m_Z_Limit;
                        return;
                    }

                    m_Z_Limit = value;
                    RaisePropertyChanged(() => Z_Limit);
                }
            }
        }

        private bool m_HorizontalChange;
        public bool HorizontalChange
        {
            get { return m_HorizontalChange; }
            set
            {
                if (m_HorizontalChange != value)
                {
                    ConfigCenter.ConfigHelper config = new ConfigCenter.ConfigHelper();
                    var ret = config.SetWorkStationHorizontal(value.ToString());
                    if (ret != 0)
                    {

                        HorizontalChange = m_HorizontalChange;
                        return;
                    }

                    m_HorizontalChange = value;
                    RaisePropertyChanged(() => HorizontalChange);
                }
            }
        }

        private bool m_VerticalChange;
        public bool VerticalChange
        {
            get { return m_VerticalChange; }
            set
            {
                if (m_VerticalChange != value)
                {
                    ConfigCenter.ConfigHelper config = new ConfigCenter.ConfigHelper();
                    var ret = config.SetWorkStationVertical(value.ToString());
                    if (ret != 0)
                    {

                        VerticalChange = m_VerticalChange;
                        return;
                    }

                    m_VerticalChange = value;
                    RaisePropertyChanged(() => VerticalChange);
                }
            }
        }

        #endregion

        #region ctor
        public ManuelChangeWorkStationViewModel(IMapper mapper, Fanuc fanuc)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;

            LoadPageCommand = new RelayCommand(OnLoadPageCommand);
            UnLoadPageCommand = new RelayCommand(OnUnLoadPageCommand);

            MainUpMouseDownCommand = new RelayCommand(OnMainUpMouseDownCommand);
            MainUpMouseUpCommand = new RelayCommand(OnMainUpMouseUpCommand);
            MainLeftMouseDownCommand = new RelayCommand(OnMainLeftMouseDownCommand);
            MainLeftMouseUpCommand = new RelayCommand(OnMainLeftMouseUpCommand);
            MainRightMouseDownCommand = new RelayCommand(OnMainRightMouseDownCommand);
            MainRightMouseUpCommand = new RelayCommand(OnMainRightMouseUpCommand);
            MainDownMouseDownCommand = new RelayCommand(OnMainDownMouseDownCommand);
            MainDownMouseUpCommand = new RelayCommand(OnMainDownMouseUpCommand);
            SubUpMouseDownCommand = new RelayCommand(OnSubUpMouseDownCommand);
            SubUpMouseUpCommand = new RelayCommand(OnSubUpMouseUpCommand);
            SubLeftMouseDownCommand = new RelayCommand(OnSubLeftMouseDownCommand);
            SubLeftMouseUpCommand = new RelayCommand(OnSubLeftMouseUpCommand);
            SubRightMouseDownCommand = new RelayCommand(OnSubRightMouseDownCommand);
            SubRightMouseUpCommand = new RelayCommand(OnSubRightMouseUpCommand);
            SubDownMouseDownCommand = new RelayCommand(OnSubDownMouseDownCommand);
            SubDownMouseUpCommand = new RelayCommand(OnSubDownMouseUpCommand);

            ConfigCenter.ConfigHelper config = new ConfigCenter.ConfigHelper();
            var temp = config.GetWorkStationZLimit();
            Z_Limit = Double.Parse(temp);
            temp = config.GetWorkStationHorizontal();
            HorizontalChange = Boolean.Parse(temp);
            temp = config.GetWorkStationVertical();
            VerticalChange = Boolean.Parse(temp);

            Messenger.Default.Register<WorkStationInfo>(this, "WorkStationInfoMsg", OnRefreshWorkStationInfo);

            StartCommand = new RelayCommand(OnStart);
        }

        #endregion

        #region private function
        private void OnStart()
        {
            double xpos = 0;
            double ypos = 0;
            double zpos = 0;
            short ret = _fanuc.WorkStation_GET_MachinePosition(ref xpos, ref ypos, ref zpos);
            if (ret != 0) return;

            if(zpos<Z_Limit)
            {
                _fanuc.WorkStation_ZLimit_ALARM();
                return;
            }

            _fanuc.WorkStation_Start();

        }

        private void OnRefreshWorkStationInfo(WorkStationInfo info)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                WorkStationInfo = _mapper.Map<WorkStationInfo, WorkStationInfoDto>(info);
            });
        }

        private void OnLoadPageCommand()
        {
            _fanuc.ScannerWorkStation_Start();
        }

        private void OnUnLoadPageCommand()
        {
            _fanuc.ScannerWorkStation_Cancel();
        }

        private void OnMainUpMouseDownCommand()
        {
            _fanuc.WorkStationMainUpPushCommand();
        }

        private void OnMainUpMouseUpCommand()
        {
            _fanuc.WorkStationMainUpReleaseCommand();
        }

        private void OnMainLeftMouseDownCommand()
        {
            _fanuc.WorkStationMainLeftPushCommand();
        }

        private void OnMainLeftMouseUpCommand()
        {
            _fanuc.WorkStationMainLeftReleaseCommand();
        }

        private void OnMainRightMouseDownCommand()
        {
            _fanuc.WorkStationMainRightPushCommand();
        }

        private void OnMainRightMouseUpCommand()
        {
            _fanuc.WorkStationMainRightReleaseCommand();
        }

        private void OnMainDownMouseDownCommand()
        {
            _fanuc.WorkStationMainDownPushCommand();
        }

        private void OnMainDownMouseUpCommand()
        {
            _fanuc.WorkStationMainDownReleaseCommand();
        }

        private void OnSubUpMouseDownCommand()
        {
            _fanuc.WorkStationSubUpPushCommand();
        }

        private void OnSubUpMouseUpCommand()
        {
            _fanuc.WorkStationSubUpReleaseCommand();
        }

        private void OnSubLeftMouseDownCommand()
        {
            _fanuc.WorkStationSubLeftPushCommand();
        }

        private void OnSubLeftMouseUpCommand()
        {
            _fanuc.WorkStationSubLeftReleaseCommand();
        }

        private void OnSubRightMouseDownCommand()
        {
            _fanuc.WorkStationSubRightPushCommand();
        }

        private void OnSubRightMouseUpCommand()
        {
            _fanuc.WorkStationSubRightReleaseCommand();
        }

        private void OnSubDownMouseDownCommand()
        {
            _fanuc.WorkStationSubDownPushCommand();
        }

        private void OnSubDownMouseUpCommand()
        {
            _fanuc.WorkStationSubDownReleaseCommand();
        }

        #endregion
    }
}
