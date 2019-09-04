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
using GalaSoft.MvvmLight.Messaging;
using DataCenter.Model;
using LaserEngineHmi.ViewModel;

namespace LaserEngineHmi.View
{
    /// <summary>
    /// MachiningSlopeControlEditDiaglog.xaml 的交互逻辑
    /// </summary>
    public partial class MachiningSlopeControlEditDiaglog : Window
    {
        public MachiningSlopeControlEditDiaglog(MachiningLib_SlopeControlDto data)
        {
            InitializeComponent();
            this.DataContext = new MachiningSlopeControlEditDiaglogViewModel(data);

            Messenger.Default.Register<string>(this, "MachiningSlopeControlEditDiaglogClose", msg =>
            {
                this.Close();
            });
        }
    }


}
