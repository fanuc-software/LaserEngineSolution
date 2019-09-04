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
    public class AutoCutterCleanViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        #region 属性
        private double m_XD = new double();
        public double XD
        {
            get { return m_XD; }
            set
            {
                if (m_XD != value)
                {

                    var ret = _fanuc.AutoCutterClean_SET_XD(value);
                    if (ret != 0)
                    {

                        XD = m_XD;
                        return;
                    }
                    m_XD = value;
                    RaisePropertyChanged(() => XD);
                }
            }
        }


        private double m_YD = new double();
        public double YD
        {
            get { return m_YD; }
            set
            {
                if (m_YD != value)
                {

                    var ret = _fanuc.AutoCutterClean_SET_YD(value);
                    if (ret != 0)
                    {

                        YD = m_YD;
                        return;
                    }
                    m_YD = value;
                    RaisePropertyChanged(() => YD);
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

                    var ret = _fanuc.AutoCutterClean_SET_H(value);
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

        private double m_CleanTime = new double();
        public double CleanTime
        {
            get { return m_CleanTime; }
            set
            {
                if (m_CleanTime != value)
                {

                    var ret = _fanuc.AutoCutterClean_SET_CLEANTIME(value);
                    if (ret != 0)
                    {

                        CleanTime = m_CleanTime;
                        return;
                    }
                    m_CleanTime = value;
                    RaisePropertyChanged(() => CleanTime);
                }
            }
        }

        private double m_ZLimit = new double();
        public double ZLimit
        {
            get { return m_ZLimit; }
            set
            {
                if (m_ZLimit != value)
                {

                    var ret = _fanuc.AutoCutterClean_SET_ZLIMIT(value);
                    if (ret != 0)
                    {

                        ZLimit = m_ZLimit;
                        return;
                    }
                    m_ZLimit = value;
                    RaisePropertyChanged(() => ZLimit);
                }
            }
        }


        #endregion

        private ICommand AUTO_CUTTER_CLEAN_START_CMD { get; set; }

        #region ctor
        public AutoCutterCleanViewModel(IMapper mapper, Fanuc fanuc)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;

            AUTO_CUTTER_CLEAN_START_CMD = new RelayCommand(ON_AUTO_CUTTER_CLEAN_START);

            double temp = 0;
            _fanuc.AutoCutterClean_GET_XD(ref temp);
            XD = temp;
            _fanuc.AutoCutterClean_GET_YD(ref temp);
            YD = temp;
            _fanuc.AutoCutterClean_GET_H(ref temp);
            H = temp;
            _fanuc.AutoCutterClean_GET_CLEANTIME(ref temp);
            CleanTime = temp;
            _fanuc.AutoCutterClean_GET_ZLIMIT(ref temp);
            ZLimit = temp;

            

        }

        #endregion

        private void ON_AUTO_CUTTER_CLEAN_START()
        {
            var ret = _fanuc.AutoCutterClean_Start();
            if (ret != 0)
            {
                Messenger.Default.Send<string>("程序调用失败，请检查操作方式", "OperateNotice");
            }
        }
    }
}
