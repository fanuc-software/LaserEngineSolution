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
    public class AlarmListViewModel : ViewModelBase
    {
        private IMapper _mapper;

        private ObservableCollection<LaserEngineHmi.Model.CncAlarm> _alarmList=new ObservableCollection<LaserEngineHmi.Model.CncAlarm>();
        public ObservableCollection<LaserEngineHmi.Model.CncAlarm> _AlarmList
        {
            get { return _alarmList; }
            set
            {
                if (_alarmList != value)
                {
                    _alarmList = value;
                    RaisePropertyChanged(() => _AlarmList);
                }
            }
        }
        public AlarmListViewModel(IMapper mapper)
        {
            this._mapper = mapper;

            Messenger.Default.Register<CncStateInfo>(this, "CncStateMsg", msg =>
            {
                var CncStateInfo = _mapper.Map<CncStateInfo, CncStateInfoDto>(msg);

                string[] alm_type = { "SW", "PW", "IO", "PS", "OT", "OH", "SV", "SR", "MC", "SP", "DS", "IE", "BG", "SN", "", "EX", "", "", "", "PC" };
                string[] alm_axis = { "", "(X)", "(Y)", "(Z)" };

                DispatcherHelper.CheckBeginInvokeOnUI(() =>
                {
                    _AlarmList.Clear();

                    CncStateInfo.CncAlarmList.ForEach(x => _AlarmList.Add(x));
                });
            });
        }

    }
}
