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
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Ioc;
using LaserEngineHmi.ViewModel;
using LaserEngineHmi.App_Start;
using FanucCnc;


namespace LaserEngineHmi.View
{
    /// <summary>
    /// LoadingWaitWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoadingWaitWindow : Window
    {
        public LoadingWaitWindow()
        {
            InitializeComponent();

            IocConfig.Register();
            DispatcherHelper.Initialize();

            this.DataContext = SimpleIoc.Default.GetInstance<LoadingWaitViewModel>();

            Messenger.Default.Register<bool>(this, "LoadingFinishMsg", msg =>
            {

                if (msg == true)
                {
                    //DispatcherHelper.CheckBeginInvokeOnUI(() =>
                    ////{
                    //    var main = new MainWindow2();
                    //    main.ShowDialog();
                    //});
                }
                else
                {
                    //DispatcherHelper.CheckBeginInvokeOnUI(() =>
                    //{
                        //this.Close();
                    //});
                }
                this.Close();

            });
        }
    }
}
