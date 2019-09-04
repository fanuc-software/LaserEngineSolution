using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using AutoMapper;
using LaserEngineHmi.View;
using LaserEngineHmi.Enum;
using UserCenter;
using FanucCnc;
using LaserEngineHmi.Model;

namespace LaserEngineHmi.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private User _user;
        private Fanuc _fanuc;
        private IMapper _mapper;
        private short _curAlarmIndex;
        private DateTime _lastAlarmUpdataTime;
        private short _curMessageIndex;
        private DateTime _lastMessageUpdataTime;
        private System.Timers.Timer timerN = new System.Timers.Timer();//刷新操作信息
        private System.Timers.Timer timerL = new System.Timers.Timer();

        public const string localScope = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?> " +
                                                            "<haspscope> " +
                                                            "   <license_manager hostname =\"localhost\" /> " +
                                                            "</haspscope>";

        public const string defaultScope = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?> " +
                                                                            "<haspscope/> ";


        public ICommand ReLoadingCommand { get; set; }
        public ICommand ShowAlarmDialogCmd { get; set; }
        public ICommand ShowOpMessageDialogCmd { get; set; }

        #region properties
        private string m_disAlarm;
        public string _DisAlarm
        {
            get { return m_disAlarm; }
            set
            {
                if (m_disAlarm != value)
                {
                    m_disAlarm = value;
                    RaisePropertyChanged(() => _DisAlarm);
                }
            }
        }

        private string m_disMessage;
        public string _DisMessage
        {
            get { return m_disMessage; }
            set
            {
                if (m_disMessage != value)
                {
                    m_disMessage = value;
                    RaisePropertyChanged(() => _DisMessage);
                }
            }
        }

        private string m_disNotice;
        public string _DisNotice
        {
            get { return m_disNotice; }
            set
            {
                if (m_disNotice != value)
                {
                    m_disNotice = value;
                    RaisePropertyChanged(() => _DisNotice);
                }
            }
        }

        private Page m_content;
        public Page _Content
        {
            get { return m_content; }
            set
            {
                if (m_content != value)
                {
                    m_content = value;
                    RaisePropertyChanged(() => _Content);
                }
            }
        }

        private string  m_time;
        public string _Time
        {
            get { return m_time; }
            set
            {
                if (m_time != value)
                {
                    m_time = value;
                    RaisePropertyChanged(() => _Time);
                }
            }
        }

        private string m_LoadVisibility;
        public string _LoadVisibility
        {
            get { return m_LoadVisibility; }
            set
            {
                if (m_LoadVisibility != value)
                {
                    m_LoadVisibility = value;
                    RaisePropertyChanged(() => _LoadVisibility);
                }
            }
        }

        private string m_LoadingMessage;
        public string _LoadingMessage
        {
            get { return m_LoadingMessage; }
            set
            {
                if (m_LoadingMessage != value)
                {
                    m_LoadingMessage = value;
                    RaisePropertyChanged(() => _LoadingMessage);
                }
            }
        }

        private string m_LoadingDotMessage;
        public string _LoadingDotMessage
        {
            get { return m_LoadingDotMessage; }
            set
            {
                if (m_LoadingDotMessage != value)
                {
                    m_LoadingDotMessage = value;
                    RaisePropertyChanged(() => _LoadingDotMessage);
                }
            }
        }

        private string m_ReLoadVisibility;
        public string _ReLoadConnVisibility
        {
            get { return m_ReLoadVisibility; }
            set
            {
                if (m_ReLoadVisibility != value)
                {
                    m_ReLoadVisibility = value;
                    RaisePropertyChanged(() => _ReLoadConnVisibility);
                }
            }
        }
        

        private string m_MopVisibility;
        public string _MopVisibility
        {
            get { return m_MopVisibility; }
            set
            {
                if (m_MopVisibility != value)
                {
                    m_MopVisibility = value;
                    RaisePropertyChanged(() => _MopVisibility);
                }
            }
        }

        private string m_QWERTVisibility;
        public string _QWERTVisibility
        {
            get { return m_QWERTVisibility; }
            set
            {
                if (m_QWERTVisibility != value)
                {
                    m_QWERTVisibility = value;
                    RaisePropertyChanged(() => _QWERTVisibility);
                }
            }
        }

        private string m_SafeNetLimitVisible;
        public string SafeNetLimitVisible
        {
            get { return m_SafeNetLimitVisible; }
            set
            {
                if (m_SafeNetLimitVisible != value)
                {
                    m_SafeNetLimitVisible = value;
                    RaisePropertyChanged(() => SafeNetLimitVisible);
                }
            }
        }

        private string m_SafeNetLimitMessage;
        public string SafeNetLimitMessage
        {
            get { return m_SafeNetLimitMessage; }
            set
            {
                if (m_SafeNetLimitMessage != value)
                {
                    m_SafeNetLimitMessage = value;
                    RaisePropertyChanged(() => SafeNetLimitMessage);
                }
            }
        }

        #endregion

        #region cnc state
        private CncStateInfoDto m_CncStateInfo=new CncStateInfoDto();
        public CncStateInfoDto CncStateInfo
        {
            get { return m_CncStateInfo; }
            set
            {
                if (m_CncStateInfo != value)
                {
                    m_CncStateInfo = value;
                    RaisePropertyChanged(() => CncStateInfo);
                }
            }
        }

        #endregion

        #region LOGIN
        private string m_LoginStatus;
        public string LoginStatus
        {
            get { return m_LoginStatus; }
            set
            {
                if (m_LoginStatus != value)
                {
                    m_LoginStatus = value;
                    RaisePropertyChanged(() => LoginStatus);
                }
            }
        }

        private string m_UserName;
        public string UserName
        {
            get { return m_UserName; }
            set
            {
                if (m_UserName != value)
                {
                    m_UserName = value;
                    RaisePropertyChanged(() => UserName);
                }
            }
        }

        private string m_UserPwd;
        public string UserPwd
        {
            get { return m_UserPwd; }
            set
            {
                if (m_UserPwd != value)
                {
                    m_UserPwd = value;
                    RaisePropertyChanged(() => UserPwd);
                }
            }
        }

        private string m_LoginMessage;
        public string LoginMessage
        {
            get { return m_LoginMessage; }
            set
            {
                if (m_LoginMessage != value)
                {
                    m_LoginMessage = value;
                    RaisePropertyChanged(() => LoginMessage);
                }
            }
        }

        public ICommand LoginCommand { get; set; }

        public ICommand CloseCommand { get; set; }

        public ICommand MiniCommand { get; set; }

        public ICommand MaxCommand { get; set; }

        #endregion

        #region menu button
        private bool m_MenuHomeClicked;
        public bool _MenuHomeClicked
        {
            get { return m_MenuHomeClicked; }
            set
            {
                if (m_MenuHomeClicked != value)
                {
                    m_MenuHomeClicked = value;
                    RaisePropertyChanged(() => _MenuHomeClicked);
                }
            }
        }

        private bool m_MenuMachiningClicked;
        public bool _MenuMachiningClicked
        {
            get { return m_MenuMachiningClicked; }
            set
            {
                if (m_MenuMachiningClicked != value)
                {
                    m_MenuMachiningClicked = value;
                    RaisePropertyChanged(() => _MenuMachiningClicked);
                }
            }
        }

        private bool m_MenuSimulationClicked;
        public bool _MenuSimulationClicked
        {
            get { return m_MenuSimulationClicked; }
            set
            {
                if (m_MenuSimulationClicked != value)
                {
                    m_MenuSimulationClicked = value;
                    RaisePropertyChanged(() => _MenuSimulationClicked);
                }
            }
        }

        private bool m_MenuMachineClicked;
        public bool _MenuMachineClicked
        {
            get { return m_MenuMachineClicked; }
            set
            {
                if (m_MenuMachineClicked != value)
                {
                    m_MenuMachineClicked = value;
                    RaisePropertyChanged(() => _MenuMachineClicked);
                }
            }
        }

        private bool m_MenuDiagnoseClicked;
        public bool _MenuDiagnoseClicked
        {
            get { return m_MenuDiagnoseClicked; }
            set
            {
                if (m_MenuDiagnoseClicked != value)
                {
                    m_MenuDiagnoseClicked = value;
                    RaisePropertyChanged(() => _MenuDiagnoseClicked);
                }
            }
        }

        private bool m_MenuIOClicked;
        public bool _MenuIOClicked
        {
            get { return m_MenuIOClicked; }
            set
            {
                if (m_MenuIOClicked != value)
                {
                    m_MenuIOClicked = value;
                    RaisePropertyChanged(() => _MenuIOClicked);
                }
            }
        }

        private bool m_MenuMaintainClicked;
        public bool _MenuMaintainClicked
        {
            get { return m_MenuMaintainClicked; }
            set
            {
                if (m_MenuMaintainClicked != value)
                {
                    m_MenuMaintainClicked = value;
                    RaisePropertyChanged(() => _MenuMaintainClicked);
                }
            }
        }

        private bool m_MenuCustom1Clicked;
        public bool _MenuCustom1Clicked
        {
            get { return m_MenuCustom1Clicked; }
            set
            {
                if (m_MenuCustom1Clicked != value)
                {
                    m_MenuCustom1Clicked = value;
                    RaisePropertyChanged(() => _MenuCustom1Clicked);
                }
            }
        }

        private bool m_MenuCustom2Clicked;
        public bool _MenuCustom2Clicked
        {
            get { return m_MenuCustom2Clicked; }
            set
            {
                if (m_MenuCustom2Clicked != value)
                {
                    m_MenuCustom2Clicked = value;
                    RaisePropertyChanged(() => _MenuCustom2Clicked);
                }
            }
        }

        private bool m_MenuHomeVisibility;
        public bool _MenuHomeVisibility
        {
            get { return m_MenuHomeVisibility; }
            set
            {
                if (m_MenuHomeVisibility != value)
                {
                    m_MenuHomeVisibility = value;
                    RaisePropertyChanged(() => _MenuHomeVisibility);
                }
            }
        }

        private bool m_MenuMachiningVisibility;
        public bool _MenuMachiningVisibility
        {
            get { return m_MenuMachiningVisibility; }
            set
            {
                if (m_MenuMachiningVisibility != value)
                {
                    m_MenuMachiningVisibility = value;
                    RaisePropertyChanged(() => _MenuMachiningVisibility);
                }
            }
        }

        private bool m_MenuSimulationVisibility;
        public bool _MenuSimulationVisibility
        {
            get { return m_MenuSimulationVisibility; }
            set
            {
                if (m_MenuSimulationVisibility != value)
                {
                    m_MenuSimulationVisibility = value;
                    RaisePropertyChanged(() => _MenuSimulationVisibility);
                }
            }
        }

        private bool m_MenuMachineVisibility;
        public bool _MenuMachineVisibility
        {
            get { return m_MenuMachineVisibility; }
            set
            {
                if (m_MenuMachineVisibility != value)
                {
                    m_MenuMachineVisibility = value;
                    RaisePropertyChanged(() => _MenuMachineVisibility);
                }
            }
        }

        private bool m_MenuDiagnoseVisibility;
        public bool _MenuDiagnoseVisibility
        {
            get { return m_MenuDiagnoseVisibility; }
            set
            {
                if (m_MenuDiagnoseVisibility != value)
                {
                    m_MenuDiagnoseVisibility = value;
                    RaisePropertyChanged(() => _MenuDiagnoseVisibility);
                }
            }
        }

        private bool m_MenuIOVisibility;
        public bool _MenuIOVisibility
        {
            get { return m_MenuIOVisibility; }
            set
            {
                if (m_MenuIOVisibility != value)
                {
                    m_MenuIOVisibility = value;
                    RaisePropertyChanged(() => _MenuIOVisibility);
                }
            }
        }

        private bool m_MenuMaintainVisibility;
        public bool _MenuMaintainVisibility
        {
            get { return m_MenuMaintainVisibility; }
            set
            {
                if (m_MenuMaintainVisibility != value)
                {
                    m_MenuMaintainVisibility = value;
                    RaisePropertyChanged(() => _MenuMaintainVisibility);
                }
            }
        }

        private bool m_MenuCustom1Visibility;
        public bool _MenuCustom1Visibility
        {
            get { return m_MenuCustom1Visibility; }
            set
            {
                if (m_MenuCustom1Visibility != value)
                {
                    m_MenuCustom1Visibility = value;
                    RaisePropertyChanged(() => _MenuCustom1Visibility);
                }
            }
        }

        private bool m_MenuCustom2Visibility;
        public bool _MenuCustom2Visibility
        {
            get { return m_MenuCustom2Visibility; }
            set
            {
                if (m_MenuCustom2Visibility != value)
                {
                    m_MenuCustom2Visibility = value;
                    RaisePropertyChanged(() => _MenuCustom2Visibility);
                }
            }
        }

        public ICommand _homeCmd { get; set; }
        public ICommand _machiningCmd { get; set; }
        public ICommand _machineCmd { get; set; }

        public ICommand _simulationCmd { get; set; }
        public ICommand _diagnoseCmd { get; set; }
        public ICommand _ioCmd { get; set; }
        public ICommand _maintainCmd { get; set; }
        public ICommand _custom1Cmd { get; set; }
        public ICommand _custom2Cmd { get; set; }

        #endregion

        #region message
        private List<string> m_SystemMessages = new List<string>();
        public List<string> SystemMessages
        {
            get { return m_SystemMessages; }
            set
            {
                if (m_SystemMessages != value)
                {
                    m_SystemMessages = value;
                    RaisePropertyChanged(() => SystemMessages);
                }
            }
        }

        #endregion

        #region ctol
        public MainViewModel( IMapper mapper, Fanuc fanuc, User user)
        {
            this._user = user;
            this._fanuc = fanuc;
            this._mapper = mapper;
            LoginCommand = new RelayCommand(OnLogin);
            LoginStatus = "Visible";
            CloseCommand = new RelayCommand(OnClose);
            MiniCommand = new RelayCommand(OnMini);
            MaxCommand = new RelayCommand(OnMax);
            ShowAlarmDialogCmd = new RelayCommand(OnShowAlarmDialog);
            ShowOpMessageDialogCmd = new RelayCommand(OnShowOpMessageDialog);
            ReLoadingCommand = new RelayCommand(OnReLoading);

            SafeNetLimitVisible = "Hidden";
            _LoadVisibility = "Visible";

            _homeCmd = new RelayCommand(OnHomeClick);
            _machiningCmd = new RelayCommand(OnMachiningClick);
            _simulationCmd = new RelayCommand(OnSimulationClick);
            _machineCmd = new RelayCommand(OnMachineClick);
            _diagnoseCmd = new RelayCommand(OnDiagnoseClick);
            _ioCmd = new RelayCommand(OnIOClick);
            _maintainCmd = new RelayCommand(OnMaintainClick);
            _custom1Cmd = new RelayCommand(OnCustom1Click);
            _custom2Cmd = new RelayCommand(OnCustom2Click);

            System.Timers.Timer timerB = new System.Timers.Timer();//刷新时间
            timerB.Interval = System.Convert.ToDouble(500);
            timerB.Elapsed += new System.Timers.ElapsedEventHandler(RefreshTime);
            timerB.Enabled = true;

            System.Timers.Timer timerP = new System.Timers.Timer();//获得诚信管理信息
            timerP.Interval = System.Convert.ToDouble(10000);
            timerP.Elapsed += new System.Timers.ElapsedEventHandler(SafeNet);
            timerP.Enabled = true;
            
            Messenger.Default.Register<string>(this, "ReloadMsg", msg =>
            {
                _Content = null;
                LoginStatus = "Visible";
            });

            //刷新操作信息
            timerN.Interval = System.Convert.ToDouble(5000);
            timerN.Elapsed += new System.Timers.ElapsedEventHandler(RefreshOperateNotice);
            timerN.Enabled = true;
            timerN.AutoReset = false;

            Messenger.Default.Register<string>(this, "OperateNotice", msg =>
            {
                timerN.Stop();
                _DisNotice = msg;
                timerN.Start();
            });

            //注册消息
            Messenger.Default.Register<CncStateInfo>(this, "CncStateMsg", msg =>
            {
                CncStateInfo = _mapper.Map<CncStateInfo, CncStateInfoDto>(msg);

                if (CncStateInfo.ProgramNum == "O9015") CncStateInfo.ProgramNum = "自动对中";
                if (CncStateInfo.ProgramNum == "O9016") CncStateInfo.ProgramNum = "自动清洁";
                if (CncStateInfo.ProgramNum == "O9017") CncStateInfo.ProgramNum = "自动寻边";
                if (CncStateInfo.ProgramNum == "O9018") CncStateInfo.ProgramNum = "手动寻边测试";

                //报警信息转换
                var al_timespan = (DateTime.Now - _lastAlarmUpdataTime).TotalSeconds;
                if (al_timespan > 3)
                {
                    if (CncStateInfo.CncAlarmList.Count == 0)
                    {
                        _DisAlarm = "";
                    }
                    else
                    {
                        try
                        {
                            string[] alm_type = { "SW", "PW", "IO", "PS", "OT", "OH", "SV", "SR", "MC", "SP", "DS", "IE", "BG", "SN", "", "EX", "", "", "", "PC" };
                            string[] alm_axis = { "", "(X)", "(Y)", "(Z)" };
                            if (_curAlarmIndex >= CncStateInfo.CncAlarmList.Count) _curAlarmIndex = 0;
                            _DisAlarm = alm_type[CncStateInfo.CncAlarmList[_curAlarmIndex].Type] +
                                    CncStateInfo.CncAlarmList[_curAlarmIndex].Alm_No.ToString("0000") +
                                    @" " + CncStateInfo.CncAlarmList[_curAlarmIndex].Alm_Msg;

                            
                            _curAlarmIndex++;
                        }
                        catch { }
                    }
                    _lastAlarmUpdataTime = DateTime.Now;
                }


                //操作信息转换
                var op_timespan = (DateTime.Now - _lastMessageUpdataTime).TotalSeconds;
                if (op_timespan > 3)
                {
                    if (CncStateInfo.CncMessageList.Count == 0)
                    {
                        _DisMessage = "";

                    }
                    else
                    {
                        try
                        {
                            if (_curMessageIndex >= CncStateInfo.CncMessageList.Count) _curMessageIndex = 0;
                            _DisMessage = 
                                    CncStateInfo.CncMessageList[_curMessageIndex].Msg_No.ToString("0000") +
                                    @" " + CncStateInfo.CncMessageList[_curMessageIndex].Alm_Msg;
                            _curMessageIndex++;
                        }
                        catch { }
                    }

                    _lastMessageUpdataTime = DateTime.Now;
                }
            });

            Messenger.Default.Register<string>(this, "SoftwareLimitMsgBySafeNet", msg =>
            {
                SafeNetLimitVisible = "Visible";
                SafeNetLimitMessage = msg;
            });

            Messenger.Default.Register<string>(this, "SoftwareNoLimitMsgBySafeNet", msg =>
            {
                SafeNetLimitVisible = "Hidden";
            });

            Messenger.Default.Register<string>(this, "SoftwareLimitNearMsgBySafeNet", msg =>
            {
                Messenger.Default.Send<string>(msg, "OperateNotice");
            });


            _LoadingMessage = "系统连接加载中,请稍候";
            _ReLoadConnVisibility = "Hidden";
            timerL.Interval = System.Convert.ToDouble(1000);
            timerL.Elapsed += new System.Timers.ElapsedEventHandler(OnLoad);
            timerL.Enabled = true;
            timerL.AutoReset = false;
            
        }

        private void OnLoad(object sender, System.Timers.ElapsedEventArgs e)
        {

            //var conn = _fanuc.ConnectTest();

            //if (conn == 0)
            //{
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                var csd = CncScreenDisplay.CreateInstance();

                    _LoadVisibility = "Hidden";

                    UserName = "BFM";
                    UserPwd = "FANUC123";
                    OnLogin();
                    SafeNetFunc();
            });
            //}
            //else
            //{
            //    DispatcherHelper.CheckBeginInvokeOnUI(() =>
            //    {
            //        _ReLoadConnVisibility = "Visible";
            //        _LoadingMessage = "系统连接加载失败,请重新加载";
            //    });
            //}
        }


        private void OnReLoading()
        {
            _LoadingMessage = "系统连接加载中,请稍候";
            _ReLoadConnVisibility = "Hidden";
            timerL.Enabled = true;
        }

        private void RefreshOperateNotice(object sender, System.Timers.ElapsedEventArgs e)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                _DisNotice = "";
            });


        }

        private void SafeNet(object sender, System.Timers.ElapsedEventArgs e)
        {
            SafeNetFunc();
        }

        private void SafeNetFunc()
        {
            Messenger.Default.Send<string>("ALLOW", "SafeNetLimitMsg");

            return;

            //HaspFeature feature = HaspFeature.Default;

            //using (Hasp hasp = new Hasp(feature))
            //{
            //    HaspStatus status = hasp.Login(VendorCode.Code, localScope);
            //    if (status == HaspStatus.StatusOk)
            //    {
            //        DateTime current_rtc = new DateTime();
            //        HaspStatus status_rtc = hasp.GetRtc(ref current_rtc);
            //        if (status_rtc != HaspStatus.StatusOk)
            //        {
            //            Messenger.Default.Send<string>("", "NOSAFENETKEY");
            //        }
            //        else
            //        {

            //            string queryFormat = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" +
            //                                  "<haspformat root=\"hasp_info\">" +
            //                                    " <feature>" +
            //                                    "  <attribute name=\"id\" />" +
            //                                    "  <element name=\"license\" />" +
            //                                    " </feature>" +
            //                                    "</haspformat>";

            //            string info = null;
            //            HaspStatus status_info = Hasp.GetInfo(localScope, queryFormat, VendorCode.Code, ref info);

            //            if (HaspStatus.StatusOk == status_info)
            //            {

            //                //<? xml version = "1.0" encoding = "UTF-8" ?>
            //                //< hasp_info >
            //                //  < feature id = "0" > 
            //                //    < license >
            //                //      < license_type > perpetual </ license_type >
            //                //    </ license >
            //                //  </ feature > 
            //                //  < feature id = "6666" >  
            //                //     < license >  
            //                //       < license_type > trial </ license_type >   
            //                //       < time_start > 1533653700 </ time_start >    
            //                //       < total_time > 2592000 </ total_time >
            //                //     </ license >   
            //                //   </ feature >
            //                //</ hasp_info >

            //                try
            //                {
            //                    XmlDocument xml = new XmlDocument();//初始化一个xml实例
            //                    xml.LoadXml(info);

            //                    XmlElement node_feature = (XmlElement)xml.SelectSingleNode("/hasp_info/feature[@id='6666']");
            //                    var time_start = node_feature.GetElementsByTagName("time_start").Item(0).InnerText;
            //                    var total_time = node_feature.GetElementsByTagName("total_time").Item(0).InnerText;

            //                    DateTime limit_time = new DateTime(1970, 1, 1, 0, 0, 0) + new TimeSpan(0, 0, int.Parse(time_start)) + new TimeSpan(0, 0, int.Parse(total_time));


            //                    if (current_rtc > limit_time)
            //                    {
            //                        Messenger.Default.Send<string>("PASS", "SafeNetLimitMsg");
            //                    }
            //                    else if ((limit_time - current_rtc).TotalDays < 30)
            //                    {
            //                        var remain_day = ((int)(limit_time - current_rtc).TotalDays).ToString();
            //                        Messenger.Default.Send<string>("授权即将结束，还剩" + remain_day + "天", "SafeNetNearMsg");
            //                        Messenger.Default.Send<string>("ALLOW", "SafeNetLimitMsg");
            //                    }
            //                    else
            //                    {
            //                        Messenger.Default.Send<string>("ALLOW", "SafeNetLimitMsg");
            //                    }
            //                }
            //                catch
            //                {
            //                    Messenger.Default.Send<string>("", "NoSafeNetKeyMsg");
            //                }


            //            }
            //            else
            //                Messenger.Default.Send<string>("", "NoSafeNetKeyMsg");
            //        }

            //    }
            //    else
            //    {
            //        Messenger.Default.Send<string>("", "NoSafeNetKeyMsg");
            //    }




            //}
        }


        #endregion


        public void OnShowAlarmDialog()
        {
            var win = new AlarmListWindow();
            win.ShowDialog();
        }

        public void OnShowOpMessageDialog()
        {
            var win = new OpMessageWindow();
            win.ShowDialog();
        }

        #region login
        private void OnLogin()
        {
            _MenuHomeVisibility = false;
            _MenuMachiningVisibility = false;
            _MenuSimulationVisibility = false;
            _MenuMachineVisibility = false;
            _MenuDiagnoseVisibility = false;
            _MenuIOVisibility = false;
            _MenuMaintainVisibility = false;

            var ret = _user.Login(UserName, UserPwd);
            if (ret == true)
            {
                LoginStatus = "Hidden";

                _MopVisibility = "Visible";
                _QWERTVisibility = "Hidden";

                var item = _user.UserRoles.Where(x => x.RoleName == "MainMenu_Home" & x.IsAuth==true).FirstOrDefault();
                if (item != null) _MenuHomeVisibility = true;

                item = _user.UserRoles.Where(x => x.RoleName == "MainMenu_Machining" & x.IsAuth == true).FirstOrDefault();
                if (item != null) _MenuMachiningVisibility = true;

                item = _user.UserRoles.Where(x => x.RoleName == "MainMenu_Simulation" & x.IsAuth == true).FirstOrDefault();
                if (item != null) _MenuSimulationVisibility = true;

                item = _user.UserRoles.Where(x => x.RoleName == "MainMenu_Machine" & x.IsAuth == true).FirstOrDefault();
                if (item != null) _MenuMachineVisibility = true;

                item = _user.UserRoles.Where(x => x.RoleName == "MainMenu_Diagnose" & x.IsAuth == true).FirstOrDefault();
                if (item != null) _MenuDiagnoseVisibility = true;

                item = _user.UserRoles.Where(x => x.RoleName == "MainMenu_IO" & x.IsAuth == true).FirstOrDefault();
                if (item != null) _MenuIOVisibility = true;

                item = _user.UserRoles.Where(x => x.RoleName == "MainMenu_Maintain" & x.IsAuth == true).FirstOrDefault();
                if (item != null) _MenuMaintainVisibility = true;


                if(_MenuHomeVisibility==true)
                {
                    _Content = new HomePage();
                    ChangeMenuButtonCheckedStatus(home: true);
                }
            }
            else
            {
                LoginMessage = "用户名或者密码错误，请重新登陆";
            }
        }

        private  void OnClose()
        {
            MessageBoxResult result = MessageBox.Show("确定是退出吗？", "询问", MessageBoxButton.YesNo, MessageBoxImage.Question);

            //关闭窗口
            if (result == MessageBoxResult.Yes)
            {

                //发送关闭软件的消息
                Messenger.Default.Send<GenericMessage<string>>(new GenericMessage<string>(""), "SoftwareQuitMsg");
            }
        }

        private void OnMini()
        {
                //发送关闭软件的消息
                Messenger.Default.Send<GenericMessage<string>>(new GenericMessage<string>(""), "SoftwareMiniMsg");
        }

        private void OnMax()
        {
            //发送关闭软件的消息
            Messenger.Default.Send<GenericMessage<string>>(new GenericMessage<string>(""), "SoftwareMaxMsg");
        }

        #endregion

        #region menu func
        private void OnHomeClick()
        {
            ChangeMenuButtonCheckedStatus(home: true);
            _Content = new HomePage();
        }

        private void OnMachiningClick()
        {
            ChangeMenuButtonCheckedStatus(machining: true);
            _Content = new MachiningPage();
        }

        private void OnSimulationClick()
        {
            ChangeMenuButtonCheckedStatus(simulation: true);
            _Content = new SimulationPage();
        }

        private void OnMachineClick()
        {
            ChangeMenuButtonCheckedStatus(machine: true);
            _Content = new MachinePage();
        }

        private void OnDiagnoseClick()
        {
            ChangeMenuButtonCheckedStatus(diagnose: true);
            _Content = new DiagnosePage();
        }

        private void OnIOClick()
        {
            ChangeMenuButtonCheckedStatus(io: true);
            _Content = new IOPage();
        }

        private void OnMaintainClick()
        {
            ChangeMenuButtonCheckedStatus(maintain: true);
            _Content = new MaintainPage();
        }

        private void OnCustom1Click()
        {
            ChangeMenuButtonCheckedStatus(custom1: true);
            _Content = new Custom1Page();
        }

        private void OnCustom2Click()
        {
            ChangeMenuButtonCheckedStatus(custom2: true);
            _Content = new Custom2Page();
        }

        #endregion

        #region private func
        private void ChangeMenuButtonCheckedStatus(bool home = false, bool machining = false, bool simulation = false, bool machine = false, bool diagnose = false, bool io = false, bool maintain = false, bool custom1 = false, bool custom2 = false)
        {
            _MenuHomeClicked = home;
            _MenuMachiningClicked = machining;
            _MenuSimulationClicked = simulation;
            _MenuMachineClicked = machine;
            _MenuDiagnoseClicked = diagnose;
            _MenuIOClicked = io;
            _MenuMaintainClicked = maintain;
            _MenuCustom1Clicked = custom1;
            _MenuCustom2Clicked = custom2;
        }

        private void RefreshTime(object sender, System.Timers.ElapsedEventArgs e)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                _Time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            });
        }

        #endregion
    }
}
