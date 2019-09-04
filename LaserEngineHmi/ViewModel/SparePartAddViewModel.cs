using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using AutoMapper;
using FanucCnc;
using LaserEngineHmi.Model;
using DataCenter.Services;
using DataCenter.Model;
using LaserEngineHmi.View;

namespace LaserEngineHmi.ViewModel
{
    public class SparePartAddViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;
        private SparePartService _mSrv;

        public ICommand CancelCmd { get; set; }
        public ICommand ConfirmCmd { get; set; }

        private SparePartDto m_SparePart = new SparePartDto();
        public SparePartDto SparePart
        {
            get { return m_SparePart; }
            set
            {
                if (m_SparePart != value)
                {
                    m_SparePart = value;
                    RaisePropertyChanged(() => SparePart);
                }
            }
        }

        public SparePartAddViewModel(IMapper mapper, Fanuc fanuc, SparePartService mSrv)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;
            this._mSrv = mSrv;

            CancelCmd = new RelayCommand(OnCancelCmd);
            ConfirmCmd = new RelayCommand(OnConfirmCmd);
            
        }

        public void OnConfirmCmd()
        {
            _mSrv.Add(SparePart);

            Messenger.Default.Send<bool>(true, "SparePartAddQuitMsg");
        }

        public void OnCancelCmd()
        {
            Messenger.Default.Send<bool>(false, "SparePartAddQuitMsg");
        }
    }
}
