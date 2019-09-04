using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using LaserEngineHmi.View;

namespace LaserEngineHmi.ViewModel
{
    public class MaintainViewModel : ViewModelBase
    {

        #region properties
        private Page m_content;
        public Page _Maintain_Content
        {
            get { return m_content; }
            set
            {
                if (m_content != value)
                {
                    m_content = value;
                    RaisePropertyChanged(() => _Maintain_Content);
                }
            }
        }

        #endregion

        #region menu button
        private bool m_MachineOffsetClicked;
        public bool _MachineOffsetClicked
        {
            get { return m_MachineOffsetClicked; }
            set
            {
                if (m_MachineOffsetClicked != value)
                {
                    m_MachineOffsetClicked = value;
                    RaisePropertyChanged(() => _MachineOffsetClicked);
                }
            }
        }

        private bool m_SoftwareOffsetClicked;
        public bool _SoftwareOffsetClicked
        {
            get { return m_SoftwareOffsetClicked; }
            set
            {
                if (m_SoftwareOffsetClicked != value)
                {
                    m_SoftwareOffsetClicked = value;
                    RaisePropertyChanged(() => _SoftwareOffsetClicked);
                }
            }
        }

        private bool m_UserOffsetClicked;
        public bool _UserOffsetClicked
        {
            get { return m_UserOffsetClicked; }
            set
            {
                if (m_UserOffsetClicked != value)
                {
                    m_UserOffsetClicked = value;
                    RaisePropertyChanged(() => _UserOffsetClicked);
                }
            }
        }

        private bool m_SparePartClicked;
        public bool _SparePartClicked
        {
            get { return m_SparePartClicked; }
            set
            {
                if (m_SparePartClicked != value)
                {
                    m_SparePartClicked = value;
                    RaisePropertyChanged(() => _SparePartClicked);
                }
            }
        }

        private bool m_ManualClicked;
        public bool _ManualClicked
        {
            get { return m_ManualClicked; }
            set
            {
                if (m_ManualClicked != value)
                {
                    m_ManualClicked = value;
                    RaisePropertyChanged(() => _ManualClicked);
                }
            }
        }

        public ICommand _MachineOffsetCmd { get; set; }
        public ICommand _SoftwareOffsetCmd { get; set; }
        public ICommand _UserOffsetCmd { get; set; }
        public ICommand _SparePartCmd { get; set; }
        public ICommand _ManualCmd { get; set; }

        #endregion

        #region ctol
        public MaintainViewModel()
        {
            _MachineOffsetCmd = new RelayCommand(OnMachineOffsetClick);
            _SoftwareOffsetCmd = new RelayCommand(OnSoftwareOffsetClick);
            _UserOffsetCmd = new RelayCommand(OnUserOffsetClick);
            _SparePartCmd = new RelayCommand(OnSparePartClick);
            _ManualCmd = new RelayCommand(OnManualClick);

            _Maintain_Content = new MachineOffsetPage();
            ChangeMaintainMenuButtonCheckedStatus(btn1: true);
        }

        #endregion

        #region private func
        private void ChangeMaintainMenuButtonCheckedStatus(bool btn1 = false, bool btn2 = false, bool btn3 = false,
            bool btn4 = false, bool btn5 = false)
        {
            _MachineOffsetClicked = btn1;
            _SoftwareOffsetClicked = btn2;
            _UserOffsetClicked = btn3;
            _SparePartClicked = btn4;
            _ManualClicked = btn5;
        }
        #endregion

        #region menu func
        private void OnMachineOffsetClick()
        {
            ChangeMaintainMenuButtonCheckedStatus(btn1: true);
            _Maintain_Content = new MachineOffsetPage();
        }

        private void OnSoftwareOffsetClick()
        {
            ChangeMaintainMenuButtonCheckedStatus(btn2: true);
            _Maintain_Content = new SoftwareOffsetPage();
        }

        private void OnUserOffsetClick()
        {
            ChangeMaintainMenuButtonCheckedStatus(btn3: true);
            _Maintain_Content = new UserOffsetPage();
        }

        private void OnSparePartClick()
        {
            ChangeMaintainMenuButtonCheckedStatus(btn4: true);
            _Maintain_Content = new SparePartPage();
        }

        private void OnManualClick()
        {
            ChangeMaintainMenuButtonCheckedStatus(btn5: true);
            _Maintain_Content = new ManualPage();
        }

        #endregion

    }
}
