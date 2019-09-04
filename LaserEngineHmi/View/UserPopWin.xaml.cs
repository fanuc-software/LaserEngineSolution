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
using System.Windows.Shapes;
using GalaSoft.MvvmLight.Ioc;
using LaserEngineHmi.ViewModel;
using GalaSoft.MvvmLight.Messaging;

namespace LaserEngineHmi.View
{
    /// <summary>
    /// UserPopWin.xaml 的交互逻辑
    /// </summary>
    public partial class UserPopWin : Window
    {
        public UserPopWin()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<UserPopViewModel>();
            
        }

        private void Button_Click_Reload(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("", "ReloadMsg");

            this.Close();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
