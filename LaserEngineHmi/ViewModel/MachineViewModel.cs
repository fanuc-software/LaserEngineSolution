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
    public class MachineViewModel: ViewModelBase
    {
        #region properties
        private Page m_content;
        public Page _Machine_Content
        {
            get { return m_content; }
            set
            {
                if (m_content != value)
                {
                    m_content = value;
                    RaisePropertyChanged(() => _Machine_Content);
                }
            }
        }

        #endregion

        #region menu button
        private bool m_SimpleCornerMachiningClicked;
        public bool _SimpleCornerMachiningClicked
        {
            get { return m_SimpleCornerMachiningClicked; }
            set
            {
                if (m_SimpleCornerMachiningClicked != value)
                {
                    m_SimpleCornerMachiningClicked = value;
                    RaisePropertyChanged(() => _SimpleCornerMachiningClicked);
                }
            }
        }

        private bool m_AutoFindSideClicked;
        public bool _AutoFindSideClicked
        {
            get { return m_AutoFindSideClicked; }
            set
            {
                if (m_AutoFindSideClicked != value)
                {
                    m_AutoFindSideClicked = value;
                    RaisePropertyChanged(() => _AutoFindSideClicked);
                }
            }
        }

        private bool m_ManualFindSideClicked;
        public bool _ManualFindSideClicked
        {
            get { return m_ManualFindSideClicked; }
            set
            {
                if (m_ManualFindSideClicked != value)
                {
                    m_ManualFindSideClicked = value;
                    RaisePropertyChanged(() => _ManualFindSideClicked);
                }
            }
        }

        private bool m_AutoCutterCleanClicked;
        public bool _AutoCutterCleanClicked
        {
            get { return m_AutoCutterCleanClicked; }
            set
            {
                if (m_AutoCutterCleanClicked != value)
                {
                    m_AutoCutterCleanClicked = value;
                    RaisePropertyChanged(() => _AutoCutterCleanClicked);
                }
            }
        }

        private bool m_RemainCutClicked;
        public bool _RemainCutClicked
        {
            get { return m_RemainCutClicked; }
            set
            {
                if (m_RemainCutClicked != value)
                {
                    m_RemainCutClicked = value;
                    RaisePropertyChanged(() => _RemainCutClicked);
                }
            }
        }

        private bool m_SideInhectionClicked;
        public bool _SideInhectionClicked
        {
            get { return m_SideInhectionClicked; }
            set
            {
                if (m_SideInhectionClicked != value)
                {
                    m_SideInhectionClicked = value;
                    RaisePropertyChanged(() => _SideInhectionClicked);
                }
            }
        }

        private bool m_CutterResetCheckClicked;
        public bool _CutterResetCheckClicked
        {
            get { return m_CutterResetCheckClicked; }
            set
            {
                if (m_CutterResetCheckClicked != value)
                {
                    m_CutterResetCheckClicked = value;
                    RaisePropertyChanged(() => _CutterResetCheckClicked);
                }
            }
        }

        private bool m_AutoCalibtationClicked;
        public bool _AutoCalibtationClicked
        {
            get { return m_AutoCalibtationClicked; }
            set
            {
                if (m_AutoCalibtationClicked != value)
                {
                    m_AutoCalibtationClicked = value;
                    RaisePropertyChanged(() => _AutoCalibtationClicked);
                }
            }
        }

        private bool m_AutoCutReplaceClicked;
        public bool _AutoCutReplaceClicked
        {
            get { return m_AutoCutReplaceClicked; }
            set
            {
                if (m_AutoCutReplaceClicked != value)
                {
                    m_AutoCutReplaceClicked = value;
                    RaisePropertyChanged(() => _AutoCutReplaceClicked);
                }
            }
        }

        private bool m_ManuelChangeWorkStationClicked;
        public bool _ManuelChangeWorkStationClicked
        {
            get { return m_ManuelChangeWorkStationClicked; }
            set
            {
                if (m_ManuelChangeWorkStationClicked != value)
                {
                    m_ManuelChangeWorkStationClicked = value;
                    RaisePropertyChanged(() => _ManuelChangeWorkStationClicked);
                }
            }
        }

        private bool m_AreaDustCleanClicked;
        public bool _AreaDustCleanClicked
        {
            get { return m_AreaDustCleanClicked; }
            set
            {
                if (m_AreaDustCleanClicked != value)
                {
                    m_AreaDustCleanClicked = value;
                    RaisePropertyChanged(() => _AreaDustCleanClicked);
                }
            }
        }

        private bool m_CutCenterClicked;
        public bool _CutCenterClicked
        {
            get { return m_CutCenterClicked; }
            set
            {
                if (m_CutCenterClicked != value)
                {
                    m_CutCenterClicked = value;
                    RaisePropertyChanged(() => _CutCenterClicked);
                }
            }
        }

        private bool m_SimpleNestClicked;
        public bool _SimpleNestClicked
        {
            get { return m_SimpleNestClicked; }
            set
            {
                if (m_SimpleNestClicked != value)
                {
                    m_SimpleNestClicked = value;
                    RaisePropertyChanged(() => _SimpleNestClicked);
                }
            }
        }

        private bool m_PreFireClicked;
        public bool _PreFireClicked
        {
            get { return m_PreFireClicked; }
            set
            {
                if (m_PreFireClicked != value)
                {
                    m_PreFireClicked = value;
                    RaisePropertyChanged(() => _PreFireClicked);
                }
            }
        }

        private bool m_AuxGasCheckClicked;
        public bool _AuxGasCheckClicked
        {
            get { return m_AuxGasCheckClicked; }
            set
            {
                if (m_AuxGasCheckClicked != value)
                {
                    m_AuxGasCheckClicked = value;
                    RaisePropertyChanged(() => _AuxGasCheckClicked);
                }
            }
        }

        private bool m_AutoFocalPointClicked;
        public bool _AutoFocalPointClicked
        {
            get { return m_AutoFocalPointClicked; }
            set
            {
                if (m_AutoFocalPointClicked != value)
                {
                    m_AutoFocalPointClicked = value;
                    RaisePropertyChanged(() => _AutoFocalPointClicked);
                }
            }
        }


        public ICommand _SimpleCornerMachiningCmd { get; set; }
        public ICommand _AutoFindSideCmd { get; set; }

        public ICommand _ManualFindSideCmd { get; set; }
        public ICommand _AutoCutterCleanCmd { get; set; }
        public ICommand _RemainCutCleanCmd { get; set; }
        public ICommand _SideInhectionCmd { get; set; }
        public ICommand _CutterResetCheckCmd { get; set; }
        public ICommand _AutoCalibtationCmd { get; set; }
        public ICommand _AutoCutReplaceCmd { get; set; }
        public ICommand _ManuelChangeWorkStationCmd { get; set; }
        public ICommand _AreaDustCleanCmd { get; set; }
        public ICommand _CutCenterCmd { get; set; }
        public ICommand _SimpleNestCmd { get; set; }
        public ICommand _PreFireCmd { get; set; }

        public ICommand _AuxGasCheckCmd { get; set; }

        public ICommand _AutoFocalPointCmd { get; set; }

        #endregion

        #region ctol
        public MachineViewModel()
        {
            _SimpleCornerMachiningCmd = new RelayCommand(OnSimpleCornerMachiningClick);
            _AutoFindSideCmd = new RelayCommand(OnAutoFindSideClick);
            _AutoCutterCleanCmd = new RelayCommand(OnAutoCutterCleanClick);
            _RemainCutCleanCmd = new RelayCommand(OnRemainCutCleanClick);
            _SideInhectionCmd = new RelayCommand(OnSideInhectionClick);
            _CutterResetCheckCmd = new RelayCommand(OnCutterResetCheckClick);
            _AutoCalibtationCmd = new RelayCommand(OnAutoCalibtationClick);
            _AutoCutReplaceCmd = new RelayCommand(OnAutoCutReplaceClick);
            _ManuelChangeWorkStationCmd = new RelayCommand(OnManuelChangeWorkStationClick);
            _AreaDustCleanCmd = new RelayCommand(OnAreaDustCleanClick);
            _CutCenterCmd = new RelayCommand(OnCutCenterClick);
            _SimpleNestCmd = new RelayCommand(OnSimpleNestClick);
            _PreFireCmd = new RelayCommand(OnPreFireClick);
            _AuxGasCheckCmd = new RelayCommand(OnAuxGasCheckClick);
            _AutoFocalPointCmd = new RelayCommand(OnAutoFocalPointClick);
            _ManualFindSideCmd = new RelayCommand(OnManualFindSideClick);

            _Machine_Content = new AutoFindSidePage();
            ChangeMachineMenuButtonCheckedStatus(btn2: true);
        }

        #endregion

        #region private func
        private void ChangeMachineMenuButtonCheckedStatus(bool btn1 = false, bool btn2 = false, bool btn3 = false,
            bool btn4 = false, bool btn5 = false, bool btn6 = false, bool btn7 = false, bool btn8 = false,
            bool btn9 = false, bool btn10 = false, bool btn11 = false, bool btn12 = false, bool btn13 = false, 
            bool btn14=false, bool btn15=false,bool btn16=false)
        {
            _SimpleCornerMachiningClicked = btn1;
            _AutoFindSideClicked = btn2;
            _AutoCutterCleanClicked = btn3;
            _RemainCutClicked = btn4;
            _SideInhectionClicked = btn5;
            _CutterResetCheckClicked = btn6;
            _AutoCalibtationClicked = btn7;
            _AutoCutReplaceClicked = btn8;
            _ManuelChangeWorkStationClicked = btn9;
            _AreaDustCleanClicked = btn10;
            _CutCenterClicked = btn11;
            _SimpleNestClicked = btn12;
            _PreFireClicked = btn13;
            _AuxGasCheckClicked = btn14;
            _AutoFocalPointClicked = btn15;
            _ManualFindSideClicked = btn16;
        }
        #endregion

        #region menu func
        private void OnSimpleCornerMachiningClick()
        {
            ChangeMachineMenuButtonCheckedStatus(btn1: true);
            _Machine_Content = new SimpleCornerMachiningPage();
        }

        private void OnAutoFindSideClick()
        {
            ChangeMachineMenuButtonCheckedStatus(btn2: true);
            _Machine_Content = new AutoFindSidePage();
        }
        private void OnAutoCutterCleanClick()
        {
            ChangeMachineMenuButtonCheckedStatus(btn3: true);
            _Machine_Content = new AutoCutterCleanPage();
        }
        private void OnRemainCutCleanClick()
        {
            ChangeMachineMenuButtonCheckedStatus(btn4: true);
            _Machine_Content = new RemainCutPage();
        }
        private void OnSideInhectionClick()
        {
            ChangeMachineMenuButtonCheckedStatus(btn5: true);
        }
        private void OnCutterResetCheckClick()
        {
            ChangeMachineMenuButtonCheckedStatus(btn6: true);
            _Machine_Content = new CutterResetCheckPage();
        }
        private void OnAutoCalibtationClick()
        {
            ChangeMachineMenuButtonCheckedStatus(btn7: true);
        }
        private void OnAutoCutReplaceClick()
        {
            ChangeMachineMenuButtonCheckedStatus(btn8: true);
        }
        private void OnManuelChangeWorkStationClick()
        {
            ChangeMachineMenuButtonCheckedStatus(btn9: true);
            _Machine_Content = new ManuelChangeWorkStationPage();
        }
        private void OnAreaDustCleanClick()
        {
            ChangeMachineMenuButtonCheckedStatus(btn10: true);
        }
        private void OnCutCenterClick()
        {
            ChangeMachineMenuButtonCheckedStatus(btn11: true);
            _Machine_Content = new CutCenterPage();
        }
        private void OnSimpleNestClick()
        {
            ChangeMachineMenuButtonCheckedStatus(btn12: true);
            _Machine_Content = new SimpleNestPage();
        }
        private void OnPreFireClick()
        {
            ChangeMachineMenuButtonCheckedStatus(btn13: true);
        }

        private void OnAuxGasCheckClick()
        {
            ChangeMachineMenuButtonCheckedStatus(btn14: true);
            _Machine_Content = new AuxGasCheckPage();
        }

        private void OnAutoFocalPointClick()
        {
            ChangeMachineMenuButtonCheckedStatus(btn15: true);
            _Machine_Content = new AutoFocalPointPage();
        }

        private void OnManualFindSideClick()
        {
            ChangeMachineMenuButtonCheckedStatus(btn16: true);
            _Machine_Content = new ManualFindSidePage();
        }
        #endregion
    }
}
