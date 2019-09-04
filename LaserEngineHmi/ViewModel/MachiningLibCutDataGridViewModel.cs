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
using LaserEngineHmi.View;

namespace LaserEngineHmi.ViewModel
{
    public class MachiningLibCutDataGridViewModel : ViewModelBase
    {
        public ICommand _EditCmd { get; set; }

        #region 属性
        private ObservableCollection<MachiningLib_CuttingDto> cutDatas;
        public ObservableCollection<MachiningLib_CuttingDto> _CutDatas
        {
            get { return cutDatas; }
            set
            {
                if (cutDatas != value)
                {
                    cutDatas = value;
                    RaisePropertyChanged(() => _CutDatas);
                }
            }
        }

        private MachiningLib_CuttingDto selCutData;
        public MachiningLib_CuttingDto _SelCutData
        {
            get { return selCutData; }
            set
            {
                if (selCutData != value)
                {
                    selCutData = value;
                    RaisePropertyChanged(() => _SelCutData);
                }
            }
        }

        #endregion

        #region ctrl

        public MachiningLibCutDataGridViewModel()
        {
            _EditCmd = new RelayCommand(OnEditClick);

            Messenger.Default.Register<ObservableCollection<MachiningLib_CuttingDto>>(this, "MachiningLibCutDataShow", msg =>
            {
                _CutDatas = msg;
            });
        }

        private void OnEditClick()
        {
            if (_SelCutData == null)
            {
                Messenger.Default.Send<string>("请选择切割工艺参数", "OperateNotice");

                return;
            }

            var diaglog = new MachiningCutEditDiaglog(_SelCutData);
            diaglog.ShowDialog();
        }
        #endregion


    }
}
