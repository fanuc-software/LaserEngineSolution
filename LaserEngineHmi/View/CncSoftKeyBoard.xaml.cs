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
using GalaSoft.MvvmLight.Messaging;

namespace LaserEngineHmi.View
{
    /// <summary>
    /// CncSoftKeyBoard.xaml 的交互逻辑
    /// </summary>
    public partial class CncSoftKeyBoard : Window
    {

        private static CncSoftKeyBoard _instance = null;

        public CncSoftKeyBoard()
        {
            InitializeComponent();
        }

        public static CncSoftKeyBoard CreateInstance()
        {
            if (_instance == null)

            {
                _instance = new CncSoftKeyBoard();
            }
            return _instance;
        }

        private void F1_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("F1", "CsdSoftKeyMsg");
        }
        private void F2_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("F2", "CsdSoftKeyMsg");
        }
        private void F3_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("F3", "CsdSoftKeyMsg");
        }
        private void F4_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("F4", "CsdSoftKeyMsg");
        }
        private void F5_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("F5", "CsdSoftKeyMsg");
        }
        private void F6_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("F6", "CsdSoftKeyMsg");
        }
        private void F7_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("F7", "CsdSoftKeyMsg");
        }
        private void F8_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("F8", "CsdSoftKeyMsg");
        }
        private void F9_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("F9", "CsdSoftKeyMsg");
        }
        private void F10_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("F10", "CsdSoftKeyMsg");
        }
        private void FL_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("FL", "CsdSoftKeyMsg");
        }
        private void FR_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("FR", "CsdSoftKeyMsg");
        }
    }
}
