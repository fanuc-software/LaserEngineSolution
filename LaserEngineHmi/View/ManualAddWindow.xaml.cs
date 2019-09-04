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
using GalaSoft.MvvmLight.Ioc;
using LaserEngineHmi.ViewModel;

namespace LaserEngineHmi.View
{
    /// <summary>
    /// ManualAddWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ManualAddWindow : Window
    {
        public ManualAddWindow()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<ManualAddViewModel>();

            Messenger.Default.Register<bool>(this, "ManualAddQuitMsg", msg =>
            {
                this.Close();
            });
        }

        private void FilePath_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("", "SetManualFilePathMsg");
        }
    }
}
