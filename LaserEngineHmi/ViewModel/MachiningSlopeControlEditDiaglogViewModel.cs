using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using System.Collections.ObjectModel;
using DataCenter.Services;
using DataCenter.Model;

namespace LaserEngineHmi.ViewModel
{

    public class MachiningSlopeControlEditDiaglogViewModel : ViewModelBase
    {
        public ICommand _ApplicateCmd { get; set; }

        public ICommand _SaveCmd { get; set; }

        private MachiningLib_SlopeControlDto selSlopeControlData = new MachiningLib_SlopeControlDto();
        public MachiningLib_SlopeControlDto _SelSlopeControlData
        {
            get { return selSlopeControlData; }
            set
            {
                if (selSlopeControlData != value)
                {
                    selSlopeControlData = value;
                    RaisePropertyChanged(() => _SelSlopeControlData);
                }
            }
        }

        private string notice;
        public string _Notice
        {
            get { return notice; }
            set
            {
                if (notice != value)
                {
                    notice = value;
                    RaisePropertyChanged(() => _Notice);
                }
            }
        }

        private void SendNocite(string notice)
        {
            _Notice = notice;

            System.Timers.Timer timerB = new System.Timers.Timer();//刷新时间
            timerB.Interval = System.Convert.ToDouble(3000);
            timerB.Elapsed += new System.Timers.ElapsedEventHandler(ClearNotice);
            timerB.Enabled = true;
            timerB.AutoReset = false;
        }

        private void ClearNotice(object sender, System.Timers.ElapsedEventArgs e)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                _Notice = "";
            });


        }

        public MachiningSlopeControlEditDiaglogViewModel(MachiningLib_SlopeControlDto data)
        {
            _SelSlopeControlData = data;

            _ApplicateCmd = new RelayCommand(OnApplicateClick);
            _SaveCmd = new RelayCommand(OnSaveClick);
        }

        private void OnApplicateClick()
        {
            Messenger.Default.Send<MachiningLib_SlopeControlDto>(_SelSlopeControlData, "MachiningLibSlopeControlDataApplicate");
            Messenger.Default.Send<string>("", "MachiningSlopeControlEditDiaglogClose");
        }

        private void OnSaveClick()
        {
            Messenger.Default.Send<MachiningLib_SlopeControlDto>(_SelSlopeControlData, "MachiningLibSlopeControlDataSave");
            Messenger.Default.Send<string>("", "MachiningSlopeControlEditDiaglogClose");
        }

    }
}
