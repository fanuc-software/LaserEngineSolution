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
    public class IOViewModel : ViewModelBase
    {
        #region properties
        private Page m_content;
        public Page _IO_Content
        {
            get { return m_content; }
            set
            {
                if (m_content != value)
                {
                    m_content = value;
                    RaisePropertyChanged(() => _IO_Content);
                }
            }
        }

        #endregion

        #region menu button
        private bool m_UICopyClicked;
        public bool _UICopyClicked
        {
            get { return m_UICopyClicked; }
            set
            {
                if (m_UICopyClicked != value)
                {
                    m_UICopyClicked = value;
                    RaisePropertyChanged(() => _UICopyClicked);
                }
            }
        }

        private bool m_ProgramTransClicked;
        public bool _ProgramTransClicked
        {
            get { return m_ProgramTransClicked; }
            set
            {
                if (m_ProgramTransClicked != value)
                {
                    m_ProgramTransClicked = value;
                    RaisePropertyChanged(() => _ProgramTransClicked);
                }
            }
        }

        private bool m_FactoryInitialClicked;
        public bool _FactoryInitialClicked
        {
            get { return m_FactoryInitialClicked; }
            set
            {
                if (m_FactoryInitialClicked != value)
                {
                    m_FactoryInitialClicked = value;
                    RaisePropertyChanged(() => _FactoryInitialClicked);
                }
            }
        }

        public ICommand _UICopyCmd { get; set; }
        public ICommand _ProgramTransCmd { get; set; }
        public ICommand _FactoryInitialCmd { get; set; }

        #endregion

        #region ctol
        public IOViewModel()
        {
            _UICopyCmd = new RelayCommand(OnUICopyClick);
            _ProgramTransCmd = new RelayCommand(OnProgramTransClick);
            _FactoryInitialCmd = new RelayCommand(OnFactoryInitialClick);

            _IO_Content = new ProgramTransPage();
            ChangeIOMenuButtonCheckedStatus(btn2: true);
        }

        #endregion

        #region private func
        private void ChangeIOMenuButtonCheckedStatus(bool btn1 = false, bool btn2 = false, bool btn3 = false)
        {
            _UICopyClicked = btn1;
            _ProgramTransClicked = btn2;
            _FactoryInitialClicked = btn3;
        }

        #endregion

        #region menu func
        private void OnUICopyClick()
        {
            ChangeIOMenuButtonCheckedStatus(btn1: true);
            _IO_Content = new UICopyPage();
        }

        private void OnProgramTransClick()
        {
            ChangeIOMenuButtonCheckedStatus(btn2: true);
            _IO_Content = new ProgramTransPage();
        }

        private void OnFactoryInitialClick()
        {
            ChangeIOMenuButtonCheckedStatus(btn3: true);
            _IO_Content = new FactoryInitialPage();
        }

        #endregion

    }
}
