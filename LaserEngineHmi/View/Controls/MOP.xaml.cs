using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Ioc;
using LaserEngineHmi.Enum;

namespace LaserEngineHmi.View.Controls
{
    /// <summary>
    /// MOP.xaml 的交互逻辑
    /// </summary>
    public partial class MOP : UserControl
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        //#region COMMAND
        //public static RoutedUICommand _CmdToQWERT = new RoutedUICommand();

        //#endregion

        #region ctrl
        public MOP()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<MOPViewModel>();
            //CommandBinding CbToQWERT = new CommandBinding(_CmdToQWERT, RunCommand_TOQWERT);

            //CommandManager.RegisterClassCommandBinding(typeof(MOP), CbToQWERT);
        }

        #endregion

        //static void RunCommand_TOQWERT(object sender, ExecutedRoutedEventArgs e)
        //{
        //    Messenger.Default.Send<KeyBoardVisibleEnum>(KeyBoardVisibleEnum.QWERT, "ChangeKeyBoardMsg");
        //}
    }
}
