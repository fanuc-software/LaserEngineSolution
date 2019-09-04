using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
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
using LaserEngineHmi.View;
using LaserEngineHmi.Enum;
using UserCenter;
using FanucCnc;
using LaserEngineHmi.Model;

namespace LaserEngineHmi.ViewModel
{
    public class LoadingWaitViewModel : ViewModelBase
    {
        private Fanuc _fanuc;

        //private System.Timers.Timer timerL = new System.Timers.Timer();

        private string m_message;
        public string _Message
        {
            get { return m_message; }
            set
            {
                if (m_message != value)
                {
                    m_message = value;
                    RaisePropertyChanged(() => _Message);
                }
            }
        }

        private string m_ConnStat;
        public string _ConnStat
        {
            get { return m_ConnStat; }
            set
            {
                if (m_ConnStat != value)
                {
                    m_ConnStat = value;
                    RaisePropertyChanged(() => _ConnStat);
                }
            }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand CloseCommand { get; set; }

        private BackgroundWorker m_conn_test = new BackgroundWorker();

        public LoadingWaitViewModel(Fanuc fanuc)
        {
            this._fanuc = fanuc;

            LoginCommand = new RelayCommand(OnReLoginClick);
            CloseCommand = new RelayCommand(OnCloseClick);

            //timerL.Interval = System.Convert.ToDouble(5000);
            //timerL.Elapsed += new System.Timers.ElapsedEventHandler(OnLoad);
            //timerL.Enabled = false;
            //timerL.AutoReset = false;

            m_conn_test.WorkerReportsProgress = false;
            m_conn_test.WorkerSupportsCancellation = true;
            m_conn_test.DoWork += OnLoadBK;

            m_conn_test.RunWorkerAsync();

            _ConnStat = "Hidden";
            _Message = "";
        }

        private void OnLoadBK(object sender, DoWorkEventArgs e)
        {
            var ret = _fanuc.ConnectTest();
            if (ret == 0)
            {
                Messenger.Default.Send<bool>(true, "LoadingFinishMsg");
            }
            else
            {
                //DispatcherHelper.CheckBeginInvokeOnUI(() =>
                //{
                    _Message = "CNC连接失败，请重新连接";
                    _ConnStat = "Visible";
                //});
            }
        }

        private void OnLoad(object sender, DoWorkEventArgs e)
        {
            var ret = _fanuc.ConnectTest();
            if (ret == 0)
            {
                Messenger.Default.Send<bool>(true, "LoadingFinishMsg");
            }
            else
            {
                DispatcherHelper.CheckBeginInvokeOnUI(() =>
                {
                    _Message = "CNC连接失败，请重新连接";
                    _ConnStat = "Visible";
                });
            }

            //timerL.Enabled = false;
        }


        private void OnReLoginClick()
        {
            //timerL.Enabled = true;
            _ConnStat = "Hidden";
            _Message = "";
        }

        private void OnCloseClick()
        {
            Messenger.Default.Send<bool>(false, "LoadingFinishMsg");
        }

        private void OnLoad(object sender, System.Timers.ElapsedEventArgs e)
        {
            var ret = _fanuc.ConnectTest();
            if (ret == 0)
            {
                Messenger.Default.Send<bool>(true, "LoadingFinishMsg");
            }
            else
            {
                DispatcherHelper.CheckBeginInvokeOnUI(() =>
                {
                    _Message = "CNC连接失败，请重新连接"; 
                    _ConnStat = "Visible";
                });
            }
        }
    }
}
