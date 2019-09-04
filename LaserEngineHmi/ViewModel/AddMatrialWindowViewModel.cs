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

namespace LaserEngineHmi.ViewModel
{
    public class AddMatrialWindowViewModel : ViewModelBase
    {

        private MachiningLibService m_mchiningSrv;
        public ICommand _SaveCmd { get; set; }

        private double matrialThickness;
        public double _MatrialThickness
        {
            get { return matrialThickness; }
            set
            {
                if (matrialThickness != value)
                {
                    matrialThickness = value;
                    RaisePropertyChanged(() => _MatrialThickness);
                }
            }
        }

        private string matrialName;
        public string _MatrialName
        {
            get { return matrialName; }
            set
            {
                if (matrialName != value)
                {
                    matrialName = value;
                    RaisePropertyChanged(() => _MatrialName);
                }
            }
        }

        private double cutterDiameter;
        public double _CutterDiameter
        {
            get { return cutterDiameter; }
            set
            {
                if (cutterDiameter != value)
                {
                    cutterDiameter = value;
                    RaisePropertyChanged(() => _CutterDiameter);
                }
            }
        }

        private short g_Kind;
        public short _G_Kind
        {
            get { return g_Kind; }
            set
            {
                if (g_Kind != value)
                {
                    g_Kind = value;
                    RaisePropertyChanged(() => _G_Kind);
                }
            }
        }


        public AddMatrialWindowViewModel(MachiningLibService mchiningSrv)
        {
            m_mchiningSrv = mchiningSrv;

            _SaveCmd = new RelayCommand(OnSaveClick);
        }

        private void OnSaveClick()
        {
           var ret =  m_mchiningSrv.AddMachiningLib_Material(_MatrialName, _MatrialThickness, _CutterDiameter, _G_Kind);

            if (ret == false)
            {
                Messenger.Default.Send<string>("添加材料失败", "OperateNotice");
            }
            else
            {
                Messenger.Default.Send<string>("添加材料成功", "OperateNotice");
                Messenger.Default.Send<string>("", "AddMachiningLib_MaterialWindowClose");
            }

            
        }
    }
}
