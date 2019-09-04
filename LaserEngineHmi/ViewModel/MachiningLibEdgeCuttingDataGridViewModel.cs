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
    public class MachiningLibEdgeCuttingDataGridViewModel : ViewModelBase
    {
        public ICommand _EditCmd { get; set; }

        #region 属性
        private ObservableCollection<MachiningLib_EdgeCuttingDto> edgeCuttingDatas;
        public ObservableCollection<MachiningLib_EdgeCuttingDto> _EdgeCuttingDatas
        {
            get { return edgeCuttingDatas; }
            set
            {
                if (edgeCuttingDatas != value)
                {
                    edgeCuttingDatas = value;
                    RaisePropertyChanged(() => _EdgeCuttingDatas);
                }
            }
        }

        private MachiningLib_EdgeCuttingDto selEdgeCuttingData;
        public MachiningLib_EdgeCuttingDto _SelEdgeCuttingData
        {
            get { return selEdgeCuttingData; }
            set
            {
                if (selEdgeCuttingData != value)
                {
                    selEdgeCuttingData = value;
                    RaisePropertyChanged(() => _SelEdgeCuttingData);
                }
            }
        }

        #endregion

        #region ctrl

        public MachiningLibEdgeCuttingDataGridViewModel()
        {
            _EditCmd = new RelayCommand(OnEditClick);

            Messenger.Default.Register<ObservableCollection<MachiningLib_EdgeCuttingDto>>(this, "MachiningLibEdgeCuttingDataShow", msg =>
            {
                _EdgeCuttingDatas = msg;
            });
        }

        #endregion

        private void OnEditClick()
        {
            if (_SelEdgeCuttingData == null)
            {
                Messenger.Default.Send<string>("请选择尖角工艺参数", "OperateNotice");
                return;
            }

            var diaglog = new MachiningEdgeCuttingEditDiaglog(_SelEdgeCuttingData);
            diaglog.ShowDialog();
        }
    }
}
