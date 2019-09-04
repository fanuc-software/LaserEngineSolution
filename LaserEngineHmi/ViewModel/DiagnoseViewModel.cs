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
    public class DiagnoseViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        #region command
        public ICommand LoadPageCommand { get; set; }
        public ICommand UnLoadPageCommand { get; set; }
        public ICommand RealOutputPowerStartCmd { get; set; }
        public ICommand RealOutputPowerStopCmd { get; set; }

        #endregion

        #region 属性
        private DiagnoseInfoDto m_Diagnose_Info = new DiagnoseInfoDto();
        public DiagnoseInfoDto DiagnoseInfo
        {
            get { return m_Diagnose_Info; }
            set
            {
                if (m_Diagnose_Info != value)
                {
                    m_Diagnose_Info = value;
                    RaisePropertyChanged(() => DiagnoseInfo);
                }
            }
        }

        #endregion

        #region ctor
        public DiagnoseViewModel(IMapper mapper, Fanuc fanuc)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;

            LoadPageCommand = new RelayCommand(ON_LoadPageCommand);
            UnLoadPageCommand = new RelayCommand(ON_UnLoadPageCommand);
            RealOutputPowerStartCmd = new RelayCommand(ON_RealOutputPowerStartCmd);
            RealOutputPowerStopCmd = new RelayCommand(ON_RealOutputPowerStopCmd);

            Messenger.Default.Register<DiagnoseInfo>(this, "DiagnoseInfoMsg", OnRefreshDiagnoseInfo);
        }

        #endregion

        #region private function
        private void OnRefreshDiagnoseInfo(DiagnoseInfo info)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                DiagnoseInfo = _mapper.Map<DiagnoseInfo, DiagnoseInfoDto>(info);
            });
        }

        private void ON_LoadPageCommand()
        {
            _fanuc.ScannerDiagnose_Start();
        }

        private void ON_UnLoadPageCommand()
        {
            _fanuc.ScannerDiagnose_Cancel();
        }

        private void ON_RealOutputPowerStartCmd()
        {
            _fanuc.ScannerDiagnose_Top_Start();
        }

        private void ON_RealOutputPowerStopCmd()
        {
            _fanuc.ScannerDiagnose_Top_Cancel();
            Messenger.Default.Send<string>("START", "RealOutputPower_Control");
        }
        #endregion
    }
}
