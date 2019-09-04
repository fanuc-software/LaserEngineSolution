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
    public class SimulationViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        #region command
        public ICommand LoadPageCommand { get; set; }
        public ICommand UnLoadPageCommand { get; set; }

        #endregion
        #region 属性
        private SimulationInfoDto m_Simulation_Info = new SimulationInfoDto();
        public SimulationInfoDto SimulationInfo
        {
            get { return m_Simulation_Info; }
            set
            {
                if (m_Simulation_Info != value)
                {
                    m_Simulation_Info = value;
                    RaisePropertyChanged(() => SimulationInfo);
                }
            }
        }

        #endregion

        #region ctor
        public SimulationViewModel(IMapper mapper, Fanuc fanuc)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;

            LoadPageCommand = new RelayCommand(ON_LoadPageCommand);
            UnLoadPageCommand = new RelayCommand(ON_UnLoadPageCommand);

            Messenger.Default.Register<SimulationInfo>(this, "SimulationInfoMsg", OnRefreshSimulationInfo);
        }

        #endregion

        #region private function
        private void OnRefreshSimulationInfo(SimulationInfo info)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                SimulationInfo = _mapper.Map<SimulationInfo, SimulationInfoDto>(info);
            });
        }

        private void ON_LoadPageCommand()
        {
            _fanuc.ScannerSimulation_Start();
        }

        private void ON_UnLoadPageCommand()
        {
            _fanuc.ScannerSimulation_Cancel();
        }
        
        #endregion


    }
}
