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
using LaserEngineHmi.ViewModel;
using ConfigCenter;


namespace LaserEngineHmi.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<ResourceDictionary> dictionaryList = new List<ResourceDictionary>();

        public MainWindow()
        {
            InitializeComponent();

            //加载语言 默认中文
            foreach (ResourceDictionary dictionary in Application.Current.Resources.MergedDictionaries)
            {
                dictionaryList.Add(dictionary);
            }

            var config = new ConfigHelper();
            string lang;
            config.GetLanguage(out lang);
            var requestedCulture = @"pack://application:,,,/LaserEngineHmi;component/Resources/"+ lang;

            ResourceDictionary resourceDictionary = dictionaryList.FirstOrDefault(d => d.Source.OriginalString.Equals(requestedCulture));
            Application.Current.Resources.MergedDictionaries.Remove(resourceDictionary);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);


            //this.DataContext = new MainViewModel();
        }
    }
}
