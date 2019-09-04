using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Ioc;


namespace LaserEngineHmi.Model
{
    public class SimulationInfoDto : ViewModelBase
    {
        private double m_SIMULATION_STATUS_PC;
        public double SIMULATION_STATUS_PC
        {
            get { return m_SIMULATION_STATUS_PC; }
            set
            {
                if (m_SIMULATION_STATUS_PC != value)
                {
                    m_SIMULATION_STATUS_PC = value;
                    RaisePropertyChanged(() => SIMULATION_STATUS_PC);
                }
            }
        }

        private double m_SIMULATION_STATUS_FR;
        public double SIMULATION_STATUS_FR
        {
            get { return m_SIMULATION_STATUS_FR; }
            set
            {
                if (m_SIMULATION_STATUS_FR != value)
                {
                    m_SIMULATION_STATUS_FR = value;
                    RaisePropertyChanged(() => SIMULATION_STATUS_FR);
                }
            }
        }

        private double m_SIMULATION_STATUS_DU;
        public double SIMULATION_STATUS_DU
        {
            get { return m_SIMULATION_STATUS_DU; }
            set
            {
                if (m_SIMULATION_STATUS_DU != value)
                {
                    m_SIMULATION_STATUS_DU = value;
                    RaisePropertyChanged(() => SIMULATION_STATUS_DU);
                }
            }
        }

        private double m_SIMULATION_STATUS_PA;
        public double SIMULATION_STATUS_PA
        {
            get { return m_SIMULATION_STATUS_PA; }
            set
            {
                if (m_SIMULATION_STATUS_PA != value)
                {
                    m_SIMULATION_STATUS_PA = value;
                    RaisePropertyChanged(() => SIMULATION_STATUS_PA);
                }
            }
        }

        private double m_SIMULATION_STATUS_E0XX;
        public double SIMULATION_STATUS_E0XX
        {
            get { return m_SIMULATION_STATUS_E0XX; }
            set
            {
                if (m_SIMULATION_STATUS_E0XX != value)
                {
                    m_SIMULATION_STATUS_E0XX = value;
                    RaisePropertyChanged(() => SIMULATION_STATUS_E0XX);
                }
            }
        }

        private double m_SIMULATION_STATUS_E10X;
        public double SIMULATION_STATUS_E10X
        {
            get { return m_SIMULATION_STATUS_E10X; }
            set
            {
                if (m_SIMULATION_STATUS_E10X != value)
                {
                    m_SIMULATION_STATUS_E10X = value;
                    RaisePropertyChanged(() => SIMULATION_STATUS_E10X);
                }
            }
        }

        private double m_SIMULATION_STATUS_F;
        public double SIMULATION_STATUS_F
        {
            get { return m_SIMULATION_STATUS_F; }
            set
            {
                if (m_SIMULATION_STATUS_F != value)
                {
                    m_SIMULATION_STATUS_F = value;
                    RaisePropertyChanged(() => SIMULATION_STATUS_F);
                }
            }
        }

        private byte m_SIMULATION_STATUS_LASEROV_PC;
        public byte SIMULATION_STATUS_LASEROV_PC
        {
            get { return m_SIMULATION_STATUS_LASEROV_PC; }
            set
            {
                if (m_SIMULATION_STATUS_LASEROV_PC != value)
                {
                    m_SIMULATION_STATUS_LASEROV_PC = value;
                    RaisePropertyChanged(() => SIMULATION_STATUS_LASEROV_PC);
                }
            }
        }

        private byte m_SIMULATION_STATUS_LASEROV_FR;
        public byte SIMULATION_STATUS_LASEROV_FR
        {
            get { return m_SIMULATION_STATUS_LASEROV_FR; }
            set
            {
                if (m_SIMULATION_STATUS_LASEROV_FR != value)
                {
                    m_SIMULATION_STATUS_LASEROV_FR = value;
                    RaisePropertyChanged(() => SIMULATION_STATUS_LASEROV_FR);
                }
            }
        }

        private byte m_SIMULATION_STATUS_LASEROV_DU;
        public byte SIMULATION_STATUS_LASEROV_DU
        {
            get { return m_SIMULATION_STATUS_LASEROV_DU; }
            set
            {
                if (m_SIMULATION_STATUS_LASEROV_DU != value)
                {
                    m_SIMULATION_STATUS_LASEROV_DU = value;
                    RaisePropertyChanged(() => SIMULATION_STATUS_LASEROV_DU);
                }
            }
        }

        private bool m_SIMULATION_STATUS_NANOPC;
        public bool SIMULATION_STATUS_NANOPC
        {
            get { return m_SIMULATION_STATUS_NANOPC; }
            set
            {
                if (m_SIMULATION_STATUS_NANOPC != value)
                {
                    m_SIMULATION_STATUS_NANOPC = value;
                    RaisePropertyChanged(() => SIMULATION_STATUS_NANOPC);
                }
            }
        }

        private bool m_SIMULATION_STATUS_POWERCONTROL;
        public bool SIMULATION_STATUS_POWERCONTROL
        {
            get { return m_SIMULATION_STATUS_POWERCONTROL; }
            set
            {
                if (m_SIMULATION_STATUS_POWERCONTROL != value)
                {
                    m_SIMULATION_STATUS_POWERCONTROL = value;
                    RaisePropertyChanged(() => SIMULATION_STATUS_POWERCONTROL);
                }
            }
        }

        private bool m_SIMULATION_STATUS_EDGECUTTING;
        public bool SIMULATION_STATUS_EDGECUTTING
        {
            get { return m_SIMULATION_STATUS_EDGECUTTING; }
            set
            {
                if (m_SIMULATION_STATUS_EDGECUTTING != value)
                {
                    m_SIMULATION_STATUS_EDGECUTTING = value;
                    RaisePropertyChanged(() => SIMULATION_STATUS_EDGECUTTING);
                }
            }
        }
    }
}
