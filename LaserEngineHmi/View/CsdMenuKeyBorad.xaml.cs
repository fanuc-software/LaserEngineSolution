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
    /// CsdMenuKeyBorad.xaml 的交互逻辑
    /// </summary>
    public partial class CsdMenuKeyBorad : Window
    {
        private static CsdMenuKeyBorad _instance = null;

        public CsdMenuKeyBorad()
        {
            InitializeComponent();
        }

        public static CsdMenuKeyBorad CreateInstance()
        {
            if (_instance == null)

            {
                _instance = new CsdMenuKeyBorad();
            }
            return _instance;
        }

        private void POS_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("POS", "CsdKeyMsg");
        }

        private void PRG_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("PRG", "CsdKeyMsg");
        }

        private void OFS_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("OFS", "CsdKeyMsg");
        }

        private void SYS_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("SYS", "CsdKeyMsg");
        }

        private void MSG_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("MSG", "CsdKeyMsg");
        }

        private void GRA_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("GRA", "CsdKeyMsg");
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
