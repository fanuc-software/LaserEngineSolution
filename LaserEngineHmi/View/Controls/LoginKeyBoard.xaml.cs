using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LaserEngineHmi.View.Controls
{
    /// <summary>
    /// LoginKeyBoard.xaml 的交互逻辑
    /// </summary>
    public partial class LoginKeyBoard : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region 私有变量
        private static System.Windows.Controls.Control _CurrentControl;
        private static UserControl _InstanceObject;

        #endregion

        private bool capsLockFlag;
        public bool CapsLockFlag
        {
            get { return capsLockFlag; }
            set
            {
                if (capsLockFlag != value)
                {
                    capsLockFlag = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("CapsLockFlag"));
                    }
                }
            }
        }

        #region COMMAND
        public static RoutedUICommand _CmdQ = new RoutedUICommand();
        public static RoutedUICommand _CmdW = new RoutedUICommand();
        public static RoutedUICommand _CmdE = new RoutedUICommand();
        public static RoutedUICommand _CmdR = new RoutedUICommand();
        public static RoutedUICommand _CmdT = new RoutedUICommand();
        public static RoutedUICommand _CmdY = new RoutedUICommand();
        public static RoutedUICommand _CmdU = new RoutedUICommand();
        public static RoutedUICommand _CmdI = new RoutedUICommand();
        public static RoutedUICommand _CmdO = new RoutedUICommand();
        public static RoutedUICommand _CmdP = new RoutedUICommand();

        public static RoutedUICommand _CmdA = new RoutedUICommand();
        public static RoutedUICommand _CmdS = new RoutedUICommand();
        public static RoutedUICommand _CmdD = new RoutedUICommand();
        public static RoutedUICommand _CmdF = new RoutedUICommand();
        public static RoutedUICommand _CmdG = new RoutedUICommand();
        public static RoutedUICommand _CmdH = new RoutedUICommand();
        public static RoutedUICommand _CmdJ = new RoutedUICommand();
        public static RoutedUICommand _CmdK = new RoutedUICommand();
        public static RoutedUICommand _CmdL = new RoutedUICommand();

        public static RoutedUICommand _CmdZ = new RoutedUICommand();
        public static RoutedUICommand _CmdX = new RoutedUICommand();
        public static RoutedUICommand _CmdC = new RoutedUICommand();
        public static RoutedUICommand _CmdV = new RoutedUICommand();
        public static RoutedUICommand _CmdB = new RoutedUICommand();
        public static RoutedUICommand _CmdN = new RoutedUICommand();
        public static RoutedUICommand _CmdM = new RoutedUICommand();

        public static RoutedUICommand _Cmd0 = new RoutedUICommand();
        public static RoutedUICommand _Cmd1 = new RoutedUICommand();
        public static RoutedUICommand _Cmd2 = new RoutedUICommand();
        public static RoutedUICommand _Cmd3 = new RoutedUICommand();
        public static RoutedUICommand _Cmd4 = new RoutedUICommand();
        public static RoutedUICommand _Cmd5 = new RoutedUICommand();
        public static RoutedUICommand _Cmd6 = new RoutedUICommand();
        public static RoutedUICommand _Cmd7 = new RoutedUICommand();
        public static RoutedUICommand _Cmd8 = new RoutedUICommand();
        public static RoutedUICommand _Cmd9 = new RoutedUICommand();
        public static RoutedUICommand _CmdShortLine = new RoutedUICommand();
        public static RoutedUICommand _CmdPoint = new RoutedUICommand();

        public static RoutedUICommand _CmdBackSpace = new RoutedUICommand();
        public static RoutedUICommand _CmdEnter = new RoutedUICommand();
        public static RoutedUICommand _CmdSemicolon = new RoutedUICommand();
        public static RoutedUICommand _CmdComma = new RoutedUICommand();
        public static RoutedUICommand _CmdSpace = new RoutedUICommand();
        public static RoutedUICommand _CmdCapsLock = new RoutedUICommand();
        public static RoutedUICommand _CmdSharp = new RoutedUICommand();
        public static RoutedUICommand _CmdPersent = new RoutedUICommand();
        public static RoutedUICommand _CmdLeftBracket = new RoutedUICommand();
        public static RoutedUICommand _CmdRightBracket = new RoutedUICommand();

        public static RoutedUICommand _CmdPageUp = new RoutedUICommand();
        public static RoutedUICommand _CmdPageDown = new RoutedUICommand();
        public static RoutedUICommand _CmdUp = new RoutedUICommand();
        public static RoutedUICommand _CmdDown = new RoutedUICommand();
        public static RoutedUICommand _CmdLeft = new RoutedUICommand();
        public static RoutedUICommand _CmdRight = new RoutedUICommand();



        #endregion

        #region 附加属性
        public static bool GetTouchKeyBoard(DependencyObject obj)
        {
            return (bool)obj.GetValue(TouchKeyBoardProperty);
        }

        public static void SetTouchKeyBoard(DependencyObject obj, bool value)
        {
            obj.SetValue(TouchKeyBoardProperty, value);
        }

        public static readonly DependencyProperty TouchKeyBoardProperty =
            DependencyProperty.RegisterAttached("TouchKeyBoard", typeof(bool), typeof(LoginKeyBoard), new UIPropertyMetadata(default(bool), TouchKeyBoardPropertyChanged));

        #endregion

        public LoginKeyBoard()
        {
            InitializeComponent();
            CommandBinding CbQ = new CommandBinding(_CmdQ, RunCommand_Q);
            CommandBinding CbW = new CommandBinding(_CmdW, RunCommand_W);
            CommandBinding CbE = new CommandBinding(_CmdE, RunCommand_E);
            CommandBinding CbR = new CommandBinding(_CmdR, RunCommand_R);
            CommandBinding CbT = new CommandBinding(_CmdT, RunCommand_T);
            CommandBinding CbY = new CommandBinding(_CmdY, RunCommand_Y);
            CommandBinding CbU = new CommandBinding(_CmdU, RunCommand_U);
            CommandBinding CbI = new CommandBinding(_CmdI, RunCommand_I);
            CommandBinding CbO = new CommandBinding(_CmdO, RunCommand_O);
            CommandBinding CbP = new CommandBinding(_CmdP, RunCommand_P);

            CommandBinding CbA = new CommandBinding(_CmdA, RunCommand_A);
            CommandBinding CbS = new CommandBinding(_CmdS, RunCommand_S);
            CommandBinding CbD = new CommandBinding(_CmdD, RunCommand_D);
            CommandBinding CbF = new CommandBinding(_CmdF, RunCommand_F);
            CommandBinding CbG = new CommandBinding(_CmdG, RunCommand_G);
            CommandBinding CbH = new CommandBinding(_CmdH, RunCommand_H);
            CommandBinding CbJ = new CommandBinding(_CmdJ, RunCommand_J);
            CommandBinding CbK = new CommandBinding(_CmdK, RunCommand_K);
            CommandBinding CbL = new CommandBinding(_CmdL, RunCommand_L);

            CommandBinding CbZ = new CommandBinding(_CmdZ, RunCommand_Z);
            CommandBinding CbX = new CommandBinding(_CmdX, RunCommand_X);
            CommandBinding CbC = new CommandBinding(_CmdC, RunCommand_C);
            CommandBinding CbV = new CommandBinding(_CmdV, RunCommand_V);
            CommandBinding CbB = new CommandBinding(_CmdB, RunCommand_B);
            CommandBinding CbN = new CommandBinding(_CmdN, RunCommand_N);
            CommandBinding CbM = new CommandBinding(_CmdM, RunCommand_M);

            CommandBinding Cb0 = new CommandBinding(_Cmd0, RunCommand_0);
            CommandBinding Cb1 = new CommandBinding(_Cmd1, RunCommand_1);
            CommandBinding Cb2 = new CommandBinding(_Cmd2, RunCommand_2);
            CommandBinding Cb3 = new CommandBinding(_Cmd3, RunCommand_3);
            CommandBinding Cb4 = new CommandBinding(_Cmd4, RunCommand_4);
            CommandBinding Cb5 = new CommandBinding(_Cmd5, RunCommand_5);
            CommandBinding Cb6 = new CommandBinding(_Cmd6, RunCommand_6);
            CommandBinding Cb7 = new CommandBinding(_Cmd7, RunCommand_7);
            CommandBinding Cb8 = new CommandBinding(_Cmd8, RunCommand_8);
            CommandBinding Cb9 = new CommandBinding(_Cmd9, RunCommand_9);

            CommandBinding CbShortLine = new CommandBinding(_CmdShortLine, RunCommand_ShortLine);
            CommandBinding CbPoint = new CommandBinding(_CmdPoint, RunCommand_Point);
            CommandBinding CbBackSpace = new CommandBinding(_CmdBackSpace, RunCommand_BackSpace);
            CommandBinding CbEnter = new CommandBinding(_CmdEnter, RunCommand_Enter);
            CommandBinding CbSemicolon = new CommandBinding(_CmdSemicolon, RunCommand_Semicolon);
            CommandBinding CbComma = new CommandBinding(_CmdComma, RunCommand_Comma);
            CommandBinding CbSpace = new CommandBinding(_CmdSpace, RunCommand_Space);
            CommandBinding CbCapsLock = new CommandBinding(_CmdCapsLock, RunCommand_CapsLock);
            CommandBinding CbSharp = new CommandBinding(_CmdSharp, RunCommand_Sharp);
            CommandBinding CbPersent = new CommandBinding(_CmdPersent, RunCommand_Persent);
            CommandBinding CbLeftBracket = new CommandBinding(_CmdLeftBracket, RunCommand_LeftBracket);
            CommandBinding CbRightBracket = new CommandBinding(_CmdRightBracket, RunCommand_RightBracket);
            CommandBinding CbPageUp = new CommandBinding(_CmdPageUp, RunCommand_PageUp);
            CommandBinding CbPageDown = new CommandBinding(_CmdPageDown, RunCommand_PageDown);
            CommandBinding CbUp = new CommandBinding(_CmdUp, RunCommand_Up);
            CommandBinding CbDown = new CommandBinding(_CmdDown, RunCommand_Down);
            CommandBinding CbLeft = new CommandBinding(_CmdLeft, RunCommand_Left);
            CommandBinding CbRight = new CommandBinding(_CmdRight, RunCommand_Right);

            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbQ);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbW);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbE);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbR);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbT);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbY);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbU);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbI);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbO);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbP);

            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbA);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbS);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbD);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbF);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbG);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbH);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbJ);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbK);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbL);

            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbZ);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbX);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbC);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbV);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbB);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbN);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbM);

            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), Cb0);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), Cb1);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), Cb2);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), Cb3);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), Cb4);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), Cb5);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), Cb6);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), Cb7);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), Cb8);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), Cb9);

            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbShortLine);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbPoint);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbBackSpace);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbEnter);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbSemicolon);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbComma);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbSpace);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbCapsLock);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbSharp);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbPersent);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbLeftBracket);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbRightBracket);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbPageUp);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbPageDown);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbUp);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbDown);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbLeft);
            CommandManager.RegisterClassCommandBinding(typeof(LoginKeyBoard), CbRight);


            CapsLockFlag = Keyboard.GetCapsLockStatus();
        }

        static void TouchKeyBoardPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (bool.Parse(e.NewValue.ToString()))
            {
                FrameworkElement host = sender as FrameworkElement;
                if (host != null)
                {
                    host.GotFocus += new RoutedEventHandler(OnGotFocus);
                    //host.LostFocus += new RoutedEventHandler(OnLostFocus);
                }
            }
            else
            {
                FrameworkElement host = sender as FrameworkElement;
                if (host != null)
                {
                    host.GotFocus -= new RoutedEventHandler(OnGotFocus);
                    //host.LostFocus -= new RoutedEventHandler(OnLostFocus);
                }
            }

        }

        static void OnGotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Control host = sender as System.Windows.Controls.Control;

            //_PreviousTextBoxBackgroundBrush = host.Background;
            //_PreviousTextBoxBorderBrush = host.BorderBrush;
            //_PreviousTextBoxBorderThickness = host.BorderThickness;

            //host.Background = Brushes.Yellow;
            //host.BorderBrush = Brushes.Red;
            //host.BorderThickness = new Thickness(1);


            _CurrentControl = host;

            if (_InstanceObject == null)
            {
                _InstanceObject = new LoginKeyBoard();
            }
        }

        #region Q~P
        static void RunCommand_Q(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.Q);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_W(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.W);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_E(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.E);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_R(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.R);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_T(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.T);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_Y(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.Y);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_U(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.U);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_I(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.I);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_O(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.O);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_P(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.P);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        #endregion

        #region A~L
        static void RunCommand_A(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.A);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_S(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.S);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_D(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.D);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_F(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.F);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_G(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.G);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_H(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.H);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_J(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.J);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_K(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.K);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_L(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.L);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        #endregion

        #region Z~M
        static void RunCommand_Z(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.Z);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_X(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.X);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_C(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;

            Keyboard.Type(Key.C);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_V(object sender, ExecutedRoutedEventArgs e)
        {

            if (_CurrentControl == null) return;
            Keyboard.Type(Key.V);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_B(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.B);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_N(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.N);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        static void RunCommand_M(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.M);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        #endregion

        #region 0~9
        static void RunCommand_0(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.D0);
            _CurrentControl.Focus();
        }

        static void RunCommand_1(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.D1);
            _CurrentControl.Focus();
        }

        static void RunCommand_2(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.D2);
            _CurrentControl.Focus();
        }

        static void RunCommand_3(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.D3);
            _CurrentControl.Focus();
        }

        static void RunCommand_4(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.D4);
            _CurrentControl.Focus();
        }

        static void RunCommand_5(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.D5);
            _CurrentControl.Focus();
        }

        static void RunCommand_6(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.D6);
            _CurrentControl.Focus();
        }

        static void RunCommand_7(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.D7);
            _CurrentControl.Focus();
        }

        static void RunCommand_8(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.D8);
            _CurrentControl.Focus();
        }

        static void RunCommand_9(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.D9);
            _CurrentControl.Focus();
        }

        #endregion

        #region ctrl btn
        private void RunCommand_ShortLine(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.Subtract);
            _CurrentControl.Focus();
        }

        private void RunCommand_Point(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.Decimal);
            _CurrentControl.Focus();
        }

        private void RunCommand_BackSpace(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.Back);
            _CurrentControl.Focus();
        }


        private void RunCommand_Enter(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.Enter);
            _CurrentControl.Focus();
        }


        private void RunCommand_Semicolon(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            //Keyboard.Press(Key.LeftShift);
            Keyboard.Type(Key.OemSemicolon);
            _CurrentControl.Focus();
        }

        private void RunCommand_Comma(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            //Keyboard.Press(Key.LeftShift);
            Keyboard.Type(Key.OemComma);
            _CurrentControl.Focus();
        }

        private void RunCommand_Space(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.Space);
            _CurrentControl.Focus();
        }

        private void RunCommand_CapsLock(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.CapsLock);
            _CurrentControl.Focus();

            CapsLockFlag = Keyboard.GetCapsLockStatus();
        }

        private void RunCommand_Sharp(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Press(Key.LeftShift);
            Keyboard.Type(Key.D3);
            Keyboard.Release(Key.LeftShift);
            _CurrentControl.Focus();
        }

        private void RunCommand_Persent(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Press(Key.LeftShift);
            Keyboard.Type(Key.D5);
            Keyboard.Release(Key.LeftShift);
            _CurrentControl.Focus();
        }

        private void RunCommand_LeftBracket(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Press(Key.LeftShift);
            Keyboard.Type(Key.D9);
            Keyboard.Release(Key.LeftShift);
            _CurrentControl.Focus();
        }

        private void RunCommand_RightBracket(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Press(Key.LeftShift);
            Keyboard.Type(Key.D0);
            Keyboard.Release(Key.LeftShift);
            _CurrentControl.Focus();
        }

        private void RunCommand_PageUp(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.PageUp);
            _CurrentControl.Focus();
        }

        private void RunCommand_PageDown(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.PageDown);
            _CurrentControl.Focus();
        }

        private void RunCommand_Up(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.Up);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        private void RunCommand_Down(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.Down);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        private void RunCommand_Left(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.Left);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        private void RunCommand_Right(object sender, ExecutedRoutedEventArgs e)
        {
            if (_CurrentControl == null) return;
            Keyboard.Type(Key.Right);
            //Keyboard.Press(Key.LeftShift);
            _CurrentControl.Focus();
        }

        #endregion

    }
}
