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
    public class WorkStationInfoDto : ViewModelBase
    {
        private bool m_MainWorkStationUp;
        public bool MainWorkStationUp
        {
            get { return m_MainWorkStationUp; }
            set
            {
                if (m_MainWorkStationUp != value)
                {
                    m_MainWorkStationUp = value;
                    RaisePropertyChanged(() => MainWorkStationUp);
                }
            }
        }

        private bool m_MainWorkStationDown;
        public bool MainWorkStationDown
        {
            get { return m_MainWorkStationDown; }
            set
            {
                if (m_MainWorkStationDown != value)
                {
                    m_MainWorkStationDown = value;
                    RaisePropertyChanged(() => MainWorkStationDown);
                }
            }
        }

        private bool m_MainWorkStationLeft;
        public bool MainWorkStationLeft
        {
            get { return m_MainWorkStationLeft; }
            set
            {
                if (m_MainWorkStationLeft != value)
                {
                    m_MainWorkStationLeft = value;
                    RaisePropertyChanged(() => MainWorkStationLeft);
                }
            }
        }

        private bool m_MainWorkStationRight;
        public bool MainWorkStationRight
        {
            get { return m_MainWorkStationRight; }
            set
            {
                if (m_MainWorkStationRight != value)
                {
                    m_MainWorkStationRight = value;
                    RaisePropertyChanged(() => MainWorkStationRight);
                }
            }
        }

        private bool m_SubWorkStationUp;
        public bool SubWorkStationUp
        {
            get { return m_MainWorkStationRight; }
            set
            {
                if (m_SubWorkStationUp != value)
                {
                    m_SubWorkStationUp = value;
                    RaisePropertyChanged(() => SubWorkStationUp);
                }
            }
        }


        private bool m_SubWorkStationDown;
        public bool SubWorkStationDown
        {
            get { return m_SubWorkStationDown; }
            set
            {
                if (m_SubWorkStationDown != value)
                {
                    m_SubWorkStationDown = value;
                    RaisePropertyChanged(() => SubWorkStationDown);
                }
            }
        }

        private bool m_SubWorkStationLeft;
        public bool SubWorkStationLeft
        {
            get { return m_SubWorkStationLeft; }
            set
            {
                if (m_SubWorkStationLeft != value)
                {
                    m_SubWorkStationLeft = value;
                    RaisePropertyChanged(() => SubWorkStationLeft);
                }
            }
        }

        private bool m_SubWorkStationRight;
        public bool SubWorkStationRight
        {
            get { return m_SubWorkStationRight; }
            set
            {
                if (m_SubWorkStationRight != value)
                {
                    m_SubWorkStationRight = value;
                    RaisePropertyChanged(() => SubWorkStationRight);
                }
            }
        }
    }
}
