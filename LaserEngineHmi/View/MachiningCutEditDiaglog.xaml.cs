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
    /// MachiningCutEditDiaglog.xaml 的交互逻辑
    /// </summary>
    public partial class MachiningCutEditDiaglog : Window
    {
        public MachiningCutEditDiaglog(MachiningLib_CuttingDto data)
        {
            InitializeComponent();
            this.DataContext = new MachiningCutEditWindowViewModel(data);

            Messenger.Default.Register<string>(this, "MachiningCutEditDiaglogClose", msg =>
            {
                this.Close();
            });
        }
    }
}
