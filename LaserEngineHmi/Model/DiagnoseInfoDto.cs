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
    public class DiagnoseInfoDto : ViewModelBase
    {
        private double m_Diagnose_Value_PC;
        public double DIAGNOSE_VALUE_PC
        {
            get { return m_Diagnose_Value_PC; }
            set
            {
                if (m_Diagnose_Value_PC != value)
                {
                    m_Diagnose_Value_PC = value;
                    RaisePropertyChanged(() => DIAGNOSE_VALUE_PC);
                }
            }
        }

        private double m_DIAGNOSE_VALUE_FR;
        public double DIAGNOSE_VALUE_FR
        {
            get { return m_DIAGNOSE_VALUE_FR; }
            set
            {
                if (m_DIAGNOSE_VALUE_FR != value)
                {
                    m_DIAGNOSE_VALUE_FR = value;
                    RaisePropertyChanged(() => DIAGNOSE_VALUE_FR);
                }
            }
        }

        private double m_DIAGNOSE_VALUE_DU;
        public double DIAGNOSE_VALUE_DU
        {
            get { return m_DIAGNOSE_VALUE_DU; }
            set
            {
                if (m_DIAGNOSE_VALUE_DU != value)
                {
                    m_DIAGNOSE_VALUE_DU = value;
                    RaisePropertyChanged(() => DIAGNOSE_VALUE_DU);
                }
            }
        }

        private double m_DIAGNOSE_VALUE_PA;
        public double DIAGNOSE_VALUE_PA
        {
            get { return m_DIAGNOSE_VALUE_PA; }
            set
            {
                if (m_DIAGNOSE_VALUE_PA != value)
                {
                    m_DIAGNOSE_VALUE_PA = value;
                    RaisePropertyChanged(() => DIAGNOSE_VALUE_PA);
                }
            }
        }

        private double m_DIAGNOSE_VALUE_F;
        public double DIAGNOSE_VALUE_F
        {
            get { return m_DIAGNOSE_VALUE_F; }
            set
            {
                if (m_DIAGNOSE_VALUE_F != value)
                {
                    m_DIAGNOSE_VALUE_F = value;
                    RaisePropertyChanged(() => DIAGNOSE_VALUE_F);
                }
            }
        }

        private byte m_DIAGNOSE_PERCENT_PC;
        public byte DIAGNOSE_PERCENT_PC
        {
            get { return m_DIAGNOSE_PERCENT_PC; }
            set
            {
                if (m_DIAGNOSE_PERCENT_PC != value)
                {
                    m_DIAGNOSE_PERCENT_PC = value;
                    RaisePropertyChanged(() => DIAGNOSE_PERCENT_PC);
                }
            }
        }

        private byte m_DIAGNOSE_PERCENT_FR;
        public byte DIAGNOSE_PERCENT_FR
        {
            get { return m_DIAGNOSE_PERCENT_FR; }
            set
            {
                if (m_DIAGNOSE_PERCENT_FR != value)
                {
                    m_DIAGNOSE_PERCENT_FR = value;
                    RaisePropertyChanged(() => DIAGNOSE_PERCENT_FR);
                }
            }
        }

        private byte m_DIAGNOSE_PERCENT_DU;
        public byte DIAGNOSE_PERCENT_DU
        {
            get { return m_DIAGNOSE_PERCENT_DU; }
            set
            {
                if (m_DIAGNOSE_PERCENT_DU != value)
                {
                    m_DIAGNOSE_PERCENT_DU = value;
                    RaisePropertyChanged(() => DIAGNOSE_PERCENT_DU);
                }
            }
        }
        
        private double m_DIAGNOSE_REFLECTEDLIGHT;
        public double DIAGNOSE_REFLECTEDLIGHT
        {
            get { return m_DIAGNOSE_REFLECTEDLIGHT; }
            set
            {
                if (m_DIAGNOSE_REFLECTEDLIGHT != value)
                {
                    m_DIAGNOSE_REFLECTEDLIGHT = value;
                    RaisePropertyChanged(() => DIAGNOSE_REFLECTEDLIGHT);
                }
            }
        }
        
        private double m_DIAGNOSE_COOLWATER_FLUX_PATH1;
        public double DIAGNOSE_COOLWATER_FLUX_PATH1
        {
            get { return m_DIAGNOSE_COOLWATER_FLUX_PATH1; }
            set
            {
                if (m_DIAGNOSE_COOLWATER_FLUX_PATH1 != value)
                {
                    m_DIAGNOSE_COOLWATER_FLUX_PATH1 = value;
                    RaisePropertyChanged(() => DIAGNOSE_COOLWATER_FLUX_PATH1);
                }
            }
        }
        
        private double m_DIAGNOSE_COOLWATER_FLUX_PATH2;
        public double DIAGNOSE_COOLWATER_FLUX_PATH2
        {
            get { return m_DIAGNOSE_COOLWATER_FLUX_PATH2; }
            set
            {
                if (m_DIAGNOSE_COOLWATER_FLUX_PATH2 != value)
                {
                    m_DIAGNOSE_COOLWATER_FLUX_PATH2 = value;
                    RaisePropertyChanged(() => DIAGNOSE_COOLWATER_FLUX_PATH2);
                }
            }
        }
        
        private double m_DIAGNOSE_COOLWATER_TEMP;
        public double DIAGNOSE_COOLWATER_TEMP
        {
            get { return m_DIAGNOSE_COOLWATER_TEMP; }
            set
            {
                if (m_DIAGNOSE_COOLWATER_TEMP != value)
                {
                    m_DIAGNOSE_COOLWATER_TEMP = value;
                    RaisePropertyChanged(() => DIAGNOSE_COOLWATER_TEMP);
                }
            }
        }
        
        private double m_DIAGNOSE_FOGGING_TEMP;
        public double DIAGNOSE_FOGGING_TEMP
        {
            get { return m_DIAGNOSE_FOGGING_TEMP; }
            set
            {
                if (m_DIAGNOSE_FOGGING_TEMP != value)
                {
                    m_DIAGNOSE_FOGGING_TEMP = value;
                    RaisePropertyChanged(() => DIAGNOSE_FOGGING_TEMP);
                }
            }
        }
        
        private double m_DIAGNOSE_LASER_TEMP;
        public double DIAGNOSE_LASER_TEMP
        {
            get { return m_DIAGNOSE_LASER_TEMP; }
            set
            {
                if (m_DIAGNOSE_LASER_TEMP != value)
                {
                    m_DIAGNOSE_LASER_TEMP = value;
                    RaisePropertyChanged(() => DIAGNOSE_LASER_TEMP);
                }
            }
        }
        
        private double m_DIAGNOSE_LASER_HUMIDITY;
        public double DIAGNOSE_LASER_HUMIDITY
        {
            get { return m_DIAGNOSE_LASER_HUMIDITY; }
            set
            {
                if (m_DIAGNOSE_LASER_HUMIDITY != value)
                {
                    m_DIAGNOSE_LASER_HUMIDITY = value;
                    RaisePropertyChanged(() => DIAGNOSE_LASER_HUMIDITY);
                }
            }
        }
    }
}
