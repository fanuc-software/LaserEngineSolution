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
using GalaSoft.MvvmLight.Ioc;
using LaserEngineHmi.ViewModel;

namespace LaserEngineHmi.View
{
    /// <summary>
    /// MachiningLibCutDataGrid.xaml 的交互逻辑
    /// </summary>
    public partial class MachiningLibCutDataGrid : Page
    {
        public MachiningLibCutDataGrid()
        {
            InitializeComponent();
            //this.DataContext = MachiningLibCutDataGridViewModel.CreateInstance();
            this.DataContext = SimpleIoc.Default.GetInstance<MachiningLibCutDataGridViewModel>();
        }
    }
}
