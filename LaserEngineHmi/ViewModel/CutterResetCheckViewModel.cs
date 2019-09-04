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
    public class CutterResetCheckViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        #region 属性
        private double m_XPOS = new double();
        public double XPOS
        {
            get { return m_XPOS; }
            set
            {
                if (m_XPOS != value)
                {

                    var ret = _fanuc.CutterResetCheck_SET_XPOS(value);
                    if (ret != 0)
                    {

                        XPOS = m_XPOS;
                        return;
                    }
                    m_XPOS = value;
                    RaisePropertyChanged(() => XPOS);
                }
            }
        }

        private double m_YPOS = new double();
        public double YPOS
        {
            get { return m_YPOS; }
            set
            {
                if (m_YPOS != value)
                {

                    var ret = _fanuc.CutterResetCheck_SET_YPOS(value);
                    if (ret != 0)
                    {

                        YPOS = m_YPOS;
                        return;
                    }
                    m_YPOS = value;
                    RaisePropertyChanged(() => YPOS);
                }
            }
        }

        private double m_ZLIMIT = new double();
        public double ZLIMIT
        {
            get { return m_ZLIMIT; }
            set
            {
                if (m_ZLIMIT != value)
                {

                    var ret = _fanuc.CutterResetCheck_SET_ZLIMIT(value);
                    if (ret != 0)
                    {

                        ZLIMIT = m_ZLIMIT;
                        return;
                    }
                    m_ZLIMIT = value;
                    RaisePropertyChanged(() => ZLIMIT);
                }
            }
        }


        #endregion

        private ICommand StartCommand { get; set; }

        #region ctor
        public CutterResetCheckViewModel(IMapper mapper, Fanuc fanuc)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;

            double temp = 0;
            _fanuc.CutterResetCheck_GET_XPOS(ref temp);
            XPOS = temp;
            _fanuc.CutterResetCheck_GET_YPOS(ref temp);
            YPOS = temp;
            _fanuc.CutterResetCheck_GET_ZLIMIT(ref temp);
            ZLIMIT = temp;

            StartCommand = new RelayCommand(OnStart);

        }

        #endregion

        private void OnStart()
        {
            _fanuc.CutterResetCheck_Start();
        }
    }
}
