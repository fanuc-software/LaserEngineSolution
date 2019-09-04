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
    public class MachiningLibPiercingDataGridViewModel : ViewModelBase
    {

        public ICommand _EditCmd { get; set; }

        #region 属性
        private ObservableCollection<MachiningLib_PiercingDto> piercingDatas;
        public ObservableCollection<MachiningLib_PiercingDto> _PiercingDatas
        {
            get { return piercingDatas; }
            set
            {
                if (piercingDatas != value)
                {
                    piercingDatas = value;
                    RaisePropertyChanged(() => _PiercingDatas);
                }
            }
        }

        private MachiningLib_PiercingDto selPiercingData;
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

        #endregion

        #region ctrl

        public MachiningLibPiercingDataGridViewModel()
        {
            _EditCmd = new RelayCommand(OnEditClick);

            Messenger.Default.Register<ObservableCollection<MachiningLib_PiercingDto>>(this, "MachiningLibPiercingDataShow", msg =>
            {
                _PiercingDatas = msg;
            });
        }

        #endregion


        private void OnEditClick()
        {
            if (_SelPiercingData == null)
            {
                Messenger.Default.Send<string>("请选择穿孔工艺参数", "OperateNotice");
                return;
            }

            var diaglog = new MachiningPiercingEditDiaglog(_SelPiercingData);
            diaglog.ShowDialog();
        }
    }
}
