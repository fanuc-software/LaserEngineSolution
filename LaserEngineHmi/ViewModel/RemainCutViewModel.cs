using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using AutoMapper;
using FanucCnc;
using LaserEngineHmi.Model;

namespace LaserEngineHmi.ViewModel
{
    public class RemainCutViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        #region 属性
        private double m_CE = new double();
        public double CE
        {
            get { return m_CE; }
            set
            {
                if (m_CE != value)
                {

                    var ret = _fanuc.RemainCut_SET_CE(value);
                    if (ret != 0)
                    {

                        CE = m_CE;
                        return;
                    }
                    m_CE = value;
                    RaisePropertyChanged(() => CE);
                }
            }
        }

        private double m_PE = new double();
        public double PE
        {
            get { return m_PE; }
            set
            {
                if (m_PE != value)
                {

                    var ret = _fanuc.RemainCut_SET_PE(value);
                    if (ret != 0)
                    {

                        PE = m_PE;
                        return;
                    }
                    m_PE = value;
                    RaisePropertyChanged(() => PE);
                }
            }
        }

        private double m_P1_X = new double();
        public double P1_X
        {
            get { return m_P1_X; }
            set
            {
                if (m_P1_X != value)
                {

                    var ret = _fanuc.RemainCut_SET_P1_X(value);
                    if (ret != 0)
                    {

                        P1_X = m_P1_X;
                        return;
                    }
                    m_P1_X = value;
                    RaisePropertyChanged(() => P1_X);
                }
            }
        }

        private double m_P1_Y = new double();
        public double P1_Y
        {
            get { return m_P1_Y; }
            set
            {
                if (m_P1_Y != value)
                {

                    var ret = _fanuc.RemainCut_SET_P1_Y(value);
                    if (ret != 0)
                    {

                        P1_Y = m_P1_Y;
                        return;
                    }
                    m_P1_Y = value;
                    RaisePropertyChanged(() => P1_Y);
                }
            }
        }

        private double m_P2_X = new double();
        public double P2_X
        {
            get { return m_P2_X; }
            set
            {
                if (m_P2_X != value)
                {

                    var ret = _fanuc.RemainCut_SET_P2_X(value);
                    if (ret != 0)
                    {

                        P2_X = m_P2_X;
                        return;
                    }
                    m_P2_X = value;
                    RaisePropertyChanged(() => P2_X);
                }
            }
        }

        private double m_P2_Y = new double();
        public double P2_Y
        {
            get { return m_P2_Y; }
            set
            {
                if (m_P2_Y != value)
                {

                    var ret = _fanuc.RemainCut_SET_P1_Y(value);
                    if (ret != 0)
                    {

                        P2_Y = m_P2_Y;
                        return;
                    }
                    m_P2_Y = value;
                    RaisePropertyChanged(() => P2_Y);
                }
            }
        }

        private double m_P3_X = new double();
        public double P3_X
        {
            get { return m_P3_X; }
            set
            {
                if (m_P3_X != value)
                {

                    var ret = _fanuc.RemainCut_SET_P3_X(value);
                    if (ret != 0)
                    {

                        P3_X = m_P3_X;
                        return;
                    }
                    m_P3_X = value;
                    RaisePropertyChanged(() => P3_X);
                }
            }
        }

        private double m_P3_Y = new double();
        public double P3_Y
        {
            get { return m_P3_Y; }
            set
            {
                if (m_P3_Y != value)
                {

                    var ret = _fanuc.RemainCut_SET_P3_Y(value);
                    if (ret != 0)
                    {

                        P3_Y = m_P3_Y;
                        return;
                    }
                    m_P3_Y = value;
                    RaisePropertyChanged(() => P3_Y);
                }
            }
        }

        private double m_P4_X = new double();
        public double P4_X
        {
            get { return m_P4_X; }
            set
            {
                if (m_P4_X != value)
                {

                    var ret = _fanuc.RemainCut_SET_P4_X(value);
                    if (ret != 0)
                    {

                        P4_X = m_P4_X;
                        return;
                    }
                    m_P4_X = value;
                    RaisePropertyChanged(() => P4_X);
                }
            }
        }

        private double m_P4_Y = new double();
        public double P4_Y
        {
            get { return m_P4_Y; }
            set
            {
                if (m_P4_Y != value)
                {

                    var ret = _fanuc.RemainCut_SET_P4_Y(value);
                    if (ret != 0)
                    {

                        P4_Y = m_P4_Y;
                        return;
                    }
                    m_P4_Y = value;
                    RaisePropertyChanged(() => P4_Y);
                }
            }
        }

        #endregion

        private ICommand StartCommand { get; set; }
        private ICommand GetP1Command { get; set; }
        private ICommand GetP2Command { get; set; }
        private ICommand GetP3Command { get; set; }
        private ICommand GetP4Command { get; set; }

        public RemainCutViewModel(IMapper mapper, Fanuc fanuc)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;

            double temp = 0;
            _fanuc.RemainCut_GET_CE(ref temp);
            CE = temp;
            _fanuc.RemainCut_GET_PE(ref temp);
            PE = temp;
            _fanuc.RemainCut_GET_P1_X(ref temp);
            P1_X = temp;
            _fanuc.RemainCut_GET_P1_Y(ref temp);
            P1_Y = temp;
            _fanuc.RemainCut_GET_P2_X(ref temp);
            P2_X = temp;
            _fanuc.RemainCut_GET_P2_Y(ref temp);
            P2_Y = temp;
            _fanuc.RemainCut_GET_P3_X(ref temp);
            P3_X = temp;
            _fanuc.RemainCut_GET_P3_Y(ref temp);
            P3_Y = temp;
            _fanuc.RemainCut_GET_P4_X(ref temp);
            P4_X = temp;
            _fanuc.RemainCut_GET_P4_Y(ref temp);
            P4_Y = temp;

            StartCommand = new RelayCommand(OnStart);
            GetP1Command = new RelayCommand(OnGetP1);
            GetP2Command = new RelayCommand(OnGetP2);
            GetP3Command = new RelayCommand(OnGetP3);
            GetP4Command = new RelayCommand(OnGetP4);

        }

        private void OnStart()
        {
            _fanuc.RemainCut_Start();
        }

        private void OnGetP1()
        {
            double xpos = 0;
            double ypos = 0;
            double zpos = 0;
            var ret = _fanuc.RemainCut_GET_MachinePosition(ref xpos, ref ypos, ref zpos);
            if (ret != 0) return;

            P1_X = xpos;
            P1_Y = ypos;
        }

        private void OnGetP2()
        {
            double xpos = 0;
            double ypos = 0;
            double zpos = 0;
            var ret = _fanuc.RemainCut_GET_MachinePosition(ref xpos, ref ypos, ref zpos);
            if (ret != 0) return;

            P2_X = xpos;
            P2_Y = ypos;
        }

        private void OnGetP3()
        {
            double xpos = 0;
            double ypos = 0;
            double zpos = 0;
            var ret = _fanuc.RemainCut_GET_MachinePosition(ref xpos, ref ypos, ref zpos);
            if (ret != 0) return;

            P3_X = xpos;
            P3_Y = ypos;
        }

        private void OnGetP4()
        {
            double xpos = 0;
            double ypos = 0;
            double zpos = 0;
            var ret = _fanuc.RemainCut_GET_MachinePosition(ref xpos, ref ypos, ref zpos);
            if (ret != 0) return;

            P4_X = xpos;
            P4_Y = ypos;
        }

    }
}
