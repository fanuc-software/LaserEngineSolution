using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using AutoMapper;
using FanucCnc;
using LaserEngineHmi.Model;

namespace LaserEngineHmi.View.Controls
{
    public class MOPViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        #region MOP ICOM
        public ICommand CNC_SYSTEM_CMD { get; set; }
        public ICommand CNC_MESSAGE_CMD { get; set; }
        public ICommand CNC_GRAPH_CMD { get; set; }
        public ICommand CNC_POSITION_CMD { get; set; }
        public ICommand CNC_PROGRAM_CMD { get; set; }
        public ICommand CNC_OFFSET_CMD { get; set; }

        public ICommand  CNC_RAM_CMD { get; set; }


        public ICommand LoadPageCommand { get; set; }
        public ICommand UnLoadPageCommand { get; set; }

        public ICommand MOP_AUTO_CMD { get; set; }
        public ICommand MOP_EDIT_CMD { get; set; }
        public ICommand MOP_MDI_CMD { get; set; }
        public ICommand MOP_RMT_CMD { get; set; }
        public ICommand MOP_RTN_CMD { get; set; }
        public ICommand MOP_JOG_CMD { get; set; }
        public ICommand MOP_HANDLE_CMD { get; set; }
        public ICommand MOP_STEP_CMD { get; set; }
        public ICommand MOP_SKIP_CMD { get; set; }
        public ICommand MOP_OPT_CMD { get; set; }
        public ICommand MOP_DRY_CMD { get; set; }
        public ICommand MOP_AUTOSTART_CMD { get; set; }
        public ICommand MOP_STORAGESTOP_CMD { get; set; }
        public ICommand MOP_ROLLBACK_CMD { get; set; }
        public ICommand MOP_PIERCINGDELAY_CMD { get; set; }
        public ICommand MOP_PIERCINGSHORTEN_CMD { get; set; }
        public ICommand MOP_DUSTCLEAR_CMD { get; set; }
        public ICommand MOP_LAMPON_CMD { get; set; }
        public ICommand MOP_FOLLOWON_CMD { get; set; }
        public ICommand MOP_FOLLOWLOCK_CMD { get; set; }
        public ICommand MOP_RAPIDOV0_CMD { get; set; }
        public ICommand MOP_RAPIDOV25_CMD { get; set; }
        public ICommand MOP_RAPIDOV50_CMD { get; set; }
        public ICommand MOP_RAPIDOV100_CMD { get; set; }
        public ICommand MOP_HANDLEOV1_CMD { get; set; }
        public ICommand MOP_HANDLEOV10_CMD { get; set; }
        public ICommand MOP_HANDLEOV100_CMD { get; set; }
        public ICommand MOP_HANDLEOV1000_CMD { get; set; }
        public ICommand MOP_AXIS_X_CMD { get; set; }
        public ICommand MOP_AXIS_Y_CMD { get; set; }
        public ICommand MOP_AXIS_Z_CMD { get; set; }
        public ICommand MOP_AXIS_4_CMD { get; set; }
        public ICommand MOP_MANUAL_PLUS_CMD { get; set; }
        public ICommand MOP_MANUAL_RAPID_CMD { get; set; }
        public ICommand MOP_MANUAL_SUBTRACT_CMD { get; set; }

        public ICommand MOP_AUX_G_SUBTRACT_CMD { get; set; }
        public ICommand MOP_AUX_G_PLUS_CMD { get; set; }
        public ICommand MOP_LASER_POWER_SUBTRACT_CMD { get; set; }
        public ICommand MOP_LASER_POWER_PLUS_CMD { get; set; }
        public ICommand MOP_LASER_FREQ_SUBTRACT_CMD { get; set; }
        public ICommand MOP_LASER_FREQ_PLUS_CMD { get; set; }
        public ICommand MOP_LASER_DUTY_SUBTRACT_CMD { get; set; }
        public ICommand MOP_LASER_DUTY_PLUS_CMD { get; set; }
        public ICommand MOP_JOG_OVERRIDE_SUBTRACT_CMD { get; set; }
        public ICommand MOP_JOG_OVERRIDE_PLUS_CMD { get; set; }


        #endregion

        #region 属性
        private MopKeyStatusDto mop_Key_Status=new MopKeyStatusDto();
        public MopKeyStatusDto Mop_Key_Status
        {
            get { return mop_Key_Status; }
            set
            {
                if (mop_Key_Status != value)
                {
                    mop_Key_Status = value;
                    RaisePropertyChanged(() => Mop_Key_Status);
                }
            }
        }

        #endregion

        public MOPViewModel (IMapper mapper, Fanuc fanuc)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;

            LoadPageCommand = new RelayCommand(ON_LoadPageCommand);
            UnLoadPageCommand = new RelayCommand(ON_UnLoadPageCommand);

            CNC_SYSTEM_CMD = new RelayCommand(ON_CNC_SYSTEM_CMD);
            CNC_MESSAGE_CMD = new RelayCommand(ON_CNC_MESSAGE_CMD);
            CNC_GRAPH_CMD = new RelayCommand(ON_CNC_GRAPH_CMD);
            CNC_POSITION_CMD = new RelayCommand(ON_CNC_POSITION_CMD);
            CNC_PROGRAM_CMD = new RelayCommand(ON_CNC_PROGRAM_CMD);
            CNC_OFFSET_CMD = new RelayCommand(ON_CNC_OFFSET_CMD);
            CNC_RAM_CMD = new RelayCommand(ON_CNC_RAM_CMD);


            MOP_AUTO_CMD            = new RelayCommand(ON_MOP_AUTO_CMD            );
            MOP_EDIT_CMD            = new RelayCommand(ON_MOP_EDIT_CMD            );
            MOP_MDI_CMD             = new RelayCommand(ON_MOP_MDI_CMD             );
            MOP_RMT_CMD             = new RelayCommand(ON_MOP_RMT_CMD             );
            MOP_RTN_CMD             = new RelayCommand(ON_MOP_RTN_CMD             );
            MOP_JOG_CMD             = new RelayCommand(ON_MOP_JOG_CMD             );
            MOP_HANDLE_CMD          = new RelayCommand(ON_MOP_HANDLE_CMD          );
            MOP_STEP_CMD            = new RelayCommand(ON_MOP_STEP_CMD            );
            MOP_SKIP_CMD            = new RelayCommand(ON_MOP_SKIP_CMD            );
            MOP_OPT_CMD             = new RelayCommand(ON_MOP_OPT_CMD             );
            MOP_DRY_CMD             = new RelayCommand(ON_MOP_DRY_CMD             );
            MOP_AUTOSTART_CMD       = new RelayCommand(ON_MOP_AUTOSTART_CMD       );
            MOP_STORAGESTOP_CMD     = new RelayCommand(ON_MOP_STORAGESTOP_CMD     );
            MOP_ROLLBACK_CMD        = new RelayCommand(ON_MOP_ROLLBACK_CMD        );
            MOP_PIERCINGDELAY_CMD   = new RelayCommand(ON_MOP_PIERCINGDELAY_CMD   );
            MOP_PIERCINGSHORTEN_CMD = new RelayCommand(ON_MOP_PIERCINGSHORTEN_CMD );
            MOP_DUSTCLEAR_CMD       = new RelayCommand(ON_MOP_DUSTCLEAR_CMD       );
            MOP_LAMPON_CMD          = new RelayCommand(ON_MOP_LAMPON_CMD          );
            MOP_FOLLOWON_CMD        = new RelayCommand(ON_MOP_FOLLOWON_CMD        );
            MOP_FOLLOWLOCK_CMD      = new RelayCommand(ON_MOP_FOLLOWLOCK_CMD      );
            MOP_RAPIDOV0_CMD        = new RelayCommand(ON_MOP_RAPIDOV0_CMD        );
            MOP_RAPIDOV25_CMD       = new RelayCommand(ON_MOP_RAPIDOV25_CMD       );
            MOP_RAPIDOV50_CMD       = new RelayCommand(ON_MOP_RAPIDOV50_CMD       );
            MOP_RAPIDOV100_CMD      = new RelayCommand(ON_MOP_RAPIDOV100_CMD      );
            MOP_HANDLEOV1_CMD       = new RelayCommand(ON_MOP_HANDLEOV1_CMD       );
            MOP_HANDLEOV10_CMD      = new RelayCommand(ON_MOP_HANDLEOV10_CMD      );
            MOP_HANDLEOV100_CMD     = new RelayCommand(ON_MOP_HANDLEOV100_CMD     );
            MOP_HANDLEOV1000_CMD    = new RelayCommand(ON_MOP_HANDLEOV1000_CMD    );
            MOP_AXIS_X_CMD          = new RelayCommand(ON_MOP_AXIS_X_CMD          );
            MOP_AXIS_Y_CMD          = new RelayCommand(ON_MOP_AXIS_Y_CMD          );
            MOP_AXIS_Z_CMD          = new RelayCommand(ON_MOP_AXIS_Z_CMD          );
            MOP_AXIS_4_CMD          = new RelayCommand(ON_MOP_AXIS_4_CMD          );
            MOP_MANUAL_PLUS_CMD     = new RelayCommand(ON_MOP_MANUAL_PLUS_CMD     );
            MOP_MANUAL_RAPID_CMD    = new RelayCommand(ON_MOP_MANUAL_RAPID_CMD    );
            MOP_MANUAL_SUBTRACT_CMD = new RelayCommand(ON_MOP_MANUAL_SUBTRACT_CMD );
            MOP_AUX_G_SUBTRACT_CMD  = new RelayCommand(ON_MOP_AUX_G_SUBTRACT_CMD                );
            MOP_AUX_G_PLUS_CMD      = new RelayCommand(ON_MOP_AUX_G_PLUS_CMD                    );
            MOP_JOG_OVERRIDE_SUBTRACT_CMD = new RelayCommand(ON_MOP_JOG_OVERRIDE_SUBTRACT_CMD   );
            MOP_JOG_OVERRIDE_PLUS_CMD = new RelayCommand(ON_MOP_JOG_OVERRIDE_PLUS_CMD           );
            MOP_LASER_POWER_SUBTRACT_CMD = new RelayCommand(ON_MOP_LASER_POWER_SUBTRACT_CMD     );
            MOP_LASER_POWER_PLUS_CMD = new RelayCommand(ON_MOP_LASER_POWER_PLUS_CMD             );
            MOP_LASER_FREQ_SUBTRACT_CMD = new RelayCommand(ON_MOP_LASER_FREQ_SUBTRACT_CMD       );
            MOP_LASER_FREQ_PLUS_CMD = new RelayCommand(ON_MOP_LASER_FREQ_PLUS_CMD               );
            MOP_LASER_DUTY_SUBTRACT_CMD = new RelayCommand(ON_MOP_LASER_DUTY_SUBTRACT_CMD       );
            MOP_LASER_DUTY_PLUS_CMD = new RelayCommand(ON_MOP_LASER_DUTY_PLUS_CMD               );

            Messenger.Default.Register<MopKeyStatus>(this, "MopKeyStatusMsg", OnRefreshKeyStatus);
        }

        #region private function
        private void OnRefreshKeyStatus(MopKeyStatus mop)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                Mop_Key_Status = _mapper.Map<MopKeyStatus, MopKeyStatusDto>(mop);
            });
        }
        
        private void ON_LoadPageCommand()
        {
            _fanuc.ScannerMop_Start();
        }

        private void ON_UnLoadPageCommand()
        {
            _fanuc.ScannerMop_Cancel();
        }

        private void ON_MOP_AUX_G_SUBTRACT_CMD()
        {
            _fanuc.MOP_AUX_SUBTRACT_G_CMD(Mop_Key_Status.Mop_Aux_G_Value);
        }

        private void ON_MOP_AUX_G_PLUS_CMD()
        {
            _fanuc.MOP_AUX_PLUS_G_CMD(Mop_Key_Status.Mop_Aux_G_Value);
        }

        private void ON_MOP_JOG_OVERRIDE_SUBTRACT_CMD()
        {
            _fanuc.MOP_JOG_OVERRIDE_SUBTRACT_CMD(Mop_Key_Status.Mop_Jog_Override_Value);
        }

        private void ON_MOP_JOG_OVERRIDE_PLUS_CMD()
        {
            _fanuc.MOP_JOG_OVERRIDE_PLUS_CMD(Mop_Key_Status.Mop_Jog_Override_Value);
        }

        private void ON_MOP_LASER_POWER_SUBTRACT_CMD()
        {
            _fanuc.MOP_LASER_POWER_SUBTRACT_CMD(Mop_Key_Status.Mop_Laser_Power_Value);
        }

        private void ON_MOP_LASER_POWER_PLUS_CMD()
        {
            _fanuc.MOP_LASER_POWER_PLUS_CMD(Mop_Key_Status.Mop_Laser_Power_Value);
        }

        private void ON_MOP_LASER_FREQ_SUBTRACT_CMD()
        {
            _fanuc.MOP_LASER_FREQ_SUBTRACT_CMD(Mop_Key_Status.Mop_Laser_Freq_Value);
        }

        private void ON_MOP_LASER_FREQ_PLUS_CMD()
        {
            _fanuc.MOP_LASER_FREQ_PLUS_CMD(Mop_Key_Status.Mop_Laser_Freq_Value);
        }

        private void ON_MOP_LASER_DUTY_SUBTRACT_CMD()
        {
            _fanuc.MOP_LASER_DUTY_SUBTRACT_CMD(Mop_Key_Status.Mop_Laser_Duty_Value);
        }

        private void ON_MOP_LASER_DUTY_PLUS_CMD()
        {
            _fanuc.MOP_LASER_DUTY_PLUS_CMD(Mop_Key_Status.Mop_Laser_Duty_Value);
        }

        private void ON_MOP_AUTO_CMD()
        {
            var ret=_fanuc.ON_MOP_AUTO_CMD();
            if (ret != 0) Messenger.Default.Send<string>("切换至自动状态指令发送失败", "AddSystemMsg");
        }

        private void ON_MOP_EDIT_CMD()
        {
            var ret=_fanuc.ON_MOP_EDIT_CMD();
            if (ret != 0) Messenger.Default.Send<string>("切换至编辑状态指令发送失败", "AddSystemMsg");
        }

        private void ON_MOP_MDI_CMD()
        {
            _fanuc.ON_MOP_MDI_CMD();
        }

        private void ON_MOP_RMT_CMD()
        {
            _fanuc.ON_MOP_RMT_CMD();
        }

        private void ON_MOP_RTN_CMD()
        {
            _fanuc.ON_MOP_RTN_CMD();
        }

        private void ON_MOP_JOG_CMD()
        {
            _fanuc.ON_MOP_JOG_CMD();
        }

        private void ON_MOP_HANDLE_CMD()
        {
            _fanuc.ON_MOP_HANDLE_CMD();
        }

        private void ON_MOP_STEP_CMD()
        {
            _fanuc.ON_MOP_STEP_CMD();
        }

        private void ON_MOP_SKIP_CMD()
        {
            _fanuc.ON_MOP_SKIP_CMD();
        }

        private void ON_MOP_OPT_CMD()
        {
            _fanuc.ON_MOP_OPT_CMD();
        }

        private void ON_MOP_DRY_CMD()
        {
            _fanuc.ON_MOP_DRY_CMD();
        }

        private void ON_MOP_AUTOSTART_CMD()
        {
            _fanuc.ON_MOP_AUTOSTART_CMD();
        }

        private void ON_MOP_STORAGESTOP_CMD()
        {
            _fanuc.ON_MOP_STORAGESTOP_CMD();
        }

        private void ON_MOP_ROLLBACK_CMD()
        {
            _fanuc.ON_MOP_ROLLBACK_CMD();
        }

        private void ON_MOP_PIERCINGDELAY_CMD()
        {
            _fanuc.ON_MOP_PIERCINGDELAY_CMD();
        }

        private void ON_MOP_PIERCINGSHORTEN_CMD()
        {
            _fanuc.ON_MOP_PIERCINGSHORTEN_CMD();
        }

        private void ON_MOP_DUSTCLEAR_CMD()
        {
            _fanuc.ON_MOP_DUSTCLEAR_CMD();
        }

        private void ON_MOP_LAMPON_CMD()
        {
            _fanuc.ON_MOP_LAMPON_CMD();
        }
        private void ON_MOP_FOLLOWON_CMD()
        {
            _fanuc.ON_MOP_FOLLOWON_CMD();
        }
        private void ON_MOP_FOLLOWLOCK_CMD()
        {
            _fanuc.ON_MOP_FOLLOWLOCK_CMD();
        }
        private void ON_MOP_RAPIDOV0_CMD()
        {
            _fanuc.ON_MOP_RAPIDOV0_CMD();
        }
        private void ON_MOP_RAPIDOV25_CMD()
        {
            _fanuc.ON_MOP_RAPIDOV25_CMD();
        }
        private void ON_MOP_RAPIDOV50_CMD()
        {
            _fanuc.ON_MOP_RAPIDOV50_CMD();
        }
        private void ON_MOP_RAPIDOV100_CMD()
        {
            _fanuc.ON_MOP_RAPIDOV100_CMD();
        }
        private void ON_MOP_HANDLEOV1_CMD()
        {
            _fanuc.ON_MOP_HANDLEOV1_CMD();
        }
        private void ON_MOP_HANDLEOV10_CMD()
        {
            _fanuc.ON_MOP_HANDLEOV10_CMD();
        }
        private void ON_MOP_HANDLEOV100_CMD()
        {
            _fanuc.ON_MOP_HANDLEOV100_CMD();
        }
        private void ON_MOP_HANDLEOV1000_CMD()
        {
            _fanuc.ON_MOP_HANDLEOV1000_CMD();
        }

        private void ON_MOP_AXIS_X_CMD()
        {
            _fanuc.ON_MOP_AXIS_X_CMD();
        }

        private void ON_MOP_AXIS_Y_CMD()
        {
            _fanuc.ON_MOP_AXIS_Y_CMD();
        }

        private void ON_MOP_AXIS_Z_CMD()
        {
            _fanuc.ON_MOP_AXIS_Z_CMD();
        }

        private void ON_MOP_AXIS_4_CMD()
        {
            _fanuc.ON_MOP_AXIS_4_CMD();
        }

        private void ON_MOP_MANUAL_PLUS_CMD()
        {
            _fanuc.ON_MOP_MANUAL_PLUS_CMD();
        }

        private void ON_MOP_MANUAL_RAPID_CMD()
        {
            _fanuc.ON_MOP_MANUAL_RAPID_CMD();
        }

        private void ON_MOP_MANUAL_SUBTRACT_CMD()
        {
            _fanuc.ON_MOP_MANUAL_SUBTRACT_CMD();
        }


        private void ON_CNC_SYSTEM_CMD()
        {
            Messenger.Default.Send<string>("SYS", "CsdMenuKeyMsg");
        }
        private void ON_CNC_MESSAGE_CMD()
        {
            Messenger.Default.Send<string>("MSG", "CsdMenuKeyMsg");
        }
        private void ON_CNC_GRAPH_CMD()
        {
            Messenger.Default.Send<string>("GRA", "CsdMenuKeyMsg");
        }

        private void ON_CNC_POSITION_CMD()
        {
            Messenger.Default.Send<string>("POS", "CsdMenuKeyMsg");
        }
        private void ON_CNC_PROGRAM_CMD()
        {
            Messenger.Default.Send<string>("PROG", "CsdMenuKeyMsg");
        }
        private void ON_CNC_OFFSET_CMD()
        {
            Messenger.Default.Send<string>("OFS", "CsdMenuKeyMsg");
        }

        private void ON_CNC_RAM_CMD()
        {
            Messenger.Default.Send<string>("CUS1", "CsdMenuKeyMsg");
        }
        #endregion
    }
}
