using System;
using System.Collections.Generic;
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

namespace LaserEngineHmi.ViewModel
{
    public class SimpleCornerMachiningViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        #region 属性
        private double m_H = new double();
        public double H
        {
            get { return m_H; }
            set
            {
                if (m_H != value)
                {
                    
                    var ret = _fanuc.SimpleCorner_SET_H(value);
                    if (ret != 0)
                    {

                        H = m_H;
                        return;
                    }
                    m_H = value;
                    RaisePropertyChanged(() => H);
                }
            }
        }

        private double m_I = new double();
        public double I
        {
            get { return m_I; }
            set
            {
                if (m_I != value)
                {
                    var ret = _fanuc.SimpleCorner_SET_I(value);
                    if (ret != 0)
                    {

                        I = m_I;
                        return;
                    }
                    m_I = value;
                    RaisePropertyChanged(() => I);
                }
            }
        }

        private double m_J = new double();
        public double J
        {
            get { return m_J; }
            set
            {
                if (m_J != value)
                {
                    var ret = _fanuc.SimpleCorner_SET_J(value);
                    if (ret != 0)
                    {

                        J = m_J;
                        return;
                    }

                    m_J = value;
                    RaisePropertyChanged(() => J);
                }
            }
        }

        private double m_D = new double();
        public double D
        {
            get { return m_D; }
            set
            {
                if (m_D != value)
                {
                    var ret = _fanuc.SimpleCorner_SET_D(value);
                    if (ret != 0)
                    {

                        D = m_D;
                        return;
                    }

                    m_D = value;
                    RaisePropertyChanged(() => D);
                }
            }
        }

        private double m_R = new double();
        public double R
        {
            get { return m_R; }
            set
            {
                if (m_R != value)
                {
                    var ret = _fanuc.SimpleCorner_SET_R(value);
                    if (ret != 0)
                    {

                        R = m_R;
                        return;
                    }

                    m_R = value;
                    RaisePropertyChanged(() => R);
                }
            }
        }

        private double m_CE = new double();
        public double CE
        {
            get { return m_CE; }
            set
            {
                if (m_CE != value)
                {
                    var ret = _fanuc.SimpleCorner_SET_CE(value);
                    if (ret != 0)
                    {

                        CE = m_CE;
                        return;
                    }

                    m_CE = value;
                    RaisePropertyChanged(() => CE);
                }
            }
        }

        private double m_PE = new double();
        public double PE
        {
            get { return m_PE; }
            set
            {
                if (m_PE != value)
                {
                    var ret = _fanuc.SimpleCorner_SET_PE(value);
                    if (ret != 0)
                    {

                        PE = m_PE;
                        return;
                    }

                    m_PE = value;
                    RaisePropertyChanged(() => PE);
                }
            }
        }

        #endregion

        #region TYPE MENU
        private bool m_Scm01Clicked;
        public bool _Scm01Clicked
        {
            get { return m_Scm01Clicked; }
            set
            {
                if (m_Scm01Clicked != value)
                {
                    m_Scm01Clicked = value;
                    RaisePropertyChanged(() => _Scm01Clicked);
                }
            }
        }

        private bool m_Scm02Clicked;
        public bool _Scm02Clicked
        {
            get { return m_Scm02Clicked; }
            set
            {
                if (m_Scm02Clicked != value)
                {
                    m_Scm02Clicked = value;
                    RaisePropertyChanged(() => _Scm02Clicked);
                }
            }
        }

        private bool m_Scm03Clicked;
        public bool _Scm03Clicked
        {
            get { return m_Scm03Clicked; }
            set
            {
                if (m_Scm03Clicked != value)
                {
                    m_Scm03Clicked = value;
                    RaisePropertyChanged(() => _Scm03Clicked);
                }
            }
        }

        private bool m_Scm04Clicked;
        public bool _Scm04Clicked
        {
            get { return m_Scm04Clicked; }
            set
            {
                if (m_Scm04Clicked != value)
                {
                    m_Scm04Clicked = value;
                    RaisePropertyChanged(() => _Scm04Clicked);
                }
            }
        }

        private bool m_Scm05Clicked;
        public bool _Scm05Clicked
        {
            get { return m_Scm05Clicked; }
            set
            {
                if (m_Scm05Clicked != value)
                {
                    m_Scm05Clicked = value;
                    RaisePropertyChanged(() => _Scm05Clicked);
                }
            }
        }

        private bool m_Scm06Clicked;
        public bool _Scm06Clicked
        {
            get { return m_Scm06Clicked; }
            set
            {
                if (m_Scm06Clicked != value)
                {
                    m_Scm06Clicked = value;
                    RaisePropertyChanged(() => _Scm06Clicked);
                }
            }
        }

        private bool m_Scm07Clicked;
        public bool _Scm07Clicked
        {
            get { return m_Scm07Clicked; }
            set
            {
                if (m_Scm07Clicked != value)
                {
                    m_Scm07Clicked = value;
                    RaisePropertyChanged(() => _Scm07Clicked);
                }
            }
        }

        private bool m_Scm08Clicked;
        public bool _Scm08Clicked
        {
            get { return m_Scm08Clicked; }
            set
            {
                if (m_Scm08Clicked != value)
                {
                    m_Scm08Clicked = value;
                    RaisePropertyChanged(() => _Scm08Clicked);
                }
            }
        }

        public ICommand _Scm01Cmd { get; set; }
        public ICommand _Scm02Cmd { get; set; }
        public ICommand _Scm03Cmd { get; set; }
        public ICommand _Scm04Cmd { get; set; }
        public ICommand _Scm05Cmd { get; set; }
        public ICommand _Scm06Cmd { get; set; }
        public ICommand _Scm07Cmd { get; set; }
        public ICommand _Scm08Cmd { get; set; }
        #endregion

        private string m_ImagePath;
        public string _ImagePath
        {
            get { return m_ImagePath; }
            set
            {
                if (m_ImagePath != value)
                {
                    m_ImagePath = value;
                    RaisePropertyChanged(() => _ImagePath);
                }
            }
        }

        private ICommand GenerateCommand { get; set; }

        #region ctor
        public SimpleCornerMachiningViewModel(IMapper mapper, Fanuc fanuc)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;

            _Scm01Cmd = new RelayCommand(OnScm01Click);
            _Scm02Cmd = new RelayCommand(OnScm02Click);
            _Scm03Cmd = new RelayCommand(OnScm03Click);
            _Scm04Cmd = new RelayCommand(OnScm04Click);
            _Scm05Cmd = new RelayCommand(OnScm05Click);
            _Scm06Cmd = new RelayCommand(OnScm06Click);
            _Scm07Cmd = new RelayCommand(OnScm07Click);
            _Scm08Cmd = new RelayCommand(OnScm08Click);

            double temp = 0;
            _fanuc.SimpleCorner_GET_H(ref temp);
            H = temp;
            _fanuc.SimpleCorner_GET_I(ref temp);
            I = temp;
            _fanuc.SimpleCorner_GET_J(ref temp);
            J = temp;
            _fanuc.SimpleCorner_GET_D(ref temp);
            D = temp;
            _fanuc.SimpleCorner_GET_R(ref temp);
            R = temp;
            _fanuc.SimpleCorner_GET_CE(ref temp);
            CE = temp;
            _fanuc.SimpleCorner_GET_PE(ref temp);
            PE = temp;
            GenerateCommand = new RelayCommand(OnGenerate);
            
        }

        #endregion

        private void OnGenerate()
        {
            _fanuc.SimpleCorner_Generate();
        }

        private void ChangeScmCheckedStatus(bool btn1 = false, bool btn2 = false, bool btn3 = false,
            bool btn4 = false, bool btn5 = false, bool btn6 = false, bool btn7 = false, bool btn8 = false)
        {
            _Scm01Clicked = btn1;
            _Scm02Clicked = btn2;
            _Scm03Clicked = btn3;
            _Scm04Clicked = btn4;
            _Scm05Clicked = btn5;
            _Scm06Clicked = btn6;
            _Scm07Clicked = btn7;
            _Scm08Clicked = btn8;
        }

        private void OnScm01Click()
        {
            ChangeScmCheckedStatus(btn1: true);
            _ImagePath = "/LaserEngineHmi;component/Resources/images/scm_01_d.png";
        }
        private void OnScm02Click()
        {
            ChangeScmCheckedStatus(btn2: true);
        }
        private void OnScm03Click()
        {
            ChangeScmCheckedStatus(btn3: true);
        }
        private void OnScm04Click()
        {
            ChangeScmCheckedStatus(btn4: true);
        }
        private void OnScm05Click()
        {
            ChangeScmCheckedStatus(btn5: true);
        }
        private void OnScm06Click()
        {
            ChangeScmCheckedStatus(btn6: true);
        }
        private void OnScm07Click()
        {
            ChangeScmCheckedStatus(btn7: true);
        }
        private void OnScm08Click()
        {
            ChangeScmCheckedStatus(btn8: true);
        }
    }
}
