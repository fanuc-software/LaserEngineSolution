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
    /// MOP2.xaml 的交互逻辑
    /// </summary>
    public partial class MOP2 : UserControl
    {
        public MOP2()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<MOPViewModel>();

            XplusBtn.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(XplusBtn_MouseDown), true);
            XplusBtn.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(XplusBtn_MouseUp), true);
            YplusBtn.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(YplusBtn_MouseDown), true);
            YplusBtn.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(YplusBtn_MouseUp), true);
            ZplusBtn.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(ZplusBtn_MouseDown), true);
            ZplusBtn.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(ZplusBtn_MouseUp), true);
            XminusBtn.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(XminusBtn_MouseDown), true);
            XminusBtn.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(XminusBtn_MouseUp), true);
            YminusBtn.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(YminusBtn_MouseDown), true);
            YminusBtn.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(YminusBtn_MouseUp), true);
            ZminusBtn.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(ZminusBtn_MouseDown), true);
            ZminusBtn.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(ZminusBtn_MouseUp), true);
        }



        private void XplusBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Messenger.Default.Send<string>("CLICK", "XplusMSG");
        }
        private void XplusBtn_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Messenger.Default.Send<string>("UNCLICK", "XplusMSG");
        }

        private void YplusBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Messenger.Default.Send<string>("CLICK", "YplusMSG");
        }
        private void YplusBtn_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Messenger.Default.Send<string>("UNCLICK", "YplusMSG");
        }

        private void ZplusBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Messenger.Default.Send<string>("CLICK", "ZplusMSG");
        }
        private void ZplusBtn_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Messenger.Default.Send<string>("UNCLICK", "ZplusMSG");
        }

        private void XminusBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Messenger.Default.Send<string>("CLICK", "XminusMSG");
        }
        private void XminusBtn_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Messenger.Default.Send<string>("UNCLICK", "XminusMSG");
        }

        private void YminusBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Messenger.Default.Send<string>("CLICK", "YminusMSG");
        }
        private void YminusBtn_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Messenger.Default.Send<string>("UNCLICK", "YminusMSG");
        }
        private void ZminusBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Messenger.Default.Send<string>("CLICK", "ZminusMSG");
        }
        private void ZminusBtn_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Messenger.Default.Send<string>("UNCLICK", "ZminusMSG");
        }

    }
}
