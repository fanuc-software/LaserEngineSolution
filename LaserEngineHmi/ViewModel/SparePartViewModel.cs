using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using DataCenter.Services;
using DataCenter.Model;
using LaserEngineHmi.View;

namespace LaserEngineHmi.ViewModel
{
    public class SparePartViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;
        private SparePartService _spSrv;

        public ICommand _AddCmd { get; set; }
        public ICommand _DeleteCmd { get; set; }
        public ICommand _EditCmd { get; set; }

        #region 属性
        private ObservableCollection<SparePartDto> m_SpareParts = new ObservableCollection<SparePartDto>();
        public ObservableCollection<SparePartDto> SpareParts
        {
            get { return m_SpareParts; }
            set
            {
                if (m_SpareParts != value)
                {
                    m_SpareParts = value;
                    RaisePropertyChanged(() => SpareParts);
                }
            }
        }

        private SparePartDto m_SelSparePart = new SparePartDto();
        public SparePartDto SelSparePart
        {
            get { return m_SelSparePart; }
            set
            {
                if (m_SelSparePart != value)
                {
                    m_SelSparePart = value;
                    RaisePropertyChanged(() => SelSparePart);
                }
            }
        }

        #endregion

        #region ctor
        public SparePartViewModel(IMapper mapper, Fanuc fanuc, SparePartService spSrv)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;
            this._spSrv = spSrv;

            _AddCmd = new RelayCommand(OnAdd);
            _DeleteCmd = new RelayCommand(OnDelete);
            _EditCmd = new RelayCommand(OnEdit);

            SpareParts = _spSrv.GetSpareParts();
        }

        #endregion

        private void OnAdd()
        {
            var win = new SparePartAddWindow();
            win.ShowDialog();

            SpareParts = _spSrv.GetSpareParts();
        }

        private void OnDelete()
        {
            if (SelSparePart == null)
            {
                Messenger.Default.Send<string>("请选择备件", "OperateNotice");
                return;
            }

            try
            {
                _spSrv.Delete(SelSparePart);
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<string>("删除备件失败", "OperateNotice");
            }

            SpareParts = _spSrv.GetSpareParts();
        }
        private void OnEdit()
        {
            if (SelSparePart == null)
            {
                Messenger.Default.Send<string>("请选择说明书", "OperateNotice");
                return;
            }

            var win = new SparePartEditWindow(SelSparePart);
            win.ShowDialog();

            SpareParts = _spSrv.GetSpareParts();
        }
    }
}
