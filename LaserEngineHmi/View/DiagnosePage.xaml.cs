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
using Abt.Controls.SciChart.Model.DataSeries;
using Abt.Controls.SciChart.Visuals.Axes;
using LaserEngineHmi.ViewModel;

namespace LaserEngineHmi.View
{
    /// <summary>
    /// DiagnosePage.xaml 的交互逻辑
    /// </summary>
    public partial class DiagnosePage : Page
    {
        private IXyDataSeries<double, double> series = new XyDataSeries<double, double>();

        double index;
        private int FifoSize = 60;

        public DiagnosePage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<DiagnoseViewModel>();
            //InitialSciChart();

            //Messenger.Default.Register<double>(this, "RealOutputPower_Data", OnRealOutputPower_Data);
            //Messenger.Default.Register<string>(this, "RealOutputPower_Control", OnRealOutputPower_Control);
        }

        private void OnRealOutputPower_Data(double data)
        {

            //try
            //{
            //    DispatcherHelper.CheckBeginInvokeOnUI(() =>
            //    {
            //        using (plotter1.SuspendUpdates())
            //        {
            //            series.Append(index, data);
            //        }
            //    });
            //}
            //catch (Exception ex)
            //{
            //}

            //index++;
        }

        private void OnRealOutputPower_Control(string msg)
        {
            //InitialSciChart();
        }

        //private void InitialSciChart()
        //{
        //    DispatcherHelper.CheckBeginInvokeOnUI(() =>
        //    {
        //        using (plotter1.SuspendUpdates())
        //        {
        //            series.Clear();
        //            series.FifoCapacity = FifoSize;
        //            plotter1_series.DataSeries = series;

        //        }
        //    });

        //    index = 0;

            
        //}
        
    }
}
