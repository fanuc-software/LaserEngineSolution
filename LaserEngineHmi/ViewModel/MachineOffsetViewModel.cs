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
using ConfigCenter;

namespace LaserEngineHmi.ViewModel
{
    public class MachineOffsetViewModel : ViewModelBase
    {
        private IMapper _mapper;

        #region 属性
        private string m_MachineType;
        public string MachineType
        {
            get { return m_MachineType; }
            set
            {
                if (m_MachineType != value)
                {
                    m_MachineType = value;

                    var config = new ConfigHelper();
                    config.SetMachineType(m_MachineType);
                    RaisePropertyChanged(() => MachineType);
                }
            }
        }

        private string m_CncType;
        public string CncType
        {
            get { return m_CncType; }
            set
            {
                if (m_CncType != value)
                {
                    m_CncType = value;

                    var config = new ConfigHelper();
                    config.SetCncType(m_CncType);
                    RaisePropertyChanged(() => CncType);
                }
            }
        }

        private double m_XDistance;
        public double XDistance
        {
            get { return m_XDistance; }
            set
            {
                if (m_XDistance != value)
                {
                    m_XDistance = value;

                    var config = new ConfigHelper();
                    config.SetXDistance(m_XDistance);
                    RaisePropertyChanged(() => XDistance);
                }
            }
        }

        private double m_YDistance;
        public double YDistance
        {
            get { return m_YDistance; }
            set
            {
                if (m_YDistance != value)
                {
                    m_YDistance = value;

                    var config = new ConfigHelper();
                    config.SetYDistance(m_YDistance);
                    RaisePropertyChanged(() => YDistance);
                }
            }
        }

        private double m_ZDistance;
        public double ZDistance
        {
            get { return m_ZDistance; }
            set
            {
                if (m_ZDistance != value)
                {
                    m_ZDistance = value;

                    var config = new ConfigHelper();
                    config.SetZDistance(m_ZDistance);
                    RaisePropertyChanged(() => ZDistance);
                }
            }
        }

        private string m_XMotorType;
        public string XMotorType
        {
            get { return m_XMotorType; }
            set
            {
                if (m_XMotorType != value)
                {
                    m_XMotorType = value;

                    var config = new ConfigHelper();
                    config.SetXMotorType(m_XMotorType);
                    RaisePropertyChanged(() => XMotorType);
                }
            }
        }

        private string m_YMotorType;
        public string YMotorType
        {
            get { return m_YMotorType; }
            set
            {
                if (m_YMotorType != value)
                {
                    m_YMotorType = value;

                    var config = new ConfigHelper();
                    config.SetYMotorType(m_YMotorType);
                    RaisePropertyChanged(() => YMotorType);
                }
            }
        }

        private string m_ZMotorType;
        public string ZMotorType
        {
            get { return m_ZMotorType; }
            set
            {
                if (m_ZMotorType != value)
                {
                    m_ZMotorType = value;

                    var config = new ConfigHelper();
                    config.SetZMotorType(m_ZMotorType);
                    RaisePropertyChanged(() => ZMotorType);
                }
            }
        }

        private string m_LaserType;
        public string LaserType
        {
            get { return m_LaserType; }
            set
            {
                if (m_LaserType != value)
                {
                    m_LaserType = value;

                    var config = new ConfigHelper();
                    config.SetLaserType(m_LaserType);
                    RaisePropertyChanged(() => LaserType);
                }
            }
        }

        private string m_CutterType;
        public string CutterType
        {
            get { return m_CutterType; }
            set
            {
                if (m_CutterType != value)
                {
                    m_CutterType = value;

                    var config = new ConfigHelper();
                    config.SetCutterType(m_CutterType);
                    RaisePropertyChanged(() => CutterType);
                }
            }
        }

        private string m_OpticalType;
        public string OpticalType
        {
            get { return m_OpticalType; }
            set
            {
                if (m_OpticalType != value)
                {
                    m_OpticalType = value;

                    var config = new ConfigHelper();
                    config.SetOpticalType(m_OpticalType);
                    RaisePropertyChanged(() => OpticalType);
                }
            }
        }

        #endregion

        #region ctor
        public MachineOffsetViewModel(IMapper mapper, Fanuc fanuc)
        {
            this._mapper = mapper;

            var config = new ConfigHelper();
            config.GetCncType(out m_CncType);
            config.GetMachineType(out m_MachineType);
            config.GetXDistance(out m_XDistance);
            config.GetYDistance(out m_YDistance);
            config.GetZDistance(out m_ZDistance);
            config.GetXMotorType(out m_XMotorType);
            config.GetYMotorType(out m_YMotorType);
            config.GetZMotorType(out m_ZMotorType);
            config.GetLaserType(out m_LaserType);
            config.GetCutterType(out m_CutterType);
            config.GetOpticalType(out m_OpticalType);
        }

        #endregion

    }
}
