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
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using LaserEngineHmi.ViewModel;

namespace LaserEngineHmi.View
{
    /// <summary>
    /// CutCenterPage.xaml 的交互逻辑
    /// </summary>
    public partial class CutCenterPage : Page
    {
        public CutCenterPage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<CutCenterViewModel>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string>("START", "CutterCenterStartMSG");
        }
    }
}
