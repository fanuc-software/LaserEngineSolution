using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.InteropServices;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using LaserEngineHmi.ViewModel;
using FanucCnc;
using LaserEngineHmi.Hook;

namespace LaserEngineHmi.View
{
    /// <summary>
    /// HomePage.xaml 的交互逻辑
    /// </summary>
    public partial class HomePage : Page
    {
        
        private System.Timers.Timer timerN = new System.Timers.Timer();//刷新操作信息

        public HomePage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<HomeViewModel>();
            
            IntPtr hwnd;
            hwnd = myPanel.Handle;
            var csd = CncScreenDisplay.CreateInstance();
            csd.CreateCncScreenDisplay(hwnd);

            //timerN.Interval = System.Convert.ToDouble(1000);
            //timerN.Elapsed += new System.Timers.ElapsedEventHandler(RefreshScreen);
            //timerN.Enabled = true;
        }

        private void RefreshScreen(object sender, System.Timers.ElapsedEventArgs e)
        {
            GC.Collect();
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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //TODO:NO CNC
            var csd = CncScreenDisplay.CreateInstance();
            csd.StartRefreshCncScreenDisplay();
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            //TODO:NO CNC
            var csd = CncScreenDisplay.CreateInstance();
            csd.StopRefreshCncScreenDisplay();
        }

        private void WindowsFormsHost_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }
    }
}
