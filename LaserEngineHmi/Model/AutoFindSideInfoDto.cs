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
    public class AutoFindSideInfoDto : ViewModelBase
    {
        private double m_XD;
        public double XD
        {
            get { return m_XD; }
            set
            {
                if (m_XD != value)
                {
                    m_XD = value;
                    RaisePropertyChanged(() => XD);
                }
            }
        }

        private double m_YD;
        public double YD
        {
            get { return m_YD; }
            set
            {
                if (m_YD != value)
                {
                    m_YD = value;
                    RaisePropertyChanged(() => YD);
                }
            }
        }

        private double m_SITA;
        public double SITA
        {
            get { return m_SITA; }
            set
            {
                if (m_SITA != value)
                {
                    m_SITA = value;
                    RaisePropertyChanged(() => SITA);
                }
            }
        }
        
    }
}
