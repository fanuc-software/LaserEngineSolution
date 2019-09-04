using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using AutoMapper;
using FanucCnc;
using LaserEngineHmi.Model;
using ConfigCenter;
using DataCenter.Services;
using DataCenter.Enum;
using UserCenter;
using System.Diagnostics;
using System.IO;

namespace LaserEngineHmi.ViewModel
{
    public class SoftwareOffsetViewModel : ViewModelBase
    {
        private LibInfoService _LiSrv;
        private MachiningLibService _maclibSrv;
        private User _user;

        #region command
        public ICommand EnglishCommand { get; set; }
        public ICommand ChineseCommand { get; set; }
        public ICommand UpdataLibCommand { get; set; }

        public ICommand ChangeLibToBootCommand { get; set; }

        public ICommand ChangeLibToUserCommand { get; set; }

        public ICommand InitialUserLibCommand { get; set; }

        public ICommand Phb02bRestartCommand { get; set; }

        #endregion

        #region 属性
        private string m_RootLibOperate;
        public string RootLibOperate
        {
            get { return m_RootLibOperate; }
            set
            {
                if (m_RootLibOperate != value)
                {
                    m_RootLibOperate = value;
                    RaisePropertyChanged(() => RootLibOperate);
                }
            }
        }

        private bool m_LanguageChineseButtonStatus;
        public bool LanguageChineseButtonStatus
        {
            get { return m_LanguageChineseButtonStatus; }
            set
            {
                if (m_LanguageChineseButtonStatus != value)
                {
                    m_LanguageChineseButtonStatus = value;
                    RaisePropertyChanged(() => LanguageChineseButtonStatus);
                }
            }
        }

        private bool m_LanguageEnglishButtonStatus;
        public bool LanguageEnglishButtonStatus
        {
            get { return m_LanguageEnglishButtonStatus; }
            set
            {
                if (m_LanguageEnglishButtonStatus != value)
                {
                    m_LanguageEnglishButtonStatus = value;
                    RaisePropertyChanged(() => LanguageEnglishButtonStatus);
                }
            }
        }

        private string m_LibInfo;
        public string LibInfo
        {
            get { return m_LibInfo; }
            set
            {
                if (m_LibInfo != value)
                {
                    m_LibInfo = value;
                    RaisePropertyChanged(() => LibInfo);
                }
            }
        }

        private string m_SoftwareInfo;
        public string SoftwareInfo
        {
            get { return m_SoftwareInfo; }
            set
            {
                if (m_SoftwareInfo != value)
                {
                    m_SoftwareInfo = value;
                    RaisePropertyChanged(() => SoftwareInfo);
                }
            }
        }
        

        private string m_LibUpdataPath;
        public string LibUpdataPath
        {
            get { return m_LibUpdataPath; }
            set
            {
                if (m_LibUpdataPath != value)
                {
                    m_LibUpdataPath = value;
                    RaisePropertyChanged(() => LibUpdataPath);
                }
            }
        }

        
        #endregion

        #region ctor
        public SoftwareOffsetViewModel(IMapper mapper, Fanuc fanuc, LibInfoService liSrv, User user, MachiningLibService maclibSrv)
        {

            this._LiSrv = liSrv;
            this._user = user;
            this._maclibSrv = maclibSrv;

            EnglishCommand = new RelayCommand(ONEnglishCommand);
            ChineseCommand = new RelayCommand(ONChineseCommand);
            UpdataLibCommand = new RelayCommand(ONUpdataLib);
            ChangeLibToBootCommand = new RelayCommand(ONChangeLibToBoot);
            ChangeLibToUserCommand = new RelayCommand(ONChangeLibToUser);
            InitialUserLibCommand = new RelayCommand(ONInitialUserLib);
            Phb02bRestartCommand = new RelayCommand(ONPhb02bRestart);

            Messenger.Default.Register<string>(this, "SetLibPathMsg", msg =>
            {

                System.Windows.Forms.OpenFileDialog file = new System.Windows.Forms.OpenFileDialog();
                if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK || file.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                {
                    LibUpdataPath = System.IO.Path.GetFullPath(file.FileName);
                }
            });

            Messenger.Default.Register<string>(this, "RootLibOperateMsg", msg =>
            {
                RootLibOperate = msg;
            });
            _user.GetUserLibRootRoles();

            var config = new ConfigHelper();
            string lang;
            config.GetLanguage(out lang);

            if (lang == "en-us.xaml")
            {
                LanguageEnglishButtonStatus = true;
                LanguageChineseButtonStatus = false;
            }
            else
            {
                LanguageEnglishButtonStatus = false;
                LanguageChineseButtonStatus = true;
            }
            
            config.GetSoftwareInfo(out m_SoftwareInfo);

            LibInfo = _LiSrv.GetCurrentLibInfo();


        }

        #endregion

        private void ONPhb02bRestart()
        {
            try
            {
                var info = new ProcessStartInfo();
                info.FileName = "cmd";
                info.Arguments = "cmd /c " + "Net Stop PHB02BService";
                info.UseShellExecute = true;
                info.CreateNoWindow = true;
                info.WindowStyle = ProcessWindowStyle.Hidden;
                info.Verb = "runas";

                var process = new Process();
                process.StartInfo = info;

                process.Start();
                process.WaitForExit();
            }
            catch
            {
                Messenger.Default.Send<string>("重启服务失败，请检查权限", "OperateNotice");
            }

            System.Threading.Thread.Sleep(1000);

            try{
                var info = new ProcessStartInfo();
                info.FileName = "cmd";
                info.Arguments = "cmd /c " + "Net Start PHB02BService \nsc config PHB02BService start= auto";
                info.UseShellExecute = true;
                info.CreateNoWindow = true;
                info.WindowStyle = ProcessWindowStyle.Hidden;
                info.Verb = "runas";

                var process = new Process();
                process.StartInfo = info;

                process.Start();
                process.WaitForExit();
            }
            catch
            {
                Messenger.Default.Send<string>("重启服务失败，请检查权限", "OperateNotice");
            }
        }

        private void ONChangeLibToBoot()
        {
            _LiSrv.SetDataCenterEnum(DataCenterEnum.Boot);
            _maclibSrv.SetDataCenterEnum(DataCenterEnum.Boot);
        }

        private void ONChangeLibToUser()
        {
            _LiSrv.SetDataCenterEnum(DataCenterEnum.User);
            _maclibSrv.SetDataCenterEnum(DataCenterEnum.User);
        }

        private void ONInitialUserLib()
        {

        }

        private void ONEnglishCommand()
        {
            List<ResourceDictionary> dictionaryList = new List<ResourceDictionary>();
            foreach (ResourceDictionary dictionary in Application.Current.Resources.MergedDictionaries)
            {
                dictionaryList.Add(dictionary);
            }

            var requestedCulture_msg = @"pack://application:,,,/LaserEngineHmi;component/Resources/en-us.xaml";
            var resourceDictionary = dictionaryList.FirstOrDefault(d => d.Source.OriginalString.Equals(requestedCulture_msg));
            Application.Current.Resources.MergedDictionaries.Remove(resourceDictionary);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);

            LanguageEnglishButtonStatus = true;
            LanguageChineseButtonStatus = false;

            var config = new ConfigHelper();
            config.SetLanguage("en-us.xaml");
            

        }

        private void ONChineseCommand()
        {
            List<ResourceDictionary> dictionaryList = new List<ResourceDictionary>();
            foreach (ResourceDictionary dictionary in Application.Current.Resources.MergedDictionaries)
            {
                dictionaryList.Add(dictionary);
            }

            var requestedCulture_msg = @"pack://application:,,,/LaserEngineHmi;component/Resources/zh-cn.xaml";
            var resourceDictionary = dictionaryList.FirstOrDefault(d => d.Source.OriginalString.Equals(requestedCulture_msg));
            Application.Current.Resources.MergedDictionaries.Remove(resourceDictionary);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);

            LanguageEnglishButtonStatus = false;
            LanguageChineseButtonStatus = true;

            var config = new ConfigHelper();
            config.SetLanguage("zh-cn.xaml");
        }

        private void ONUpdataLib()
        {
            var name = System.IO.Path.GetFileName(LibUpdataPath);
            if(name!= "LaserEngineDB.db")
            {
                Messenger.Default.Send<string>("升级数据库失败，数据库文件错误", "OperateNotice");
                return;
            }

            try
            {
                System.IO.File.Copy(LibUpdataPath, @"C:\ProgramData\BFM\LaserEngineDB.db");
            }
            catch
            {
                Messenger.Default.Send<string>("升级数据库失败，请检查权限", "OperateNotice");
            }
        }
        
    }
}
