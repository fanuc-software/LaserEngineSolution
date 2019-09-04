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
    public class MachiningPiercingEditDiaglogViewModel : ViewModelBase
    {
        public ICommand _ApplicateCmd { get; set; }

        public ICommand _SaveCmd { get; set; }

        private MachiningLib_PiercingDto selPiercingData = new MachiningLib_PiercingDto();
        public MachiningLib_PiercingDto _SelPiercingData
        {
            get { return selPiercingData; }
            set
            {
                if (selPiercingData != value)
                {
                    selPiercingData = value;
                    RaisePropertyChanged(() => _SelPiercingData);
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

        public MachiningPiercingEditDiaglogViewModel(MachiningLib_PiercingDto data)
        {
            _SelPiercingData = data;

            _ApplicateCmd = new RelayCommand(OnApplicateClick);
            _SaveCmd = new RelayCommand(OnSaveClick);
        }

        private void OnApplicateClick()
        {
            Messenger.Default.Send<MachiningLib_PiercingDto>(_SelPiercingData, "MachiningLibPiercingDataApplicate");
            Messenger.Default.Send<string>("", "MachiningPiercingEditDiaglogClose");
        }

        private void OnSaveClick()
        {
            Messenger.Default.Send<MachiningLib_PiercingDto>(_SelPiercingData, "MachiningLibPiercingDataSave");
            Messenger.Default.Send<string>("", "MachiningPiercingEditDiaglogClose");
        }

    }
}
