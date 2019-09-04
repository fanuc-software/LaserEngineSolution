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
    public class AutoFindSideViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        private System.Timers.Timer timerR = new System.Timers.Timer();

        public ICommand LoadPageCommand { get; set; }
        public ICommand UnLoadPageCommand { get; set; }

        private ICommand StartAutoFindSideCommand { get; set; }

        #region 属性
        //private double m_XD = new double();
        //public double XD
        //{
        //    get { return m_XD; }
        //    set
        //    {
        //        if (m_XD != value)
        //        {

        //            var ret = _fanuc.AutoFindSide_SET_XD(value);
        //            if (ret != 0)
        //            {

        //                XD = m_XD;
        //                return;
        //            }
        //            m_XD = value;
        //            RaisePropertyChanged(() => XD);
        //        }
        //    }
        //}

        //private double m_YD = new double();
        //public double YD
        //{
        //    get { return m_YD; }
        //    set
        //    {
        //        if (m_YD != value)
        //        {

        //            var ret = _fanuc.AutoFindSide_SET_YD(value);
        //            if (ret != 0)
        //            {

        //                YD = m_YD;
        //                return;
        //            }
        //            m_YD = value;
        //            RaisePropertyChanged(() => YD);
        //        }
        //    }
        //}

        //private double m_SITA = new double();
        //public double SITA
        //{
        //    get { return m_SITA; }
        //    set
        //    {
        //        if (m_SITA != value)
        //        {

        //            var ret = _fanuc.AutoFindSide_SET_SITA(value);
        //            if (ret != 0)
        //            {

        //                SITA = m_SITA;
        //                return;
        //            }
        //            m_SITA = value;
        //            RaisePropertyChanged(() => SITA);
        //        }
        //    }
        //}

        private AutoFindSideInfoDto m_AutoFindSide_Info = new AutoFindSideInfoDto();
        public AutoFindSideInfoDto AutoFindSide_Info
        {
            get { return m_AutoFindSide_Info; }
            set
            {
                if (m_AutoFindSide_Info != value)
                {
                    m_AutoFindSide_Info = value;
                    RaisePropertyChanged(() => AutoFindSide_Info);
                }
            }
        }

        private double m_H = new double();
        public double H
        {
            get { return m_H; }
            set
            {
                if (m_H != value)
                {

                    var ret = _fanuc.AutoFindSide_SET_H(value);
                    if (ret != 0)
                    {

                        H = m_H;
                        return;
                    }
                    m_H = value;
                    RaisePropertyChanged(() => H);
                }
            }
        }

        private double m_X = new double();
        public double X
        {
            get { return m_X; }
            set
            {
                if (m_X != value)
                {

                    var ret = _fanuc.AutoFindSide_SET_X(value);
                    if (ret != 0)
                    {

                        X = m_X;
                        return;
                    }
                    m_X = value;
                    RaisePropertyChanged(() => X);
                }
            }
        }

        private double m_Y = new double();
        public double Y
        {
            get { return m_Y; }
            set
            {
                if (m_Y != value)
                {

                    var ret = _fanuc.AutoFindSide_SET_Y(value);
                    if (ret != 0)
                    {

                        Y = m_Y;
                        return;
                    }
                    m_Y = value;
                    RaisePropertyChanged(() => Y);
                }
            }
        }

        private double m_RH = new double();
        public double RH
        {
            get { return m_RH; }
            set
            {
                if (m_RH != value)
                {

                    var ret = _fanuc.AutoFindSide_SET_RH(value);
                    if (ret != 0)
                    {

                        RH = m_RH;
                        return;
                    }
                    m_RH = value;
                    RaisePropertyChanged(() => RH);
                }
            }
        }

        #endregion     

        #region ctor
        public AutoFindSideViewModel(IMapper mapper, Fanuc fanuc)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;

            LoadPageCommand = new RelayCommand(ON_LoadPageCommand);
            UnLoadPageCommand = new RelayCommand(ON_UnLoadPageCommand);
            StartAutoFindSideCommand = new RelayCommand(OnStartAutoFindSide);

            //double temp = 0;
            //_fanuc.AutoFindSide_GET_H(ref temp);
            //H = temp;
            //_fanuc.AutoFindSide_GET_X(ref temp);
            //X = temp;
            //_fanuc.AutoFindSide_GET_Y(ref temp);
            //Y = temp;
            //_fanuc.AutoFindSide_GET_RH(ref temp);
            //RH = temp;

            timerR.Interval = System.Convert.ToDouble(10);
            timerR.Elapsed += new System.Timers.ElapsedEventHandler(OnInitial);
            timerR.Enabled = true;
            timerR.AutoReset = false;


            Messenger.Default.Register<AutoFindSideInfo>(this, "AutoFindSideInfoMsg", OnRefreshAutoFindSideInfo);

        }

        private void OnInitial(object sender, System.Timers.ElapsedEventArgs e)
        {
            double temp_h = 0;
            _fanuc.AutoFindSide_GET_H(ref temp_h);
            //H = temp;
            double temp_x = 0;
            _fanuc.AutoFindSide_GET_X(ref temp_x);
            //X = temp;

            double temp_y = 0;
            _fanuc.AutoFindSide_GET_Y(ref temp_y);
            //Y = temp;

            double temp_rh = 0;
            _fanuc.AutoFindSide_GET_RH(ref temp_rh);
            //RH = temp;


            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                H = temp_h;
                X = temp_x;
                Y = temp_y;
                RH = temp_rh;
            });


        }

        #endregion



        private void OnRefreshAutoFindSideInfo(AutoFindSideInfo info)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                AutoFindSide_Info = _mapper.Map<AutoFindSideInfo, AutoFindSideInfoDto>(info);
            });
        }

        private void OnStartAutoFindSide()
        {
            var ret = _fanuc.AutoFindSide_Start();
            if(ret!=0)
            {
                Messenger.Default.Send<string>("程序调用失败，请检查操作方式", "OperateNotice");
            }
        }

        private void ON_LoadPageCommand()
        {
            _fanuc.ScannerAutoFindSide_Start();
        }

        private void ON_UnLoadPageCommand()
        {
            _fanuc.ScannerAutoFindSide_Cancel();
        }
    }
}
