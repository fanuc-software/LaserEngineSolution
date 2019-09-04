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
    public class SimpleNestViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        #region 属性
        private int m_ROW = new int();
        public int ROW
        {
            get { return m_ROW; }
            set
            {
                if (m_ROW != value)
                {

                    var ret = _fanuc.SimpleNest_SET_ROW(value);
                    if (ret != 0)
                    {

                        ROW = m_ROW;
                        return;
                    }
                    m_ROW = value;
                    RaisePropertyChanged(() => ROW);
                }
            }
        }


        private int m_COLOM = new int();
        public int COLOM
        {
            get { return m_COLOM; }
            set
            {
                if (m_COLOM != value)
                {

                    var ret = _fanuc.SimpleNest_SET_COLOM(value);
                    if (ret != 0)
                    {

                        COLOM = m_COLOM;
                        return;
                    }
                    m_COLOM = value;
                    RaisePropertyChanged(() => COLOM);
                }
            }
        }

        private double m_XSIZE = new double();
        public double XSIZE
        {
            get { return m_XSIZE; }
            set
            {
                if (m_XSIZE != value)
                {

                    var ret = _fanuc.SimpleNest_SET_XSIZE(value);
                    if (ret != 0)
                    {

                        XSIZE = m_XSIZE;
                        return;
                    }
                    m_XSIZE = value;
                    RaisePropertyChanged(() => XSIZE);
                }
            }
        }

        private double m_YSIZE = new double();
        public double YSIZE
        {
            get { return m_YSIZE; }
            set
            {
                if (m_YSIZE != value)
                {

                    var ret = _fanuc.SimpleNest_SET_YSIZE(value);
                    if (ret != 0)
                    {

                        YSIZE = m_YSIZE;
                        return;
                    }
                    m_YSIZE = value;
                    RaisePropertyChanged(() => YSIZE);
                }
            }
        }

        private int m_G75G76 = new int();
        public int G75G76
        {
            get { return m_G75G76; }
            set
            {
                if (m_G75G76 != value)
                {

                    var ret = _fanuc.SimpleNest_SET_G75G76(value);
                    if (ret != 0)
                    {

                        G75G76 = m_G75G76;
                        return;
                    }
                    m_G75G76 = value;
                    RaisePropertyChanged(() => G75G76);
                }
            }
        }

        private int m_Q = new int();
        public int Q
        {
            get { return m_Q; }
            set
            {
                if (m_Q != value)
                {

                    var ret = _fanuc.SimpleNest_SET_Q(value);
                    if (ret != 0)
                    {

                        Q = m_Q;
                        return;
                    }
                    m_Q = value;
                    RaisePropertyChanged(() => Q);
                }
            }
        }

        private int m_PROGRAM = new int();
        public int PROGRAM
        {
            get { return m_PROGRAM; }
            set
            {
                if (m_PROGRAM != value)
                {

                    var ret = _fanuc.SimpleNest_SET_PROGRAM(value);
                    if (ret != 0)
                    {

                        PROGRAM = m_PROGRAM;
                        return;
                    }
                    m_PROGRAM = value;
                    RaisePropertyChanged(() => PROGRAM);
                }
            }
        }

        #endregion

        private ICommand StartCommand { get; set; }

        #region ctor
        public SimpleNestViewModel(IMapper mapper, Fanuc fanuc)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;

            int temp = 0;
            _fanuc.SimpleNest_GET_ROW(ref temp);
            ROW = temp;
            _fanuc.SimpleNest_GET_COLOM(ref temp);
            COLOM = temp;
            _fanuc.SimpleNest_GET_G75G76(ref temp);
            G75G76 = temp;
            _fanuc.SimpleNest_GET_Q(ref temp);
            Q = temp;
            _fanuc.SimpleNest_GET_PRORGAM(ref temp);
            PROGRAM = temp;

            double dtemp = 0;
            _fanuc.SimpleNest_GET_XSIZE(ref dtemp);
            XSIZE = temp;
            _fanuc.SimpleNest_GET_YSIZE(ref dtemp);
            YSIZE = temp;

            StartCommand = new RelayCommand(OnStart);

        }

        #endregion

        private void OnStart()
        {
            _fanuc.SimpleNest_Start();
        }


    }
}
