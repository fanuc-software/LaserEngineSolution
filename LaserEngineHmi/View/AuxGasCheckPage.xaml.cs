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
    /// AuxGasCheckPage.xaml 的交互逻辑
    /// </summary>
    public partial class AuxGasCheckPage : Page
    {
        public AuxGasCheckPage()
        {
            InitializeComponent();

            this.DataContext = SimpleIoc.Default.GetInstance<AuxGasCheckViewModel>();

            gasBtn.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(gasBtn_MouseDown), true);
            gasBtn.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(gasBtn_MouseUp), true);
        }

        private void gasBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Messenger.Default.Send<string>("CLICK", "GasBtnMSG");
        }
        private void gasBtn_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Messenger.Default.Send<string>("UNCLICK", "GasBtnMSG");
        }
    }
}
