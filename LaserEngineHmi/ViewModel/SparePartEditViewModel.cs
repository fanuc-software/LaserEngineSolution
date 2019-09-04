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
    public class SparePartEditViewModel : ViewModelBase
    {
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

        public SparePartEditViewModel(SparePartDto dto)
        {
            SparePart = dto;
            CancelCmd = new RelayCommand(OnCancelCmd);
            ConfirmCmd = new RelayCommand(OnConfirmCmd);

        }

        public void OnConfirmCmd()
        {
            SparePartService srv = SimpleIoc.Default.GetInstance<SparePartService>();
            srv.Edit(SparePart);

            Messenger.Default.Send<bool>(true, "SparePartEditQuitMsg");
        }

        public void OnCancelCmd()
        {
            Messenger.Default.Send<bool>(false, "SparePartEditQuitMsg");
        }

    }
}
