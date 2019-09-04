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
    /// MainWindow2.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public MainWindow2()
        {
            IocConfig.Register();
            DispatcherHelper.Initialize();

            //启动csd bitmap服务
            //TODO:NO CNC
            
            //加载语言 默认中文
            List<ResourceDictionary> dictionaryList = new List<ResourceDictionary>();
            foreach (ResourceDictionary dictionary in Application.Current.Resources.MergedDictionaries)
            {
                dictionaryList.Add(dictionary);
            }
            string requestedCulture = @"pack://application:,,,/LaserEngineHmi;component/Resources/zh-cn.xaml";
            ResourceDictionary resourceDictionary = dictionaryList.FirstOrDefault(d => d.Source.OriginalString.Equals(requestedCulture));
            Application.Current.Resources.MergedDictionaries.Remove(resourceDictionary);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);

            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<MainViewModel>();
            
            //Messenger.Default.Register<CncStateInfo>(this, "CncStateMsg", msg =>
            //{
            //    DispatcherHelper.CheckBeginInvokeOnUI(() =>
            //    {
            //        alarmBox.Document.Blocks.Clear();
            //        alarmBox.AppendText(msg.CncAlarm);
            //    });

            //     var al_timespan = (DateTime.Now - _lastAlarmUpdataTime).TotalSeconds;
            //    if (al_timespan > 3)
            //    {
            //        if (CncStateInfoDto.Alarms.Count == 0)
            //        {
            //            _DisAlarm = "";

            //        }
            //        else
            //        {
            //            string[] alm_type = { "SW", "PW", "IO", "PS", "OT", "OH", "SV", "SR", "MC", "SP", "DS", "IE", "BG", "SN", "", "EX", "", "", "", "PC" };
            //            string[] alm_axis = { "", "(X)", "(Y)", "(Z)" };
            //            if (_curAlarmIndex >= CncStateInfoDto.Alarms.Count) _curAlarmIndex = 0;
            //            _DisAlarm = alm_type[CncStateInfoDto.Alarms[_curAlarmIndex].Type] +
            //                    CncStateInfoDto.Alarms[_curAlarmIndex].Alm_No.ToString("0000") +
            //                    @" " + CncStateInfoDto.Alarms[_curAlarmIndex].Alm_Msg +
            //                    @" " + alm_axis[CncStateInfoDto.Alarms[_curAlarmIndex].Axis];
            //            _curAlarmIndex++;
            //        }

            //        _lastAlarmUpdataTime = DateTime.Now;


            //    }

            //});

            Messenger.Default.Register<GenericMessage<string>>(this, "SoftwareQuitMsg", msg =>
            {
                this.Close();
            });

            Messenger.Default.Register<GenericMessage<string>>(this, "SoftwareMiniMsg", msg =>
            {
                this.WindowState=WindowState.Minimized;
            });

            Messenger.Default.Register<GenericMessage<string>>(this, "SoftwareMaxMsg", msg =>
            {
                this.WindowState = WindowState.Maximized;
            });

            //alarmBox.AppendText("这是一个报警*******************\r这又是一个**********************");
        }

        private void UI_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            //UIElement ui;
            //Point pt = ui.PointToScreen(Mouse.GetPosition(ui));

            UserPopWin userPop = new UserPopWin() { };
            userPop.ShowDialog();
        }
    }
}
