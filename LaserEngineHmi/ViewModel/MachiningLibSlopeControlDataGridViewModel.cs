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
    public class MachiningLibSlopeControlDataGridViewModel: ViewModelBase
    {
        public ICommand _EditCmd { get; set; }

        #region 属性
        private ObservableCollection<MachiningLib_SlopeControlDto> slopeControlDatas;
        public ObservableCollection<MachiningLib_SlopeControlDto> _SlopeControlDatas
        {
            get { return slopeControlDatas; }
            set
            {
                if (slopeControlDatas != value)
                {
                    slopeControlDatas = value;
                    RaisePropertyChanged(() => _SlopeControlDatas);
                }
            }
        }

        private MachiningLib_SlopeControlDto selSlopeControlData;
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

        #endregion

        #region ctrl

        public MachiningLibSlopeControlDataGridViewModel()
        {
            _EditCmd = new RelayCommand(OnEditClick);

            Messenger.Default.Register<ObservableCollection<MachiningLib_SlopeControlDto>>(this, "MachiningLibSlopeControlDataShow", msg =>
            {
                _SlopeControlDatas = msg;
            });
        }

        #endregion

        private void OnEditClick()
        {
            if (_SelSlopeControlData == null)
            {
                Messenger.Default.Send<string>("请选择功率控制工艺参数", "OperateNotice");
                return;
            }

            var diaglog = new MachiningSlopeControlEditDiaglog(_SelSlopeControlData);
            diaglog.ShowDialog();
        }

    }
}
