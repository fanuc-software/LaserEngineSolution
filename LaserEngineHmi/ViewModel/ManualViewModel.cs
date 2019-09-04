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
    public class ManualViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;
        private ManualService _mSrv;

        public ICommand _AddCmd { get; set; }
        public ICommand _DeleteCmd { get; set; }
        public ICommand _OpenCmd { get; set; }

        private ObservableCollection<ManualDto> manuals = new ObservableCollection<ManualDto>();
        public ObservableCollection<ManualDto> Manuals
        {
            get { return manuals; }
            set
            {
                if (manuals != value)
                {
                    manuals = value;
                    RaisePropertyChanged(() => Manuals);
                }
            }
        }

        private ManualDto selManual = new ManualDto();
        public ManualDto SelManual
        {
            get { return selManual; }
            set
            {
                if (selManual != value)
                {
                    selManual = value;
                    RaisePropertyChanged(() => SelManual);
                }
            }
        }





        #region ctor
        public ManualViewModel(IMapper mapper, Fanuc fanuc, ManualService mSrv)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;
            this._mSrv = mSrv;

            _AddCmd = new RelayCommand(OnAdd);
            _DeleteCmd = new RelayCommand(OnDelete);
            _OpenCmd = new RelayCommand(OnOpen);
            
            Manuals = _mSrv.GetManuals();
            if (Manuals.Count != 0) SelManual = Manuals.First();



        }

        #endregion

        private void OnAdd()
        {
            var win = new ManualAddWindow();
            win.ShowDialog();

            Manuals = _mSrv.GetManuals();
            if (Manuals.Count != 0) SelManual = Manuals.First();
        }

        private void OnDelete()
        {
            if (SelManual == null)
            {
                Messenger.Default.Send<string>("请选择说明书", "OperateNotice");
                return;
            }

            try
            {
                _mSrv.Delete(SelManual);
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<string>("删除说明书失败", "OperateNotice");
            }


            Manuals = _mSrv.GetManuals();
            if (Manuals.Count != 0) SelManual = Manuals.First();
        }
        private void OnOpen()
        {
            if (SelManual == null)
            {
                Messenger.Default.Send<string>("请选择说明书", "OperateNotice");
                return;
            }

            try
            {
                //System.Diagnostics.Process.Start(@"AcroRd32.exe", SelManual.Path);

                System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
                myProcess.StartInfo.FileName = SelManual.Path;
                myProcess.StartInfo.Verb = "Open";
                myProcess.StartInfo.CreateNoWindow = true;

                myProcess.Start();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<string>("打开说明书失败", "OperateNotice");
            }
        }
    }
}
