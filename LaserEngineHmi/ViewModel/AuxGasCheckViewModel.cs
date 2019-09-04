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
    public class AuxGasCheckViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadPageCommand { get; set; }
        public ICommand UnLoadPageCommand { get; set; }

        public ICommand AuxGasCheckCommand { get; set; }

        private short m_AuxGasKind;
        public short _AuxGasKind
        {
            get { return m_AuxGasKind; }
            set
            {
                if (m_AuxGasKind != value)
                {
                    _fanuc.AuxGasCheck_Set_Kind(value);

                    m_AuxGasKind = value;
                    RaisePropertyChanged(() => _AuxGasKind);
                }
            }
        }

        private double m_AuxPress;
        public double _AuxPress
        {
            get { return m_AuxPress; }
            set
            {
                if (m_AuxPress != value)
                {
                    _fanuc.AuxGasCheck_Set_Press((short)(value * 100));

                    m_AuxPress = value;
                    RaisePropertyChanged(() => _AuxPress);
                }
            }
        }

        private double m_AuxWaitTime;
        public double _AuxWaitTime
        {
            get { return m_AuxWaitTime; }
            set
            {
                if (m_AuxWaitTime != value)
                {
                    _fanuc.AuxGasCheck_Set_WaitTime((short)(value * 100));

                    m_AuxWaitTime = value;
                    RaisePropertyChanged(() => _AuxWaitTime);
                }
            }
        }

        public AuxGasCheckViewModel(IMapper mapper, Fanuc fanuc)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;

            LoadPageCommand = new RelayCommand(ON_LoadPageCommand);
            UnLoadPageCommand = new RelayCommand(ON_UnLoadPageCommand);

            AuxGasCheckCommand = new RelayCommand(OnAuxGasCheckCommand);
        }

        private void OnAuxGasCheckCommand()
        {
            _fanuc.AuxGasCheck_Start();
        }

        private void ON_LoadPageCommand()
        {
            short temp = 0;
            _fanuc.AuxGasCheck_Get_Kind(ref temp);
            _AuxGasKind = temp;

            _fanuc.AuxGasCheck_Get_Press(ref temp);
            _AuxPress = (double)temp * 0.01;

            _fanuc.AuxGasCheck_Get_WaitTime(ref temp);
            _AuxWaitTime = (double)temp*0.01;
        }

        private void ON_UnLoadPageCommand()
        {

        }
    }
}
