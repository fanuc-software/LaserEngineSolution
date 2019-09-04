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
    public class OpMessageViewModel : ViewModelBase
    {
        private IMapper _mapper;

        private ObservableCollection<LaserEngineHmi.Model.CncMessage> _messageList = new ObservableCollection<LaserEngineHmi.Model.CncMessage>();
        public ObservableCollection<LaserEngineHmi.Model.CncMessage> _MessageList
        {
            get { return _messageList; }
            set
            {
                if (_messageList != value)
                {
                    _messageList = value;
                    RaisePropertyChanged(() => _MessageList);
                }
            }
        }
        public OpMessageViewModel(IMapper mapper)
        {
            this._mapper = mapper;

            Messenger.Default.Register<CncStateInfo>(this, "CncStateMsg", msg =>
            {
                var CncStateInfo = _mapper.Map<CncStateInfo, CncStateInfoDto>(msg);

                DispatcherHelper.CheckBeginInvokeOnUI(() =>
                {
                    _MessageList.Clear();
                    CncStateInfo.CncMessageList.ForEach(x => _MessageList.Add(x));
                });
            });
        }
    }
}
