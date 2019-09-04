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
    public class AutoFocalPointViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadPageCommand { get; set; }
        public ICommand UnLoadPageCommand { get; set; }

        public ICommand SetCommand { get; set; }


        private double m_FirPiercePoint;
        public double _FirPiercePoint
        {
            get { return m_FirPiercePoint; }
            set
            {
                if (m_FirPiercePoint != value)
                {

                    m_FirPiercePoint = value;
                    RaisePropertyChanged(() => _FirPiercePoint);
                }
            }
        }

        private double m_SecPiercePoint;
        public double _SecPiercePoint
        {
            get { return m_SecPiercePoint; }
            set
            {
                if (m_SecPiercePoint != value)
                {

                    m_SecPiercePoint = value;
                    RaisePropertyChanged(() => _SecPiercePoint);
                }
            }
        }

        private double m_ThdPiercePoint;
        public double _ThdPiercePoint
        {
            get { return m_ThdPiercePoint; }
            set
            {
                if (m_ThdPiercePoint != value)
                {

                    m_ThdPiercePoint = value;
                    RaisePropertyChanged(() => _ThdPiercePoint);
                }
            }
        }

        private double m_CutPoint;
        public double _CutPoint
        {
            get { return m_CutPoint; }
            set
            {
                if (m_CutPoint != value)
                {

                    m_CutPoint = value;
                    RaisePropertyChanged(() => _CutPoint);
                }
            }
        }

        public AutoFocalPointViewModel(IMapper mapper, Fanuc fanuc)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;

            LoadPageCommand = new RelayCommand(ON_LoadPageCommand);
            UnLoadPageCommand = new RelayCommand(ON_UnLoadPageCommand);

            SetCommand = new RelayCommand(OnSetCommand);
        }

        private void OnSetCommand()
        {
           var ret = _fanuc.AutoFocalPoint_SET(_FirPiercePoint, _SecPiercePoint, _ThdPiercePoint, _CutPoint);

            if (ret != 0)
            {
                Messenger.Default.Send<string>("自动焦点位置设定错误", "OperateNotice");
            }
        }

        private void ON_LoadPageCommand()
        {
            double temp = 0;
            _fanuc.AutoFocalPoint_GET_1ST(ref temp);
            _FirPiercePoint = temp;

            _fanuc.AutoFocalPoint_GET_2ND(ref temp);
            _SecPiercePoint = temp;

            _fanuc.AutoFocalPoint_GET_3RD(ref temp);
            _ThdPiercePoint = temp;
            
            _fanuc.AutoFocalPoint_GET_CUT(ref temp);
            _CutPoint = temp;
        }

        private void ON_UnLoadPageCommand()
        {

        }

    }
}
