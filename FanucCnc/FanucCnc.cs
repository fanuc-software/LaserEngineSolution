using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Collections;
using System.Threading;
using System.Runtime.InteropServices;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using DataCenter.Model;
using ConfigCenter;
using System.IO;
using Newtonsoft.Json;
using DataCenter.Services;
using DataCenter.Entities;
using FanucCnc.S200;

namespace FanucCnc
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public class PRGFOLDER
    {
        public Focas1.ODBPDFADIR folder1 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder2 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder3 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder4 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder5 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder6 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder7 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder8 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder9 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder10 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder11 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder12 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder13 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder14 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder15 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder16 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder17 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder18 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder19 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder20 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder21 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder22 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder23 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder24 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder25 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder26 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder27 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder28 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder29 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder30 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder31 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder32 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder33 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder34 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder35 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder36 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder37 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder38 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder39 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder40 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder41 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder42 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder43 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder44 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder45 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder46 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder47 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder48 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder49 = new Focas1.ODBPDFADIR();
        public Focas1.ODBPDFADIR folder50 = new Focas1.ODBPDFADIR();

    }

    #region program class
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public class PRGDIR2_data
    {
        public short number;
        public int length;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string comment = new string(' ', 51);
        public byte dummy;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public class PRGDIR2
    {
        public PRGDIR2_data dir1 = new PRGDIR2_data();
        public PRGDIR2_data dir2 = new PRGDIR2_data();
        public PRGDIR2_data dir3 = new PRGDIR2_data();
        public PRGDIR2_data dir4 = new PRGDIR2_data();
        public PRGDIR2_data dir5 = new PRGDIR2_data();
        public PRGDIR2_data dir6 = new PRGDIR2_data();
        public PRGDIR2_data dir7 = new PRGDIR2_data();
        public PRGDIR2_data dir8 = new PRGDIR2_data();
        public PRGDIR2_data dir9 = new PRGDIR2_data();
        public PRGDIR2_data dir10 = new PRGDIR2_data();
        public PRGDIR2_data dir11 = new PRGDIR2_data();
        public PRGDIR2_data dir12 = new PRGDIR2_data();
        public PRGDIR2_data dir13 = new PRGDIR2_data();
        public PRGDIR2_data dir14 = new PRGDIR2_data();
        public PRGDIR2_data dir15 = new PRGDIR2_data();
        public PRGDIR2_data dir16 = new PRGDIR2_data();
        public PRGDIR2_data dir17 = new PRGDIR2_data();
        public PRGDIR2_data dir18 = new PRGDIR2_data();
        public PRGDIR2_data dir19 = new PRGDIR2_data();
        public PRGDIR2_data dir20 = new PRGDIR2_data();
        public PRGDIR2_data dir21 = new PRGDIR2_data();
        public PRGDIR2_data dir22 = new PRGDIR2_data();
        public PRGDIR2_data dir23 = new PRGDIR2_data();
        public PRGDIR2_data dir24 = new PRGDIR2_data();
        public PRGDIR2_data dir25 = new PRGDIR2_data();
        public PRGDIR2_data dir26 = new PRGDIR2_data();
        public PRGDIR2_data dir27 = new PRGDIR2_data();
        public PRGDIR2_data dir28 = new PRGDIR2_data();
        public PRGDIR2_data dir29 = new PRGDIR2_data();
        public PRGDIR2_data dir30 = new PRGDIR2_data();

    }

    #endregion

    public class Fanuc
    {
        
        #region program function import
        [DllImport("FanucProgram.dll", EntryPoint = "GetProgramDir", CallingConvention = CallingConvention.Cdecl)]
        private static extern short _GetProgramDir([Out, MarshalAs(UnmanagedType.LPStruct)] PRGDIR2 r, ref short prgTotalNum, ushort flib);

        [DllImport("FanucProgram.dll", EntryPoint = "DownLoadNcProgramFromPcToCnc", CallingConvention = CallingConvention.Cdecl)]
        private static extern short _DownLoadNcProgramFromPcToCnc(string pcFilePath, string ncFilePath, ushort flib);

        [DllImport("FanucProgram.dll", EntryPoint = "UpLoadNcProgramFromCncToPc", CallingConvention = CallingConvention.Cdecl)]
        private static extern short _UpLoadNcProgramFromCncToPc(string pcFilePath, string ncFilePath, ushort flib);

        [DllImport("FanucProgram.dll", EntryPoint = "DeleteProgram", CallingConvention = CallingConvention.Cdecl)]
        private static extern short _DeleteProgram(string prgName, ushort flib);

        [DllImport("FanucProgram.dll", EntryPoint = "DeleteProgramFile", CallingConvention = CallingConvention.Cdecl)]
        private static extern short _DeleteProgramFile(string path, ushort flib);

        #endregion

        #region singleton
        private string m_ip;
        private ushort m_port;
        private ushort m_timeout;
        private bool m_simulate;
        private static Fanuc _instance = null;

        private ushort m_static_flib = 0;//静态刷新的连接句柄
        private BackgroundWorker m_static_BackgroundWorker = new BackgroundWorker();
        int m_static_freq = 10;

        private ushort m_mop_flib = 0;//mop刷新的连接句柄
        private BackgroundWorker m_mop_BackgroundWorker = new BackgroundWorker();
        int m_mop_freq = 100;

        private ushort m_diagnose_flib = 0;//诊断刷新的连接句柄
        private BackgroundWorker m_diagnose_BackgroundWorker = new BackgroundWorker();
        int m_diagnose_freq = 100;

        private bool m_diagnose_flag = false;
        private ushort m_diagnose_top_flib = 0;//诊断实际输出监控的连接句柄
        private BackgroundWorker m_diagnose_top_BackgroundWorker = new BackgroundWorker();
        int m_diagnose_top_freq = 100;

        private ushort m_simulation_flib = 0;//轨迹仿真的连接句柄
        private BackgroundWorker m_simulation_BackgroundWorker = new BackgroundWorker();
        int m_simulation_freq = 100;

        private ushort m_workstation_flib = 0;//工作台显示的连接句柄
        private BackgroundWorker m_workstation_BackgroundWorker = new BackgroundWorker();
        int m_workstation_freq = 100;

        private bool m_autofindside_flag = false;
        private ushort m_autofindside_flib = 0;//自动寻边的连接句柄
        private BackgroundWorker m_autofindside_BackgroundWorker = new BackgroundWorker();
        int m_autofindside_freq = 1000;

        
        private bool m_manualfindside_flag = false;

        #region PMC地址配置
        private short m_mop_status_startAdrType;
        private ushort m_mop_status_startAdr;
        private short m_mop_cmd_startAdrType;
        private ushort m_mop_cmd_startAdr;

        //辅助气体倍率相关
        private byte m_Aux_G_maxValue;
        private byte m_Aux_G_minValue;
        private byte m_Aux_G_stepValue;

        //手动倍率相关
        private byte m_jog_override_maxValue;
        private byte m_jog_override_minValue;
        private byte m_jog_override_stepValue;

        //加工功率倍率相关
        private byte m_laser_power_maxValue;
        private byte m_laser_power_minValue;
        private byte m_laser_power_stepValue;

        //激光频率倍率相关
        private byte m_laser_freq_maxValue;
        private byte m_laser_freq_minValue;
        private byte m_laser_freq_stepValue;

        //激光占空比倍率相关
        private byte m_laser_duty_maxValue;
        private byte m_laser_duty_minValue;
        private byte m_laser_duty_stepValue;

        //简易轮廓加工
        private short m_simplecorner_generate_AdrType;
        private ushort m_simplecorner_generate_Adr;
        private ushort m_simplecorner_generate_AdrBit;

        //自动寻边
        private short m_autofindside_start_AdrType;
        private ushort m_autofindside_start_Adr;
        private ushort m_autofindside_start_AdrBit;

        //割嘴自动清洁
        private short m_autocutterclean_start_AdrType;
        private ushort m_autocutterclean_start_Adr;
        private ushort m_autocutterclean_start_AdrBit;

        //割嘴复归
        private short m_cutterresetcheck_start_AdrType;
        private ushort m_cutterresetcheck_start_Adr;
        private ushort m_cutterresetcheck_start_AdrBit;

        //割嘴对中
        private short m_cuttercenter_start_AdrType;
        private ushort m_cuttercenter_start_Adr;
        private ushort m_cuttercenter_start_AdrBit;

        private short m_laserstart_AdrType;
        private ushort m_laserstart_Adr;
        private ushort m_laserstart_AdrBit;

        private short m_laseralarm_AdrType;
        private ushort m_laseralarm_Adr;
        private ushort m_laseralarm_AdrBit;

        //余料切割
        private short m_remaincut_start_AdrType;
        private ushort m_remaincut_start_Adr;
        private ushort m_remaincut_start_AdrBit;

        //手动交换工作台
        private short m_workstation_cmd_mainup_AdrType;
        private ushort m_workstation_cmd_mainup_Adr;
        private ushort m_workstation_cmd_mainup_AdrBit;

        private short m_workstation_cmd_maindown_AdrType;
        private ushort m_workstation_cmd_maindown_Adr;
        private ushort m_workstation_cmd_maindown_AdrBit;

        private short m_workstation_cmd_mainleft_AdrType;
        private ushort m_workstation_cmd_mainleft_Adr;
        private ushort m_workstation_cmd_mainleft_AdrBit;

        private short m_workstation_cmd_mainright_AdrType;
        private ushort m_workstation_cmd_mainright_Adr;
        private ushort m_workstation_cmd_mainright_AdrBit;

        private short m_workstation_cmd_subup_AdrType;
        private ushort m_workstation_cmd_subup_Adr;
        private ushort m_workstation_cmd_subup_AdrBit;

        private short m_workstation_cmd_subdown_AdrType;
        private ushort m_workstation_cmd_subdown_Adr;
        private ushort m_workstation_cmd_subdown_AdrBit;

        private short m_workstation_cmd_subleft_AdrType;
        private ushort m_workstation_cmd_subleft_Adr;
        private ushort m_workstation_cmd_subleft_AdrBit;

        private short m_workstation_cmd_subright_AdrType;
        private ushort m_workstation_cmd_subright_Adr;
        private ushort m_workstation_cmd_subright_AdrBit;

        private short m_workstation_state_mainup_AdrType;
        private ushort m_workstation_state_mainup_Adr;
        private ushort m_workstation_state_mainup_AdrBit;

        private short m_workstation_state_maindown_AdrType;
        private ushort m_workstation_state_maindown_Adr;
        private ushort m_workstation_state_maindown_AdrBit;

        private short m_workstation_state_mainleft_AdrType;
        private ushort m_workstation_state_mainleft_Adr;
        private ushort m_workstation_state_mainleft_AdrBit;

        private short m_workstation_state_mainright_AdrType;
        private ushort m_workstation_state_mainright_Adr;
        private ushort m_workstation_state_mainright_AdrBit;

        private short m_workstation_state_subup_AdrType;
        private ushort m_workstation_state_subup_Adr;
        private ushort m_workstation_state_subup_AdrBit;

        private short m_workstation_state_subdown_AdrType;
        private ushort m_workstation_state_subdown_Adr;
        private ushort m_workstation_state_subdown_AdrBit;

        private short m_workstation_state_subleft_AdrType;
        private ushort m_workstation_state_subleft_Adr;
        private ushort m_workstation_state_subleft_AdrBit;

        private short m_workstation_state_subright_AdrType;
        private ushort m_workstation_state_subright_Adr;
        private ushort m_workstation_state_subright_AdrBit;

        private short m_workstation_zlimit_alarm_AdrType;
        private ushort m_workstation_zlimit_alarm_Adr;
        private ushort m_workstation_zlimit_alarm_AdrBit;

        private short m_workstation_start_AdrType;
        private ushort m_workstation_start_Adr;
        private ushort m_workstation_start_AdrBit;

        //简易套料
        private short m_simplenest_start_AdrType;
        private ushort m_simplenest_start_Adr;
        private ushort m_simplenest_start_AdrBit;


        #endregion

        #region Macro 地址配置
        short m_macro_simplecorner_h;
        short m_macro_simplecorner_i;
        short m_macro_simplecorner_j;
        short m_macro_simplecorner_d;
        short m_macro_simplecorner_r;
        short m_macro_simplecorner_ce;
        short m_macro_simplecorner_pe;

        short m_macro_cutterresetcheck_zlimit;

        short m_macro_autofindside_xd;
        short m_macro_autofindside_yd;
        short m_macro_autofindside_sita;
        short m_macro_autofindside_h;
        short m_macro_autofindside_x;
        short m_macro_autofindside_y;
        short m_macro_autofindside_rh;

        short m_macro_autocutterclean_h;
        short m_macro_autocutterclean_cleantime;
        short m_macro_autocutterclean_zlimit;

        short m_macro_cuttercenter_pc;
        short m_macro_cuttercenter_fr;
        short m_macro_cuttercenter_du;
        short m_macro_cuttercenter_time;

        short m_macro_remaincut_ce;
        short m_macro_remaincut_pe;
        short m_macro_remaincut_p1_x;
        short m_macro_remaincut_p1_y;
        short m_macro_remaincut_p2_x;
        short m_macro_remaincut_p2_y;
        short m_macro_remaincut_p3_x;
        short m_macro_remaincut_p3_y;
        short m_macro_remaincut_p4_x;
        short m_macro_remaincut_p4_y;

        short m_macro_simplenest_row;
        short m_macro_simplenest_colom;
        short m_macro_simplenest_xsize;
        short m_macro_simplenest_ysize;
        short m_macro_simplenest_g75g76;
        short m_macro_simplenest_q;
        short m_macro_simplenest_program;
        #endregion

        #endregion

        #region 属性
        #region MOP
        public MopKeyStatus MopKeySatus = new MopKeyStatus();

        #endregion

        #region 机床诊断信息
        public DiagnoseInfo Diagnose_Info = new DiagnoseInfo();

        #endregion

        #region 轨迹仿真
        public SimulationInfo Simulation_Info = new SimulationInfo();

        #endregion

        #region CNC State
        private CncStateInfo CncState_Info = new CncStateInfo();
        #endregion

        #region 激光器状态
        public bool LaserStart_Status { get; set; }
        public bool LaserAlarm_Status { get; set; }
        public bool NanoPowerOutput_Status { get; set; }

        #endregion

        #region 工作台状态
        public WorkStationInfo WorkStation_Info = new WorkStationInfo();

        #endregion

        #region 自动寻边
        public AutoFindSideInfo AutoFindSide_Info = new AutoFindSideInfo();

        #endregion

        #region 手动寻边
        public ManualFindSideInfo ManualFindSide_Info = new ManualFindSideInfo();

        #endregion

        #endregion

        #region 自动下发
        private object autoK = new object();

        private List<MaterialCode> materialCodes = new List<MaterialCode>();

        private List<GasCode> gasCodes = new List<GasCode>();

        private void LoadMaterialAndGasCode()
        {
            string jsonM;
            using (StreamReader sr = new StreamReader(@"materialcodes.cfg", true))
            {
                jsonM = sr.ReadToEnd();
            }
            materialCodes = JsonConvert.DeserializeObject<List<MaterialCode>>(jsonM);

            string jsonG;
            using (StreamReader sr = new StreamReader(@"gascodes.cfg", true))
            {
                jsonG = sr.ReadToEnd();
            }
            gasCodes = JsonConvert.DeserializeObject<List<GasCode>>(jsonG);
        }

        private void ReLoadMaterialAndGasCode()
        {

            materialCodes.Add(new MaterialCode
            {
                Material = "Steel",
                Code = 0
            }) ;

            materialCodes.Add(new MaterialCode
            {
                Material = "Aluminium",
                Code = 1
            });

            materialCodes.Add(new MaterialCode
            {
                Material = "Stainless",
                Code = 2
            });

            materialCodes.Add(new MaterialCode
            {
                Material = "Steel",
                Code = 3
            });

            materialCodes.Add(new MaterialCode
            {
                Material = "Galvanized Steel - Hot - dip",
                Code = 4
            });

            materialCodes.Add(new MaterialCode
            {
                Material = "Aluminium - 5052",
                Code = 5
            });

            materialCodes.Add(new MaterialCode
            {
                Material = "Galvanized Steel - Zinc",
                Code = 6
            });

            materialCodes.Add(new MaterialCode
            {
                Material = "Copper",
                Code = 7
            });

            materialCodes.Add(new MaterialCode
            {
                Material = "Brass",
                Code = 8
            });

            materialCodes.Add(new MaterialCode
            {
                Material = "Plastic",
                Code = 9
            });

            var jsonM = JsonConvert.SerializeObject(materialCodes, Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(@"materialcodes.cfg", false))
            {
                sw.Write(jsonM);
            }

            gasCodes.Add(new GasCode
            {
                Gas = "空气",
                Code = 0
            });

            gasCodes.Add(new GasCode
            {
                Gas = "氧气",
                Code = 1
            });

            gasCodes.Add(new GasCode
            {
                Gas = "氮气",
                Code = 2
            });

            var jsonG = JsonConvert.SerializeObject(gasCodes, Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(@"gascodes.cfg", false))
            {
                sw.Write(jsonG);
            }
        }

        private short autoLoad_TriggerType;
        private ushort autoLoad_TriggerAdr;
        private ushort autoLoad_TriggerBit;

        private short autoLoad_FinType;
        private ushort autoLoad_FinAdr;
        private ushort autoLoad_FinBit;

        private short autoLoad_ErrorType;
        private ushort autoLoad_ErrorAdr;
        private ushort autoLoad_ErrorBit;

        private void AutoLoadPmcConfig()
        {
            autoLoad_TriggerType = 5;
            autoLoad_TriggerAdr = 223;
            autoLoad_TriggerBit = 0;

            autoLoad_FinType = 5;
            autoLoad_FinAdr = 223;
            autoLoad_FinBit = 1;

            autoLoad_ErrorType = 5;
            autoLoad_ErrorAdr = 223;
            autoLoad_ErrorBit = 2;
        }

        #endregion

        #region Ctor

        public static Fanuc CreateInstance()
        {
            if (_instance == null)

            {
                _instance = new Fanuc();
            }
            return _instance;
        }

        public Fanuc()
        {

            //加载材料编码与气体编码
            ReLoadMaterialAndGasCode();
            AutoLoadPmcConfig();

            //TODO:从配置文件读取配置
            var config = new ConfigHelper();
            config.GetMachineInfo_Base(out m_ip, out m_port, out m_timeout);
            config.GetSimulateInfo(out m_simulate);
            m_mop_cmd_startAdrType = 5;
            m_mop_cmd_startAdr = 1000;
            m_mop_status_startAdrType = 12;
            m_mop_status_startAdr = 1000;

            m_macro_simplecorner_h = 800;
            m_macro_simplecorner_i = 801;
            m_macro_simplecorner_j = 802;
            m_macro_simplecorner_d = 803;
            m_macro_simplecorner_r = 804;
            m_macro_simplecorner_ce = 805;
            m_macro_simplecorner_pe = 806;

            m_simplecorner_generate_AdrType = 5;
            m_simplecorner_generate_Adr = 1020;
            m_simplecorner_generate_AdrBit = 0;

            m_macro_cutterresetcheck_zlimit = 825;

            m_macro_autofindside_xd = 810;
            m_macro_autofindside_yd = 811;
            m_macro_autofindside_sita = 812;
            m_macro_autofindside_h = 813;
            m_macro_autofindside_x = 814;
            m_macro_autofindside_y = 815;
            m_macro_autofindside_rh = 816;

            m_autofindside_start_AdrType = 5;
            m_autofindside_start_Adr = 1020;
            m_autofindside_start_AdrBit = 5;

            m_macro_autocutterclean_h = 836;
            m_macro_autocutterclean_cleantime = 837;
            m_macro_autocutterclean_zlimit = 838;

            m_autocutterclean_start_AdrType = 5;
            m_autocutterclean_start_Adr = 1021;
            m_autocutterclean_start_AdrBit = 4;

            m_cutterresetcheck_start_AdrType = 5;
            m_cutterresetcheck_start_Adr = 1023;
            m_cutterresetcheck_start_AdrBit = 0;

            m_macro_cuttercenter_pc = 858;
            m_macro_cuttercenter_fr = 859;
            m_macro_cuttercenter_du = 860;
            m_macro_cuttercenter_time = 861;

            m_cuttercenter_start_AdrType = 5;
            m_cuttercenter_start_Adr = 1025;
            m_cuttercenter_start_AdrBit = 7;

            m_laserstart_AdrType = 0;
            m_laserstart_Adr = 221;
            m_laserstart_AdrBit = 6;

            m_laseralarm_AdrType = 0;
            m_laseralarm_Adr = 220;
            m_laseralarm_AdrBit = 6;

            m_remaincut_start_AdrType = 5;
            m_remaincut_start_Adr = 1022;
            m_remaincut_start_AdrBit = 2;

            m_macro_remaincut_ce = 843;
            m_macro_remaincut_pe = 844;
            m_macro_remaincut_p1_x = 845;
            m_macro_remaincut_p1_y = 846;
            m_macro_remaincut_p2_x = 847;
            m_macro_remaincut_p2_y = 848;
            m_macro_remaincut_p3_x = 849;
            m_macro_remaincut_p3_y = 850;
            m_macro_remaincut_p4_x = 851;
            m_macro_remaincut_p4_y = 852;

            m_workstation_cmd_mainup_AdrType = 5;
            m_workstation_cmd_mainup_Adr = 1023;
            m_workstation_cmd_mainup_AdrBit = 6;

            m_workstation_cmd_maindown_AdrType = 5;
            m_workstation_cmd_maindown_Adr = 1024;
            m_workstation_cmd_maindown_AdrBit = 0;

            m_workstation_cmd_mainleft_AdrType = 5;
            m_workstation_cmd_mainleft_Adr = 1024;
            m_workstation_cmd_mainleft_AdrBit = 2;

            m_workstation_cmd_mainright_AdrType = 5;
            m_workstation_cmd_mainright_Adr = 1023;
            m_workstation_cmd_mainright_AdrBit = 4;

            m_workstation_cmd_subup_AdrType = 5;
            m_workstation_cmd_subup_Adr = 1023;
            m_workstation_cmd_subup_AdrBit = 7;

            m_workstation_cmd_subdown_AdrType = 5;
            m_workstation_cmd_subdown_Adr = 1024;
            m_workstation_cmd_subdown_AdrBit = 1;

            m_workstation_cmd_subleft_AdrType = 5;
            m_workstation_cmd_subleft_Adr = 1024;
            m_workstation_cmd_subleft_AdrBit = 3;

            m_workstation_cmd_subright_AdrType = 5;
            m_workstation_cmd_subright_Adr = 1023;
            m_workstation_cmd_subright_AdrBit = 5;

            m_workstation_state_mainup_AdrType = 5;
            m_workstation_state_mainup_Adr = 1025;
            m_workstation_state_mainup_AdrBit = 6;

            m_workstation_state_maindown_AdrType = 5;
            m_workstation_state_maindown_Adr = 1026;
            m_workstation_state_maindown_AdrBit = 0;

            m_workstation_state_mainleft_AdrType = 5;
            m_workstation_state_mainleft_Adr = 1026;
            m_workstation_state_mainleft_AdrBit = 2;

            m_workstation_state_mainright_AdrType = 5;
            m_workstation_state_mainright_Adr = 1025;
            m_workstation_state_mainright_AdrBit = 4;

            m_workstation_state_subup_AdrType = 5;
            m_workstation_state_subup_Adr = 1025;
            m_workstation_state_subup_AdrBit = 7;

            m_workstation_state_subdown_AdrType = 5;
            m_workstation_state_subdown_Adr = 1026;
            m_workstation_state_subdown_AdrBit = 1;

            m_workstation_state_subleft_AdrType = 5;
            m_workstation_state_subleft_Adr = 1026;
            m_workstation_state_subleft_AdrBit = 3;

            m_workstation_state_subright_AdrType = 5;
            m_workstation_state_subright_Adr = 1025;
            m_workstation_state_subright_AdrBit = 5;

            m_workstation_zlimit_alarm_AdrType = 5;
            m_workstation_zlimit_alarm_Adr = 1025;
            m_workstation_zlimit_alarm_AdrBit = 1;

            m_workstation_start_AdrType = 5;
            m_workstation_start_Adr = 1025;
            m_workstation_start_AdrBit = 2;

            m_macro_simplenest_row = 867;
            m_macro_simplenest_colom = 868;
            m_macro_simplenest_xsize = 869;
            m_macro_simplenest_ysize = 870;
            m_macro_simplenest_g75g76 = 871;
            m_macro_simplenest_q = 872;
            m_macro_simplenest_program = 873;

            m_simplenest_start_AdrType = 5;
            m_simplenest_start_Adr = 1026;
            m_simplenest_start_AdrBit = 5;


            //TODO:从配置文件读取配置
            m_Aux_G_maxValue = 100;
            m_Aux_G_minValue = 0;
            m_Aux_G_stepValue = 5;

            m_jog_override_maxValue = 100;
            m_jog_override_minValue = 0;
            m_jog_override_stepValue = 5;

            m_laser_power_maxValue = 100;
            m_laser_power_minValue = 0;
            m_laser_power_stepValue = 5;

            m_laser_freq_maxValue = 100;
            m_laser_freq_minValue = 0;
            m_laser_freq_stepValue = 5;

            m_laser_duty_maxValue = 100;
            m_laser_duty_minValue = 0;
            m_laser_duty_stepValue = 5;

            m_static_freq = 100;
            m_mop_freq = 100;
            m_diagnose_freq = 100;
            m_diagnose_top_freq = 1000;
            m_simulation_freq = 100;

            //静态扫描线程
            m_static_BackgroundWorker.WorkerReportsProgress = false;
            m_static_BackgroundWorker.WorkerSupportsCancellation = true;
            m_static_BackgroundWorker.DoWork += ScannerStatic_BK;
            m_static_BackgroundWorker.RunWorkerCompleted += ScannerStatic_RunWorkerCompleted;
            ScannerStatic_Start();

            //扫描MOP线程
            m_mop_BackgroundWorker.WorkerReportsProgress = false;
            m_mop_BackgroundWorker.WorkerSupportsCancellation = true;
            m_mop_BackgroundWorker.DoWork += ScannerMop_BK;
            m_mop_BackgroundWorker.RunWorkerCompleted += ScannerMop_RunWorkerCompleted;

            //扫描诊断信息线程
            m_diagnose_BackgroundWorker.WorkerReportsProgress = false;
            m_diagnose_BackgroundWorker.WorkerSupportsCancellation = true;
            m_diagnose_BackgroundWorker.DoWork += ScannerDiagnose_BK;
            m_diagnose_BackgroundWorker.RunWorkerCompleted += ScannerDiagnose_RunWorkerCompleted;

            //诊断实际输出功率监控线程
            m_diagnose_top_BackgroundWorker.WorkerReportsProgress = false;
            m_diagnose_top_BackgroundWorker.WorkerSupportsCancellation = true;
            m_diagnose_top_BackgroundWorker.DoWork += ScannerDiagnose_Top_BK;
            m_diagnose_top_BackgroundWorker.RunWorkerCompleted += ScannerDiagnose_Top_RunWorkerCompleted;

            //轨迹仿真监控线程
            m_simulation_BackgroundWorker.WorkerReportsProgress = false;
            m_simulation_BackgroundWorker.WorkerSupportsCancellation = true;
            m_simulation_BackgroundWorker.DoWork += ScannerSimulation_BK;
            m_simulation_BackgroundWorker.RunWorkerCompleted += ScannerSimulation_RunWorkerCompleted;
            
            //工作台监控线程
            m_workstation_BackgroundWorker.WorkerReportsProgress = false;
            m_workstation_BackgroundWorker.WorkerSupportsCancellation = true;
            m_workstation_BackgroundWorker.DoWork += ScannerWorkStation_BK;
            m_workstation_BackgroundWorker.RunWorkerCompleted += ScannerWorkStation_RunWorkerCompleted;

            m_autofindside_BackgroundWorker.WorkerReportsProgress = false;
            m_autofindside_BackgroundWorker.WorkerSupportsCancellation = true;
            m_autofindside_BackgroundWorker.DoWork += ScannerAutoFindSide_BK;
            m_autofindside_BackgroundWorker.RunWorkerCompleted += ScannerAutoFindSide_RunWorkerCompleted;


            Messenger.Default.Register<string>(this, "XplusMSG", msg =>
            {
                switch (msg)
                {
                    case "CLICK":
                        ArrorXplus_Click();
                        break;
                    case "UNCLICK":
                        ArrorXplus_UnClick();
                        break;
                }
            });

            Messenger.Default.Register<string>(this, "YplusMSG", msg =>
            {
                switch (msg)
                {
                    case "CLICK":
                        ArrorYplus_Click();
                        break;
                    case "UNCLICK":
                        ArrorYplus_UnClick();
                        break;
                }
            });

            Messenger.Default.Register<string>(this, "ZplusMSG", msg =>
            {
                switch (msg)
                {
                    case "CLICK":
                        ArrorZplus_Click();
                        break;
                    case "UNCLICK":
                        ArrorZplus_UnClick();
                        break;
                }
            });

            Messenger.Default.Register<string>(this, "XminusMSG", msg =>
            {
                switch (msg)
                {
                    case "CLICK":
                        ArrorXminus_Click();
                        break;
                    case "UNCLICK":
                        ArrorXminus_UnClick();
                        break;
                }
            });

            Messenger.Default.Register<string>(this, "YminusMSG", msg =>
            {
                switch (msg)
                {
                    case "CLICK":
                        ArrorYminus_Click();
                        break;
                    case "UNCLICK":
                        ArrorYminus_UnClick();
                        break;
                }
            });

            Messenger.Default.Register<string>(this, "GasBtnMSG", msg =>
            {
                switch (msg)
                {
                    case "CLICK":
                        GasBtn_Click();
                        break;
                    case "UNCLICK":
                        GasBtn_UnClick();
                        break;
                }
            });

            Messenger.Default.Register<string>(this, "ZminusMSG", msg =>
            {
                switch (msg)
                {
                    case "CLICK":
                        ArrorZminus_Click();
                        break;
                    case "UNCLICK":
                        ArrorZminus_UnClick();
                        break;
                }
            });

            Messenger.Default.Register<string>(this, "AutoFindSideStartMSG", msg =>
            {
                AutoFindSide_Start();
            });

            Messenger.Default.Register<string>(this, "CutterResetCheckMSG", msg =>
            {
                CutterResetCheck_Start();
            });

            Messenger.Default.Register<string>(this, "AutoCutterCleanStartMSG", msg =>
            {
                AutoCutterClean_Start();
            });

            Messenger.Default.Register<string>(this, "CutterCenterStartMSG", msg =>
            {
                CutterCenter_Start();
            });

            Messenger.Default.Register<string>(this, "SafeNetLimitMsg", msg =>
            {
                switch (msg)
                {
                    case "PASS":
                        if(CncState_Info.CncState!=1)
                        {
                            Messenger.Default.Send<string>("使用期限已到，请向制造商获得授权!", "SoftwareLimitMsgBySafeNet");
                        }
                        break;
                    case "ALLOW":
                        Messenger.Default.Send<string>("ALLOW", "SoftwareNoLimitMsgBySafeNet");
                        break;
                    default:
                        Messenger.Default.Send<string>("ALLOW", "SoftwareNoLimitMsgBySafeNet");
                        break;
                }
            });


            Messenger.Default.Register<string>(this, "SafeNetNearMsg", msg =>
            {
                Messenger.Default.Send<string>(msg, "SoftwareLimitNearMsgBySafeNet");
            });

            Messenger.Default.Register<string>(this, "NoSafeNetKeyMsg", msg =>
            {
                if (CncState_Info.CncState != 1)
                {
                    Messenger.Default.Send<string>("没有获得授权，请插入加密狗!", "SoftwareLimitMsgBySafeNet");
                }
            });
        }

        #endregion

        #region 即时连接
        #region 连接测试

        public short ConnectTest()
        {
            ushort flib = 0;
            short ret = BuildConnect(ref flib);

            FreeConnect(flib);

            //return 0;

            return ret;
        }

        #endregion

        #region 工艺库

        public string SendMachiningLibCuttingData(List<MachiningLib_Cutting> datas)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return "连接错误";

            short num = 1;

            Focas1.IODBPSCD2 list = new Focas1.IODBPSCD2();

            short i = 1;
            foreach (var data in datas)
            { 

                list.data1.slct = 32767;
                list.data1.feed = (int)(data.Cutting_Feed*10);//400 速度
                list.data1.power = data.Cutting_Power;
                list.data1.freq = data.Cutting_Freq;
                list.data1.duty = data.Cutting_Duty;
                list.data1.g_press = (short)(data.Cutting_G_Press*100);//1.5 气体压力
                list.data1.g_kind = data.Cutting_G_Kind;
                list.data1.g_ready_t = (short)(data.Cutting_G_Ready_T*10);//2.0 气体压力上升时间
                list.data1.displace = (short)(data.Cutting_Displace*10);
                list.data1.supple = (int)(data.Cutting_Supple*10);//2.0 补偿量
                list.data1.edge_slt = data.Cutting_Edge_Slt;
                list.data1.appr_slt = data.Cutting_Appr_Slt;
                list.data1.pwr_ctrl = data.Cutting_Pwr_Ctrl;
                list.data1.displace2 = (short)(data.Cutting_Displace * 10);//36 基准偏移量
                list.data1.gap_axis = '\u0001';
                list.data1.feed_dec = '\u0001';
                list.data1.supple_dec = '\u0001';
                list.data1.dsp2_dec = '\u0001';
                list.data1.pb_power = 0;
                

                ret = Focas1.cnc_wrpscdproc2(flib, i, ref num, list);
                if (ret != 0)
                {
                    Focas1.ODBERR err = new Focas1.ODBERR();
                    Focas1.cnc_getdtailerr(flib, err);
                    string err_msg = "";
                    switch (err.err_no)
                    {
                        case 1:
                            err_msg = "feedrate(第" + i.ToString() + "个)";
                            break;
                        case 2:
                            err_msg = "cutting peak power(第" + i.ToString() + "个)";
                            break;
                        case 3:
                            err_msg = "cutting frequency(第" + i.ToString() + "个)";
                            break;
                        case 4:
                            err_msg = "cutting duty(第" + i.ToString() + "个)";
                            break;
                        case 5:
                            err_msg = "assist gas pressure(第" + i.ToString() + "个)";
                            break;
                        case 6:
                            err_msg = "assist gas select(第" + i.ToString() + "个)";
                            break;
                        case 7:
                            err_msg = "assist gas setting time(第" + i.ToString() + "个)";
                            break;
                        case 8:
                            err_msg = "reference displace(第" + i.ToString() + "个)";
                            break;
                        case 9:
                            err_msg = "beam radius offset(第" + i.ToString() + "个)";
                            break;
                        case 10:
                            err_msg = "edge cutting select(第" + i.ToString() + "个)";
                            break;
                        case 11:
                            err_msg = "start-up select(第" + i.ToString() + "个)";
                            break;
                        case 12:
                            err_msg = "power control(第" + i.ToString() + "个)";
                            break;
                        case 13:
                            err_msg = "reference displace 2(第" + i.ToString() + "个)";
                            break;
                        default:
                            err_msg = "其他错误" + err.err_dtno.ToString() + "(第" + i.ToString() + "个)";
                            break;

                    }

                    FreeConnect(flib);
                    return err_msg;
                }

                var macro_fp = 154701 + (i - 1) * 5;
                ret = WriteMacroData_InTask(flib, macro_fp, data.FocalPosition * 1000);
                if (ret != 0)
                {
                    FreeConnect(flib);
                    return "写入焦点位置错误";
                }


                if (data.BEAMSPOT.HasValue == true)
                {
                    var macro_bs = 154702 + (i - 1) * 5;
                    ret = WriteMacroData_InTask(flib, macro_bs, data.BEAMSPOT.Value * 1000);
                    if (ret != 0)
                    {
                        FreeConnect(flib);
                        return "写入焦斑直径错误";
                    }
                }
                else
                {
                    var macro_bs = 154702 + (i - 1) * 5;
                    ret = WriteMacroData_InTask(flib, macro_bs, 0);
                    if (ret != 0)
                    {
                        FreeConnect(flib);
                        return "写入焦斑直径错误";
                    }
                }

                if (data.LIFTDIST.HasValue == true)
                {
                    var macro_ld = 154703 + (i - 1) * 5;
                    ret = WriteMacroData_InTask(flib, macro_ld, data.LIFTDIST.Value);
                    if (ret != 0)
                    {
                        FreeConnect(flib);
                        return "写入蛙跳高度错误";
                    }
                }
                else
                {
                    var macro_ld = 154703 + (i - 1) * 5;
                    ret = WriteMacroData_InTask(flib, macro_ld, 0);
                    if (ret != 0)
                    {
                        FreeConnect(flib);
                        return "写入蛙跳高度错误";
                    }
                }

                i++;
            }
            
            
            FreeConnect(flib);
            return null;

        }

        public string SendMachiningLibCuttingData_InTask(ushort flib, List<MachiningLib_Cutting> datas)
        {
            short num = 1;

            Focas1.IODBPSCD2 list = new Focas1.IODBPSCD2();

            short i = 1;
            foreach (var data in datas)
            {

                list.data1.slct = 32767;
                list.data1.feed = (int)(data.Cutting_Feed * 10);//400 速度
                list.data1.power = data.Cutting_Power;
                list.data1.freq = data.Cutting_Freq;
                list.data1.duty = data.Cutting_Duty;
                list.data1.g_press = (short)(data.Cutting_G_Press * 100);//1.5 气体压力
                list.data1.g_kind = data.Cutting_G_Kind;
                list.data1.g_ready_t = (short)(data.Cutting_G_Ready_T * 10);//2.0 气体压力上升时间
                list.data1.displace = (short)(data.Cutting_Displace * 10);
                list.data1.supple = (int)(data.Cutting_Supple * 10);//2.0 补偿量
                list.data1.edge_slt = data.Cutting_Edge_Slt;
                list.data1.appr_slt = data.Cutting_Appr_Slt;
                list.data1.pwr_ctrl = data.Cutting_Pwr_Ctrl;
                list.data1.displace2 = (short)(data.Cutting_Displace * 10);//36 基准偏移量
                list.data1.gap_axis = '\u0001';
                list.data1.feed_dec = '\u0001';
                list.data1.supple_dec = '\u0001';
                list.data1.dsp2_dec = '\u0001';
                list.data1.pb_power = 0;


                var ret = Focas1.cnc_wrpscdproc2(flib, i, ref num, list);
                if (ret != 0)
                {
                    Focas1.ODBERR err = new Focas1.ODBERR();
                    Focas1.cnc_getdtailerr(flib, err);
                    string err_msg = "";
                    switch (err.err_no)
                    {
                        case 1:
                            err_msg = "feedrate(第" + i.ToString() + "个)";
                            break;
                        case 2:
                            err_msg = "cutting peak power(第" + i.ToString() + "个)";
                            break;
                        case 3:
                            err_msg = "cutting frequency(第" + i.ToString() + "个)";
                            break;
                        case 4:
                            err_msg = "cutting duty(第" + i.ToString() + "个)";
                            break;
                        case 5:
                            err_msg = "assist gas pressure(第" + i.ToString() + "个)";
                            break;
                        case 6:
                            err_msg = "assist gas select(第" + i.ToString() + "个)";
                            break;
                        case 7:
                            err_msg = "assist gas setting time(第" + i.ToString() + "个)";
                            break;
                        case 8:
                            err_msg = "reference displace(第" + i.ToString() + "个)";
                            break;
                        case 9:
                            err_msg = "beam radius offset(第" + i.ToString() + "个)";
                            break;
                        case 10:
                            err_msg = "edge cutting select(第" + i.ToString() + "个)";
                            break;
                        case 11:
                            err_msg = "start-up select(第" + i.ToString() + "个)";
                            break;
                        case 12:
                            err_msg = "power control(第" + i.ToString() + "个)";
                            break;
                        case 13:
                            err_msg = "reference displace 2(第" + i.ToString() + "个)";
                            break;
                        default:
                            err_msg = "其他错误" + err.err_dtno.ToString() + "(第" + i.ToString() + "个)";
                            break;

                    }

                    return err_msg;
                }

                var macro_fp = 154701 + (i - 1) * 5;
                ret = WriteMacroData_InTask(flib, macro_fp, data.FocalPosition * 1000);
                if (ret != 0)
                {
                    return "写入焦点位置错误";
                }


                if (data.BEAMSPOT.HasValue == true)
                {
                    var macro_bs = 154702 + (i - 1) * 5;
                    ret = WriteMacroData_InTask(flib, macro_bs, data.BEAMSPOT.Value * 1000);
                    if (ret != 0)
                    {
                        return "写入焦斑直径错误";
                    }
                }
                else
                {
                    var macro_bs = 154702 + (i - 1) * 5;
                    ret = WriteMacroData_InTask(flib, macro_bs, 0);
                    if (ret != 0)
                    {
                        return "写入焦斑直径错误";
                    }
                }

                if (data.LIFTDIST.HasValue == true)
                {
                    var macro_ld = 154703 + (i - 1) * 5;
                    ret = WriteMacroData_InTask(flib, macro_ld, data.LIFTDIST.Value);
                    if (ret != 0)
                    {
                        return "写入蛙跳高度错误";
                    }
                }
                else
                {
                    var macro_ld = 154703 + (i - 1) * 5;
                    ret = WriteMacroData_InTask(flib, macro_ld, 0);
                    if (ret != 0)
                    {
                        return "写入蛙跳高度错误";
                    }
                }

                i++;
            }

            return null;

        }

        public string SendMachiningLibEdgeCutting(List<MachiningLib_EdgeCutting> datas)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return "连接错误";

            short num = 1;

            Focas1.IODBEDGE2 list = new Focas1.IODBEDGE2();
            short i = 201;
            
            foreach (var data in datas)
            {
                list.data1.slct = 32767;
                list.data1.power = data.EdgeCutting_Power;
                list.data1.freq = data.EdgeCutting_Freq;
                list.data1.duty = data.EdgeCutting_Duty;
                list.data1.g_press = (short)(data.EdgeCutting_G_Press*100);//0.01 气体压力
                list.data1.g_kind = data.EdgeCutting_G_Kind;
                list.data1.pier_t = (int)data.EdgeCutting_Pier_T*1000;//0.01 穿孔时间
                list.data1.angle = (int)(data.EdgeCutting_Angle*10);//30 角度
                list.data1.gap = (int)(data.EdgeCutting_Gap*10);//1.0基准偏移量
                list.data1.r_len = (int)(data.EdgeCutting_R_Len * 10);//2.5 返回距离
                list.data1.r_feed = (int)(data.EdgeCutting_R_Feed * 10);//260 返回速度
                list.data1.r_freq = data.EdgeCutting_R_Freq;
                list.data1.r_duty = data.EdgeCutting_R_Duty;
                list.data1.gap_axis = '\u0001';
                list.data1.angle_dec = '\u0001';
                list.data1.gap_dec = '\u0001';
                list.data1.r_len_dec = '\u0001';
                list.data1.r_feed_dec = '\u0001';
                list.data1.pb_power = 0;
                
                ret = Focas1.cnc_wrpscdedge2(flib, i, ref num, list);
                if (ret != 0)
                {
                    Focas1.ODBERR err = new Focas1.ODBERR();
                    Focas1.cnc_getdtailerr(flib, err);
                    string err_msg = "";
                    switch (err.err_no)
                    {
                        case 1:
                            err_msg = "Edge operation angle(第" + i.ToString() + "个)";
                            break;
                        case 2:
                            err_msg = "Peak power in piercing(第" + i.ToString() + "个)";
                            break;
                        case 3:
                            err_msg = "Frequency in piercing(第" + i.ToString() + "个)";
                            break;
                        case 4:
                            err_msg = "Duty in piercing(第" + i.ToString() + "个)";
                            break;
                        case 5:
                            err_msg = "Time in piercing(第" + i.ToString() + "个)";
                            break;
                        case 6:
                            err_msg = "Assist gas pressure in piercing(第" + i.ToString() + "个)";
                            break;
                        case 7:
                            err_msg = "Assist gas type in piercing(第" + i.ToString() + "个)";
                            break;
                        case 8:
                            err_msg = "Return distance(第" + i.ToString() + "个)";
                            break;
                        case 9:
                            err_msg = "Return speed(第" + i.ToString() + "个)";
                            break;
                        case 10:
                            err_msg = "Return frequency(第" + i.ToString() + "个)";
                            break;
                        case 11:
                            err_msg = "Return pulse duty(第" + i.ToString() + "个)";
                            break;
                        case 12:
                            err_msg = "Standard displacement(第" + i.ToString() + "个)";
                            break;
                        default:
                            err_msg = "其他错误" + err.err_dtno.ToString() + "(第" + i.ToString() + "个)";
                            break;

                    }

                    FreeConnect(flib);
                    return err_msg;
                }

                i++;
            }
            

            FreeConnect(flib);
            return null;

        }

        public string SendMachiningLibEdgeCutting_InTask(ushort flib, List<MachiningLib_EdgeCutting> datas)
        {
            short num = 1;

            Focas1.IODBEDGE2 list = new Focas1.IODBEDGE2();
            short i = 201;

            foreach (var data in datas)
            {
                list.data1.slct = 32767;
                list.data1.power = data.EdgeCutting_Power;
                list.data1.freq = data.EdgeCutting_Freq;
                list.data1.duty = data.EdgeCutting_Duty;
                list.data1.g_press = (short)(data.EdgeCutting_G_Press * 100);//0.01 气体压力
                list.data1.g_kind = data.EdgeCutting_G_Kind;
                list.data1.pier_t = (int)data.EdgeCutting_Pier_T * 1000;//0.01 穿孔时间
                list.data1.angle = (int)(data.EdgeCutting_Angle * 10);//30 角度
                list.data1.gap = (int)(data.EdgeCutting_Gap * 10);//1.0基准偏移量
                list.data1.r_len = (int)(data.EdgeCutting_R_Len * 10);//2.5 返回距离
                list.data1.r_feed = (int)(data.EdgeCutting_R_Feed * 10);//260 返回速度
                list.data1.r_freq = data.EdgeCutting_R_Freq;
                list.data1.r_duty = data.EdgeCutting_R_Duty;
                list.data1.gap_axis = '\u0001';
                list.data1.angle_dec = '\u0001';
                list.data1.gap_dec = '\u0001';
                list.data1.r_len_dec = '\u0001';
                list.data1.r_feed_dec = '\u0001';
                list.data1.pb_power = 0;

                var ret = Focas1.cnc_wrpscdedge2(flib, i, ref num, list);
                if (ret != 0)
                {
                    Focas1.ODBERR err = new Focas1.ODBERR();
                    Focas1.cnc_getdtailerr(flib, err);
                    string err_msg = "";
                    switch (err.err_no)
                    {
                        case 1:
                            err_msg = "Edge operation angle(第" + i.ToString() + "个)";
                            break;
                        case 2:
                            err_msg = "Peak power in piercing(第" + i.ToString() + "个)";
                            break;
                        case 3:
                            err_msg = "Frequency in piercing(第" + i.ToString() + "个)";
                            break;
                        case 4:
                            err_msg = "Duty in piercing(第" + i.ToString() + "个)";
                            break;
                        case 5:
                            err_msg = "Time in piercing(第" + i.ToString() + "个)";
                            break;
                        case 6:
                            err_msg = "Assist gas pressure in piercing(第" + i.ToString() + "个)";
                            break;
                        case 7:
                            err_msg = "Assist gas type in piercing(第" + i.ToString() + "个)";
                            break;
                        case 8:
                            err_msg = "Return distance(第" + i.ToString() + "个)";
                            break;
                        case 9:
                            err_msg = "Return speed(第" + i.ToString() + "个)";
                            break;
                        case 10:
                            err_msg = "Return frequency(第" + i.ToString() + "个)";
                            break;
                        case 11:
                            err_msg = "Return pulse duty(第" + i.ToString() + "个)";
                            break;
                        case 12:
                            err_msg = "Standard displacement(第" + i.ToString() + "个)";
                            break;
                        default:
                            err_msg = "其他错误" + err.err_dtno.ToString() + "(第" + i.ToString() + "个)";
                            break;

                    }

                    return err_msg;
                }

                i++;
            }


            return null;

        }

        public string SendMachiningLibPiercing(List<MachiningLib_Piercing> datas)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return "连接错误";

            short num = 1;

            Focas1.IODBPIRC list = new Focas1.IODBPIRC();
            short i = 101;
            

            foreach (var data in datas)
            {
                list.data1.slct = 32767;
                list.data1.power = data.Piercing_Power;
                list.data1.freq = data.Piercing_Freq;
                list.data1.duty = data.Piercing_Duty;
                list.data1.i_freq = data.Piercing_I_Freq;
                list.data1.i_duty = data.Piercing_I_Duty;
                list.data1.step_t = (short)(data.Piercing_Step_T*1000);
                list.data1.step_sum = data.Piercing_Step_Sum;
                list.data1.pier_t = (int)(data.Piercing_Pier_T*1000);
                list.data1.g_press = (short)(data.Piercing_G_Press*100);
                list.data1.g_kind = data.Piercing_G_Kind;
                list.data1.g_time = (short)(data.Piercing_G_Time*10);
                list.data1.def_pos = (short)(data.Piercing_Def_Pos*10);
                list.data1.def_pos2 = (short)(data.Piercing_Def_Pos*10);
                list.data1.gap_axis = '\u0001';
                list.data1.def_pos2_dec = '\u0001';
                list.data1.pb_power = 0;
                

                ret = Focas1.cnc_wrpscdpirc(flib, i, ref num, list);
                if (ret != 0)
                {
                    Focas1.ODBERR err = new Focas1.ODBERR();
                    Focas1.cnc_getdtailerr(flib, err);
                    string err_msg = "";
                    switch (err.err_no)
                    {
                        case 1:
                            err_msg = "peak power(第" + i.ToString() + "个)";
                            break;
                        case 2:
                            err_msg = "initial frequency(第" + i.ToString() + "个)";
                            break;
                        case 3:
                            err_msg = "initial duty(第" + i.ToString() + "个)";
                            break;
                        case 4:
                            err_msg = "step frequency(第" + i.ToString() + "个)";
                            break;
                        case 5:
                            err_msg = "step duty(第" + i.ToString() + "个)";
                            break;
                        case 6:
                            err_msg = "step time(第" + i.ToString() + "个)";
                            break;
                        case 7:
                            err_msg = "step number(第" + i.ToString() + "个)";
                            break;
                        case 8:
                            err_msg = "piercing time(第" + i.ToString() + "个)";
                            break;
                        case 9:
                            err_msg = "assist gas pressure(第" + i.ToString() + "个)";
                            break;
                        case 10:
                            err_msg = "assist gas select(第" + i.ToString() + "个)";
                            break;
                        case 11:
                            err_msg = "assist gas setting time(第" + i.ToString() + "个)";
                            break;
                        case 12:
                            err_msg = "reference displace(第" + i.ToString() + "个)";
                            break;
                        case 13:
                            err_msg = "reference displace 2(第" + i.ToString() + "个)";
                            break;
                        default:
                            err_msg = "其他错误" + err.err_dtno.ToString() + "(第" + i.ToString() + "个)";
                            break;

                    }

                    FreeConnect(flib);
                    return err_msg;
                }

                var macro_fp = 154851 + (i - 101) * 2;
                ret = WriteMacroData_InTask(flib, macro_fp, data.FocalPosition * 1000);
                if (ret != 0)
                {
                    FreeConnect(flib);
                    return "写入焦点位置错误";
                }

                i++;
            }
            

            FreeConnect(flib);
            return null;

        }

        public string SendMachiningLibPiercing_InTask(ushort flib, List<MachiningLib_Piercing> datas)
        {
            short num = 1;

            Focas1.IODBPIRC list = new Focas1.IODBPIRC();
            short i = 101;


            foreach (var data in datas)
            {
                list.data1.slct = 32767;
                list.data1.power = data.Piercing_Power;
                list.data1.freq = data.Piercing_Freq;
                list.data1.duty = data.Piercing_Duty;
                list.data1.i_freq = data.Piercing_I_Freq;
                list.data1.i_duty = data.Piercing_I_Duty;
                list.data1.step_t = (short)(data.Piercing_Step_T * 1000);
                list.data1.step_sum = data.Piercing_Step_Sum;
                list.data1.pier_t = (int)(data.Piercing_Pier_T * 1000);
                list.data1.g_press = (short)(data.Piercing_G_Press * 100);
                list.data1.g_kind = data.Piercing_G_Kind;
                list.data1.g_time = (short)(data.Piercing_G_Time * 10);
                list.data1.def_pos = (short)(data.Piercing_Def_Pos * 10);
                list.data1.def_pos2 = (short)(data.Piercing_Def_Pos * 10);
                list.data1.gap_axis = '\u0001';
                list.data1.def_pos2_dec = '\u0001';
                list.data1.pb_power = 0;


                var ret = Focas1.cnc_wrpscdpirc(flib, i, ref num, list);
                if (ret != 0)
                {
                    Focas1.ODBERR err = new Focas1.ODBERR();
                    Focas1.cnc_getdtailerr(flib, err);
                    string err_msg = "";
                    switch (err.err_no)
                    {
                        case 1:
                            err_msg = "peak power(第" + i.ToString() + "个)";
                            break;
                        case 2:
                            err_msg = "initial frequency(第" + i.ToString() + "个)";
                            break;
                        case 3:
                            err_msg = "initial duty(第" + i.ToString() + "个)";
                            break;
                        case 4:
                            err_msg = "step frequency(第" + i.ToString() + "个)";
                            break;
                        case 5:
                            err_msg = "step duty(第" + i.ToString() + "个)";
                            break;
                        case 6:
                            err_msg = "step time(第" + i.ToString() + "个)";
                            break;
                        case 7:
                            err_msg = "step number(第" + i.ToString() + "个)";
                            break;
                        case 8:
                            err_msg = "piercing time(第" + i.ToString() + "个)";
                            break;
                        case 9:
                            err_msg = "assist gas pressure(第" + i.ToString() + "个)";
                            break;
                        case 10:
                            err_msg = "assist gas select(第" + i.ToString() + "个)";
                            break;
                        case 11:
                            err_msg = "assist gas setting time(第" + i.ToString() + "个)";
                            break;
                        case 12:
                            err_msg = "reference displace(第" + i.ToString() + "个)";
                            break;
                        case 13:
                            err_msg = "reference displace 2(第" + i.ToString() + "个)";
                            break;
                        default:
                            err_msg = "其他错误" + err.err_dtno.ToString() + "(第" + i.ToString() + "个)";
                            break;

                    }

                    return err_msg;
                }

                var macro_fp = 154851 + (i - 101) * 2;
                ret = WriteMacroData_InTask(flib, macro_fp, data.FocalPosition * 1000);
                if (ret != 0)
                {
                    return "写入焦点位置错误";
                }

                i++;
            }


            return null;

        }

        public string SendMachiningLibSlopeControl(List<MachiningLib_SlopeControl> datas)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return "连接错误";

            short num = 1;

            Focas1.IODBPWRCTL list = new Focas1.IODBPWRCTL();
            short i = 901;
            

            foreach (var data in datas)
            {

                list.data1.slct = 16383;
                list.data1.power_min = data.SlopeControl_PowerMin;
                list.data1.pwr_sp_zr = data.SlopeControl_PwrSpZr;
                list.data1.freq_min = data.SlopeControl_FreqMin;
                list.data1.freq_sp_zr = data.SlopeControl_FreqSpZr;
                list.data1.duty_min = data.SlopeControl_DutyMin;
                list.data1.duty_sp_zr = data.SlopeControl_DutySpZr;
                list.data1.feed_r_dec = '\u0001';
                list.data1.feed_r = (int)(data.SlopeControl_FeedR*10);//10 速度允许的变化量
                list.data1.ag_press_min = 210;
                list.data1.ag_press_sp_zr = 21;
                list.data1.pb_power_min = 310;
                list.data1.pb_pwr_sp_zr = 31;
                list.data1.reserves[0] = 1;
                list.data1.reserves[1] = 1;

                ret = Focas1.cnc_wrlpscdpwrctl(flib, i, ref num, list);
                if(ret!=0)
                {
                    Focas1.ODBERR err = new Focas1.ODBERR();
                    Focas1.cnc_getdtailerr(flib, err);
                    string err_msg = "";
                    switch (err.err_no)
                    {
                        case 1:
                            err_msg = "Minimum peak power(第" + i.ToString() + "个)";
                            break;
                        case 2:
                            err_msg = "Peak power at feed rate(第" + i.ToString() + "个)";
                            break;
                        case 3:
                            err_msg = "Minimum pulse frequency(第" + i.ToString() + "个)";
                            break;
                        case 4:
                            err_msg = "Frequency at feed rate(第" + i.ToString() + "个)";
                            break;
                        case 5:
                            err_msg = "Minimum pulse duty(第" + i.ToString() + "个)";
                            break;
                        case 6:
                            err_msg = "Pulse duty at feed rate(第" + i.ToString() + "个)";
                            break;
                        case 7:
                            err_msg = "Allowable width of feed rate fluctuation(第" + i.ToString() + "个)";
                            break;
                        default:
                            err_msg = "其他错误" + err.err_dtno.ToString() + "(第" + i.ToString() + "个)";
                            break;

                    }

                    FreeConnect(flib);
                    return err_msg;
                }

                i++;
            }
            
            FreeConnect(flib);

            return null;

        }

        public string SendMachiningLibSlopeControl_InTask(ushort flib, List<MachiningLib_SlopeControl> datas)
        {
            short num = 1;

            Focas1.IODBPWRCTL list = new Focas1.IODBPWRCTL();
            short i = 901;


            foreach (var data in datas)
            {

                list.data1.slct = 16383;
                list.data1.power_min = data.SlopeControl_PowerMin;
                list.data1.pwr_sp_zr = data.SlopeControl_PwrSpZr;
                list.data1.freq_min = data.SlopeControl_FreqMin;
                list.data1.freq_sp_zr = data.SlopeControl_FreqSpZr;
                list.data1.duty_min = data.SlopeControl_DutyMin;
                list.data1.duty_sp_zr = data.SlopeControl_DutySpZr;
                list.data1.feed_r_dec = '\u0001';
                list.data1.feed_r = (int)(data.SlopeControl_FeedR * 10);//10 速度允许的变化量
                list.data1.ag_press_min = 210;
                list.data1.ag_press_sp_zr = 21;
                list.data1.pb_power_min = 310;
                list.data1.pb_pwr_sp_zr = 31;
                list.data1.reserves[0] = 1;
                list.data1.reserves[1] = 1;

                var ret = Focas1.cnc_wrlpscdpwrctl(flib, i, ref num, list);
                if (ret != 0)
                {
                    Focas1.ODBERR err = new Focas1.ODBERR();
                    Focas1.cnc_getdtailerr(flib, err);
                    string err_msg = "";
                    switch (err.err_no)
                    {
                        case 1:
                            err_msg = "Minimum peak power(第" + i.ToString() + "个)";
                            break;
                        case 2:
                            err_msg = "Peak power at feed rate(第" + i.ToString() + "个)";
                            break;
                        case 3:
                            err_msg = "Minimum pulse frequency(第" + i.ToString() + "个)";
                            break;
                        case 4:
                            err_msg = "Frequency at feed rate(第" + i.ToString() + "个)";
                            break;
                        case 5:
                            err_msg = "Minimum pulse duty(第" + i.ToString() + "个)";
                            break;
                        case 6:
                            err_msg = "Pulse duty at feed rate(第" + i.ToString() + "个)";
                            break;
                        case 7:
                            err_msg = "Allowable width of feed rate fluctuation(第" + i.ToString() + "个)";
                            break;
                        default:
                            err_msg = "其他错误" + err.err_dtno.ToString() + "(第" + i.ToString() + "个)";
                            break;

                    }

                    return err_msg;
                }

                i++;
            }


            return null;

        }

        public string SendMachiningLibToCnc(List<MachiningLib_Cutting> cuttings, List<MachiningLib_EdgeCutting> edgecuttings,
            List<MachiningLib_Piercing> piercings, List<MachiningLib_SlopeControl> slopcontrols)
        {
            ushort flib = 0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return "保存工艺数据至CNC错误（连接错误）";

            var ret_send = SendMachiningLibToCnc_InTask(flib, cuttings, edgecuttings, piercings, slopcontrols);

            FreeConnect(flib);

            return ret_send;
        }

        #endregion

        #region mop key
        public short ON_MOP_AUTO_CMD()
        {
            return WritePmcDataByBit(5, 2000, 0, true);
        }

        public short ON_MOP_EDIT_CMD()
        {
            return WritePmcDataByBit(5, 2000, 1, true);
        }

        public short ON_MOP_MDI_CMD()
        {
            return WritePmcDataByBit(5, 2000, 2, true);
        }

        public short ON_MOP_RMT_CMD()
        {
            return WritePmcDataByBit(5, 2000, 3, true);
        }

        public short ON_MOP_RTN_CMD()
        {
            return WritePmcDataByBit(5, 2000, 4, true);
        }

        public short ON_MOP_JOG_CMD()
        {
            return WritePmcDataByBit(5, 2000, 5, true);
        }

        public short ON_MOP_HANDLE_CMD()
        {
            return WritePmcDataByBit(5, 2000, 6, true);
        }

        public short ON_MOP_STEP_CMD()
        {
            return WritePmcDataByBit(5, 2000, 7, true);
        }

        public short ON_MOP_SKIP_CMD()
        {
            return WritePmcDataByBit(5, 2001, 0, true);
        }

        public short ON_MOP_OPT_CMD()
        {
            return WritePmcDataByBit(5, 2001, 1, true);
        }

        public short ON_MOP_DRY_CMD()
        {
            return WritePmcDataByBit(5, 2001, 2, true);
        }

        public short ON_MOP_AUTOSTART_CMD()
        {
            return WritePmcDataByBit(5, 2001, 3, true);
        }

        public short ON_MOP_STORAGESTOP_CMD()
        {
            return WritePmcDataByBit(5, 2001, 4, true);
        }

        public short ON_MOP_ROLLBACK_CMD()
        {
            return WritePmcDataByBit(5, 2001, 5, true);
        }

        public short ON_MOP_PIERCINGDELAY_CMD()
        {
            return WritePmcDataByBit(5, 2001, 6, true);
        }

        public short ON_MOP_PIERCINGSHORTEN_CMD()
        {
            return WritePmcDataByBit(5, 2001, 7, true);
        }

        public short ON_MOP_DUSTCLEAR_CMD()
        {
            return WritePmcDataByBit(5, 2002, 0, true);
        }

        public short ON_MOP_LAMPON_CMD()
        {
            return WritePmcDataByBit(5, 2002, 1, true);
        }
        public short ON_MOP_FOLLOWON_CMD()
        {
            return WritePmcDataByBit(5, 2002, 2, true);
        }
        public short ON_MOP_FOLLOWLOCK_CMD()
        {
            return WritePmcDataByBit(5, 2002, 3, true);
        }

        public short ON_MOP_AXIS_X_CMD()
        {
            return WritePmcDataByBit(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 2), 4, true);
        }

        public short ON_MOP_AXIS_Y_CMD()
        {
            return WritePmcDataByBit(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 2), 5, true);
        }

        public short ON_MOP_AXIS_Z_CMD()
        {
            return WritePmcDataByBit(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 2), 6, true);
        }

        public short ON_MOP_AXIS_4_CMD()
        {
            return WritePmcDataByBit(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 2), 7, true);
        }

        public short ON_MOP_MANUAL_PLUS_CMD()
        {
            return WritePmcDataByBit(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 3), 0, true);
        }
        public short ON_MOP_MANUAL_SUBTRACT_CMD()
        {
            return WritePmcDataByBit(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 3), 1, true);
        }

        public short ON_MOP_MANUAL_RAPID_CMD()
        {
            return WritePmcDataByBit(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 3), 2, true);
        }
        public short ON_MOP_HANDLEOV1_CMD()
        {
            return WritePmcDataByBit(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 3), 3, true);
        }
        public short ON_MOP_HANDLEOV10_CMD()
        {
            return WritePmcDataByBit(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 3), 4, true);
        }
        public short ON_MOP_HANDLEOV100_CMD()
        {
            return WritePmcDataByBit(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 3), 5, true);
        }
        public short ON_MOP_HANDLEOV1000_CMD()
        {
            return WritePmcDataByBit(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 3), 6, true);
        }

        public short ON_MOP_RAPIDOV0_CMD()
        {
            return WritePmcDataByBit(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 3), 7, true);
        }
        public short ON_MOP_RAPIDOV25_CMD()
        {
            return WritePmcDataByBit(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 4), 0, true);
        }
        public short ON_MOP_RAPIDOV50_CMD()
        {
            return WritePmcDataByBit(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 4), 1, true);
        }
        public short ON_MOP_RAPIDOV100_CMD()
        {
            return WritePmcDataByBit(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 4), 2, true);
        }


        #endregion

        #region mop value
        public short MOP_AUX_SUBTRACT_G_CMD(byte value)
        {
            if (value > m_Aux_G_minValue)
            {
                var temp = (byte)(value - m_Aux_G_stepValue);
                return WritePmcDataByByte(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 7), temp);
            }

            return -100;
        }

        public short MOP_AUX_PLUS_G_CMD(byte value)
        {
            if (value < m_Aux_G_maxValue)
            {
                var temp = (byte)(value + m_Aux_G_stepValue);
                return WritePmcDataByByte(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 7), temp);
            }

            return -100;
        }

        public short MOP_LASER_POWER_SUBTRACT_CMD(byte value)
        {
            if (value > m_laser_power_minValue)
            {
                var temp = (byte)(value - m_laser_power_stepValue);
                return WritePmcDataByByte(9, 2500, temp);
            }

            return -100;
        }

        public short MOP_LASER_POWER_PLUS_CMD(byte value)
        {
            if (value < m_laser_power_maxValue)
            {
                var temp = (byte)(value + m_laser_power_stepValue);
                return WritePmcDataByByte(9, 2500, temp);
            }

            return -100;
        }

        public short MOP_LASER_FREQ_SUBTRACT_CMD(byte value)
        {
            if (value > m_laser_freq_minValue)
            {
                var temp = (byte)(value - m_laser_freq_stepValue);

                temp = (byte)~temp;

                return WritePmcDataByByte(9, 2501, temp);
            }

            return -100;
        }

        public short MOP_LASER_FREQ_PLUS_CMD(byte value)
        {
            if (value < m_laser_freq_maxValue)
            {
                var temp = (byte)(value + m_laser_freq_stepValue);

                temp = (byte)~temp;

                return WritePmcDataByByte(9, 2501, temp);
            }

            return -100;
        }

        public short MOP_LASER_DUTY_SUBTRACT_CMD(byte value)
        {
            if (value > m_laser_duty_minValue)
            {
                var temp = (byte)(value - m_laser_duty_stepValue);
                return WritePmcDataByByte(9, 2502, temp);
            }

            return -100;
        }

        public short MOP_LASER_DUTY_PLUS_CMD(byte value)
        {
            if (value < m_laser_duty_maxValue)
            {
                var temp = (byte)(value + m_laser_duty_stepValue);
                return WritePmcDataByByte(9, 2502, temp);
            }

            return -100;
        }

        public short MOP_JOG_OVERRIDE_SUBTRACT_CMD(short value)
        {
            if (value > m_jog_override_minValue)
            {
                var temp = (short)(value - m_jog_override_stepValue);
                return WritePmcDataByWord(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 5), temp);
            }

            return -100;
        }

        public short MOP_JOG_OVERRIDE_PLUS_CMD(short value)
        {
            if (value < m_jog_override_maxValue)
            {
                var temp = (short)(value + m_jog_override_stepValue);
                return WritePmcDataByWord(m_mop_cmd_startAdrType, (ushort)(m_mop_cmd_startAdr + 5), temp);
            }

            return -100;
        }

        #endregion

        #region program
        public short GetProgramFolders(ref ObservableCollection<NcFolder> folder)
        {
            folder.Clear();
            folder.Add(new NcFolder { Level = 1, Name = "CNC_MEM", Icon = "&#xf07b;", Path = "//CNC_MEM/" });
            folder.Add(new NcFolder { Level = 2, Name = "MTB1", Icon = "&#xf07b;", Path = "//CNC_MEM/MTB1/" });
            folder.Add(new NcFolder { Level = 2, Name = "MTB2", Icon = "&#xf07b;", Path = "//CNC_MEM/MTB2/" });
            folder.Add(new NcFolder { Level = 2, Name = "SYSTEM", Icon = "&#xf07b;", Path = "//CNC_MEM/SYSTEM/" });
            folder.Add(new NcFolder { Level = 2, Name = "USER", Icon = "&#xf07b;", Path = "//CNC_MEM/USER/" });
            folder.Add(new NcFolder { Level = 3, Name = "LIBRARY", Icon = "&#xf07b;", Path = "//CNC_MEM/USER/LIBRARY/" });
            folder.Add(new NcFolder { Level = 3, Name = "PATH1", Icon = "&#xf07b;", Path = "//CNC_MEM/USER/PATH1/" });
            folder.Add(new NcFolder { Level = 3, Name = "PATH2", Icon = "&#xf07b;", Path = "//CNC_MEM/USER/PATH2/" });
            folder.Add(new NcFolder { Level = 3, Name = "PATH3", Icon = "&#xf07b;", Path = "//CNC_MEM/USER/PATH3/" });
            folder.Add(new NcFolder { Level = 3, Name = "PATH4", Icon = "&#xf07b;", Path = "//CNC_MEM/USER/PATH4/" });
            folder.Add(new NcFolder { Level = 3, Name = "UVW_MACRO", Icon = "&#xf07b;", Path = "//CNC_MEM/USER/UVW_MACRO/" });

            return 0;
        }

        public short GetPrograms(string path, ref ObservableCollection<NcProgram> progs)
        {
            ushort flib = 0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;
            
            short num_prog = 50;
            var pdf_adir_out = new PRGFOLDER();

            var pdf_adir_in = new Focas1.IDBPDFADIR();
            pdf_adir_in.req_num = 0;
            pdf_adir_in.size_kind = 1;
            pdf_adir_in.type = 1;
            pdf_adir_in.path = path;

            ret = Focas1.cnc_rdpdf_alldir(flib, ref num_prog, pdf_adir_in, pdf_adir_out);
            if (ret == 0)
            {
                for (int i = 0; i < num_prog; i++)
                {
                    string strdata = "folder" + (i + 1).ToString();
                    object folder = pdf_adir_out.GetType().GetField(strdata).GetValue(pdf_adir_out);

                    short data_kind = short.Parse(folder.GetType().GetField("data_kind").GetValue(folder).ToString());
                    int size = int.Parse(folder.GetType().GetField("size").GetValue(folder).ToString());
                    string name = folder.GetType().GetField("d_f").GetValue(folder).ToString();
                    string comment = folder.GetType().GetField("comment").GetValue(folder).ToString();

                    if (data_kind == 1)
                    {
                        progs.Add(new NcProgram
                        {
                            Name = name,
                            Comment = comment,
                            Length = size,
                            Path = path + name,
                        });
                    }

                }
            }

            FreeConnect(flib);

            return ret;
        }

        public short GetProgramDir(ref ObservableCollection<NcProgram> progs, ref short num)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            PRGDIR2 pgd = new PRGDIR2();
            ret = _GetProgramDir(pgd, ref num, flib);
            if (ret == -16)
            {
                return ret;
            }

            for (int i = 0; i < num; i++)
            {
                NcProgram pInfo = new NcProgram();

                string dir = "dir" + (i + 1).ToString();
                object str = pgd.GetType().GetField(dir).GetValue(pgd);


                pInfo.Name = "O" + str.GetType().GetField("number").GetValue(str).ToString();
                pInfo.Comment = str.GetType().GetField("comment").GetValue(str).ToString();
                pInfo.Length = long.Parse(str.GetType().GetField("length").GetValue(str).ToString());

                progs.Add(pInfo);
            }



            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return ret;

        }

        public short DownLoadNcProgramFromPcToCnc(string pcFilePath, string ncFilePath, bool isCover)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            ret = _DownLoadNcProgramFromPcToCnc(pcFilePath, ncFilePath, flib);
            if (ret != 0) return ret;

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return ret;
        }

        public short UpLoadNcProgramFromCncToPc(string pcFilePath, string ncFilePath, bool isCover)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            ret = _UpLoadNcProgramFromCncToPc(pcFilePath , ncFilePath, flib);
            if (ret != 0) return ret;

            ret = FreeConnect(flib);
            if (ret != 0) return ret;
            return ret;
        }

        public short DeleteNcProgram(string prgName)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            ret = _DeleteProgram(prgName, flib);
            if (ret != 0) return ret;

            ret = FreeConnect(flib);
            if (ret != 0) return ret;
            return ret;
        }

        public short DeleteNcProgram2(string progfile)
        {
            ushort flib = 0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            ret = _DeleteProgramFile(progfile, flib);
            if (ret != 0) return ret;

            ret = FreeConnect(flib);
            if (ret != 0) return ret;
            return ret;
        }

        public short SetMainProgram(string prg)
        {
            ushort flib = 0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            ret = Focas1.cnc_pdf_slctmain(flib, prg) ;
            if (ret != 0) return ret;

            ret = FreeConnect(flib);
            if (ret != 0) return ret;
            return ret;
        }
        #endregion

        #region 简易轮廓加工
        public short SimpleCorner_Generate()
        {
            return WritePmcDataByBit(m_simplecorner_generate_AdrType, m_simplecorner_generate_Adr, m_simplecorner_generate_AdrBit, true);
        }

        public short SimpleCorner_SET_H(double h)
        {
            int mcr_val = (int)(h * 1000);
            short dec_val = 3;
            short ret=WriteMacroData(m_macro_simplecorner_h, mcr_val, dec_val);

            return ret;
        }

        public short SimpleCorner_SET_I(double i)
        {
            int mcr_val = (int)(i * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_simplecorner_i, mcr_val, dec_val);

            return ret;
        }

        public short SimpleCorner_SET_J(double j)
        {
            int mcr_val = (int)(j * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_simplecorner_j, mcr_val, dec_val);

            return ret;
        }

        public short SimpleCorner_SET_D(double d)
        {
            int mcr_val = (int)(d * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_simplecorner_d, mcr_val, dec_val);

            return ret;
        }

        public short SimpleCorner_SET_R(double r)
        {
            int mcr_val = (int)(r * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_simplecorner_r, mcr_val, dec_val);

            return ret;
        }

        public short SimpleCorner_SET_CE(double ce)
        {
            int mcr_val = (int)(ce * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_simplecorner_ce, mcr_val, dec_val);

            return ret;
        }

        public short SimpleCorner_SET_PE(double pe)
        {
            int mcr_val = (int)(pe * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_simplecorner_pe, mcr_val, dec_val);

            return ret;
        }

        public short SimpleCorner_GET_H(ref double h)
        {
            short ret = ReadMacroData(m_macro_simplecorner_h, ref h);
            return ret;
        }

        public short SimpleCorner_GET_I(ref double i)
        {
            short ret = ReadMacroData(m_macro_simplecorner_i, ref i);
            return ret;
        }

        public short SimpleCorner_GET_J(ref double j)
        {
            short ret = ReadMacroData(m_macro_simplecorner_j, ref j);
            return ret;
        }

        public short SimpleCorner_GET_D(ref double d)
        {
            short ret = ReadMacroData(m_macro_simplecorner_d, ref d);
            return ret;
        }

        public short SimpleCorner_GET_R(ref double r)
        {
            short ret = ReadMacroData(m_macro_simplecorner_r, ref r);
            return ret;
        }

        public short SimpleCorner_GET_CE(ref double ce)
        {
            short ret = ReadMacroData(m_macro_simplecorner_ce, ref ce);
            return ret;
        }

        public short SimpleCorner_GET_PE(ref double pe)
        {
            short ret = ReadMacroData(m_macro_simplecorner_pe, ref pe);
            return ret;
        }


        #endregion

        #region 自动寻边
        public short AutoFindSide_Start()
        {
            return SelectMainProgram("//CNC_MEM/USER/LIBRARY/O9017");

             //WritePmcDataByBit(m_autofindside_start_AdrType, m_autofindside_start_Adr, m_autofindside_start_AdrBit, true);
        }

        public short AutoFindSide_SET_XD(double xd)
        {
            int mcr_val = (int)(xd * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_autofindside_xd, mcr_val, dec_val);

            return ret;
        }

        public short AutoFindSide_SET_YD(double yd)
        {
            int mcr_val = (int)(yd * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_autofindside_yd, mcr_val, dec_val);

            return ret;
        }

        public short AutoFindSide_SET_SITA(double sita)
        {
            int mcr_val = (int)(sita * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_autofindside_sita, mcr_val, dec_val);

            return ret;
        }

        public short AutoFindSide_SET_H(double h)
        {
            int mcr_val = (int)(h * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_autofindside_h, mcr_val, dec_val);

            return ret;
        }

        public short AutoFindSide_SET_X(double x)
        {
            int mcr_val = (int)(x * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_autofindside_x, mcr_val, dec_val);

            return ret;
        }

        public short AutoFindSide_SET_Y(double y)
        {
            int mcr_val = (int)(y * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_autofindside_y, mcr_val, dec_val);

            return ret;
        }

        public short AutoFindSide_SET_RH(double rh)
        {
            int mcr_val = (int)(rh * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_autofindside_rh, mcr_val, dec_val);

            return ret;
        }

        public short AutoFindSide_GET_XD(ref double xd)
        {
            short ret = ReadMacroData(m_macro_autofindside_xd, ref xd);
            return ret;
        }
        public short AutoFindSide_GET_YD(ref double yd)
        {
            short ret = ReadMacroData(m_macro_autofindside_yd, ref yd);
            return ret;
        }

        public short AutoFindSide_GET_SITA(ref double sita)
        {
            short ret = ReadMacroData(m_macro_autofindside_sita, ref sita);
            return ret;
        }

        public short AutoFindSide_GET_H(ref double h)
        {
            short ret = ReadMacroData(m_macro_autofindside_h, ref h);
            return ret;
        }

        public short AutoFindSide_GET_X(ref double x)
        {
            short ret = ReadMacroData(m_macro_autofindside_x, ref x);
            return ret;
        }

        public short AutoFindSide_GET_Y(ref double y)
        {
            short ret = ReadMacroData(m_macro_autofindside_y, ref y);
            return ret;
        }

        public short AutoFindSide_GET_RH(ref double rh)
        {
            short ret = ReadMacroData(m_macro_autofindside_rh, ref rh);
            return ret;
        }

        #endregion

        #region 割嘴自动清洁
        public short AutoCutterClean_Start()
        {
            return SelectMainProgram("//CNC_MEM/USER/LIBRARY/O9016");

        }

        public short AutoCutterClean_SET_XD(double xd)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            Focas1.IODBPSD buf = new Focas1.IODBPSD();
            buf.datano = 1241;
            buf.type = 1;
            buf.u.rdata = new Focas1.REALPRM()
            {
                prm_val = (int)(xd * 1000),
                dec_val=3
            };
            ret = Focas1.cnc_wrparam(flib, 12, buf);
            if (ret != 0) return ret;
            
            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;
            
        }

        public short AutoCutterClean_SET_YD(double yd)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            Focas1.IODBPSD buf = new Focas1.IODBPSD();
            buf.datano = 1241;
            buf.type = 2;
            buf.u.rdata = new Focas1.REALPRM()
            {
                prm_val = (int)(yd * 1000),
                dec_val = 3
            };
            ret = Focas1.cnc_wrparam(flib, 12, buf);
            if (ret != 0) return ret;

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;

        }

        public short AutoCutterClean_SET_H(double h)
        {
            int mcr_val = (int)(h * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_autocutterclean_h, mcr_val, dec_val);

            return ret;
        }

        public short AutoCutterClean_SET_CLEANTIME(double ct)
        {
            int mcr_val = (int)(ct * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_autocutterclean_cleantime, mcr_val, dec_val);

            return ret;
        }

        public short AutoCutterClean_SET_ZLIMIT(double zl)
        {
            int mcr_val = (int)(zl * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_autocutterclean_zlimit, mcr_val, dec_val);

            return ret;
        }

        public short AutoCutterClean_GET_XD(ref double xd)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            Focas1.IODBPSD buf = new Focas1.IODBPSD();
            ret = Focas1.cnc_rdparam(flib,1241,1, 8, buf);
            if (ret != 0) return ret;

            xd = buf.u.rdata.prm_val * Math.Pow(10, buf.u.rdata.dec_val*(-1));

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;
        }

        public short AutoCutterClean_GET_YD(ref double yd)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            Focas1.IODBPSD buf = new Focas1.IODBPSD();
            ret = Focas1.cnc_rdparam(flib, 1241, 2, 8, buf);
            if (ret != 0) return ret;

            yd = buf.u.rdata.prm_val * Math.Pow(10, buf.u.rdata.dec_val * (-1));

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;
        }

        public short AutoCutterClean_GET_H(ref double h)
        {
            short ret = ReadMacroData(m_macro_autocutterclean_h, ref h);
            return ret;
        }

        public short AutoCutterClean_GET_CLEANTIME(ref double ct)
        {
            short ret = ReadMacroData(m_macro_autocutterclean_cleantime, ref ct);
            return ret;
        }

        public short AutoCutterClean_GET_ZLIMIT(ref double zl)
        {
            short ret = ReadMacroData(m_macro_autocutterclean_zlimit, ref zl);
            return ret;
        }

        #endregion

        #region 割嘴复归检查
        public short CutterResetCheck_Start()
        {
            double xpos = 0;
            double ypos = 0;
            double zpos = 0;
            short ret = ReadMachinePosition(ref xpos, ref ypos, ref zpos);
            if (ret != 0) return ret;

            double zlimit = 0;
            ret = CutterResetCheck_GET_ZLIMIT(ref zlimit);
            if (ret != 0) return ret;

            if(zlimit> zpos)
            {
                WritePmcDataByBit(4, 1, 4, true);
                return -1;
            }

            ret = WritePmcDataByBit(m_cutterresetcheck_start_AdrType, m_cutterresetcheck_start_Adr, m_cutterresetcheck_start_AdrBit, true);

            return ret;
        }

        public short CutterResetCheck_SET_XPOS(double xpos)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            Focas1.IODBPSD buf = new Focas1.IODBPSD();
            buf.datano = 1242;
            buf.type = 1;
            buf.u.rdata = new Focas1.REALPRM()
            {
                prm_val = (int)(xpos * 1000),
                dec_val = 3
            };
            ret = Focas1.cnc_wrparam(flib, 12, buf);
            if (ret != 0) return ret;

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;

        }

        public short CutterResetCheck_SET_YPOS(double ypos)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            Focas1.IODBPSD buf = new Focas1.IODBPSD();
            buf.datano = 1242;
            buf.type = 2;
            buf.u.rdata = new Focas1.REALPRM()
            {
                prm_val = (int)(ypos * 1000),
                dec_val = 3
            };
            ret = Focas1.cnc_wrparam(flib, 12, buf);
            if (ret != 0) return ret;

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;

        }

        public short CutterResetCheck_SET_ZLIMIT(double zlimit)
        {
            int mcr_val = (int)(zlimit * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_cutterresetcheck_zlimit, mcr_val, dec_val);

            return ret;

        }

        

        public short CutterResetCheck_GET_XPOS(ref double xpos)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            Focas1.IODBPSD buf = new Focas1.IODBPSD();
            ret = Focas1.cnc_rdparam(flib, 1242, 1, 12, buf);
            if (ret != 0) return ret;

            xpos = buf.u.rdata.prm_val * Math.Pow(10, buf.u.rdata.dec_val * (-1));

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;
        }

        public short CutterResetCheck_GET_YPOS(ref double ypos)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            Focas1.IODBPSD buf = new Focas1.IODBPSD();
            ret = Focas1.cnc_rdparam(flib, 1242, 2, 12, buf);
            if (ret != 0) return ret;

            ypos = buf.u.rdata.prm_val * Math.Pow(10, buf.u.rdata.dec_val * (-1));

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;
        }

        public short CutterResetCheck_GET_ZLIMIT(ref double zlimit)
        {
            short ret = ReadMacroData(m_macro_cutterresetcheck_zlimit, ref zlimit);
            return ret;
        }

        #endregion

        #region 割嘴对中

        public short CutterCenter_Start()
        {
            return SelectMainProgram("//CNC_MEM/USER/LIBRARY/O9015");
        }

        public short CutterCenter_SET_PC(double pc)
        {
            int mcr_val = (int)(pc * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_cuttercenter_pc, mcr_val, dec_val);

            return ret;
        }

        public short CutterCenter_SET_FR(double fr)
        {
            int mcr_val = (int)(fr * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_cuttercenter_fr, mcr_val, dec_val);

            return ret;
        }

        public short CutterCenter_SET_DU(double du)
        {
            int mcr_val = (int)(du * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_cuttercenter_du, mcr_val, dec_val);

            return ret;
        }

        public short CutterCenter_SET_TIME(double time)
        {
            int mcr_val = (int)(time * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_cuttercenter_time, mcr_val, dec_val);

            return ret;
        }

        public short CutterCenter_GET_PC(ref double pc)
        {
            short ret = ReadMacroData(m_macro_cuttercenter_pc, ref pc);
            return ret;
        }

        public short CutterCenter_GET_FR(ref double fr)
        {
            short ret = ReadMacroData(m_macro_cuttercenter_fr, ref fr);
            return ret;
        }

        public short CutterCenter_GET_DU(ref double du)
        {
            short ret = ReadMacroData(m_macro_cuttercenter_du, ref du);
            return ret;
        }

        public short CutterCenter_GET_TIME(ref double time)
        {
            short ret = ReadMacroData(m_macro_cuttercenter_time, ref time);
            return ret;
        }

        public short CutterCenter_GET_LaserStartStatus(ref bool status)
        {
            status = LaserStart_Status;
            return 0;
        }

        public short CutterCenter_GET_LaserAlarmStatus(ref bool alarm)
        {
            alarm = LaserAlarm_Status;
            return 0;
        }


        #endregion

        #region 余料切割
        public short RemainCut_Start()
        {
            return WritePmcDataByBit(m_remaincut_start_AdrType, m_remaincut_start_Adr, m_remaincut_start_AdrBit, true);
        }

        public short RemainCut_SET_CE(double ce)
        {
            int mcr_val = (int)(ce * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_remaincut_ce, mcr_val, dec_val);

            return ret;
        }

        public short RemainCut_SET_PE(double pe)
        {
            int mcr_val = (int)(pe * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_remaincut_pe, mcr_val, dec_val);

            return ret;
        }

        public short RemainCut_SET_P1_X(double x)
        {
            int mcr_val = (int)(x * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_remaincut_p1_x, mcr_val, dec_val);

            return ret;
        }

        public short RemainCut_SET_P1_Y(double y)
        {
            int mcr_val = (int)(y * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_remaincut_p1_y, mcr_val, dec_val);

            return ret;
        }

        public short RemainCut_SET_P2_X(double x)
        {
            int mcr_val = (int)(x * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_remaincut_p2_x, mcr_val, dec_val);

            return ret;
        }

        public short RemainCut_SET_P2_Y(double y)
        {
            int mcr_val = (int)(y * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_remaincut_p2_y, mcr_val, dec_val);

            return ret;
        }

        public short RemainCut_SET_P3_X(double x)
        {
            int mcr_val = (int)(x * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_remaincut_p3_x, mcr_val, dec_val);

            return ret;
        }

        public short RemainCut_SET_P3_Y(double y)
        {
            int mcr_val = (int)(y * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_remaincut_p3_y, mcr_val, dec_val);

            return ret;
        }

        public short RemainCut_SET_P4_X(double x)
        {
            int mcr_val = (int)(x * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_remaincut_p4_x, mcr_val, dec_val);

            return ret;
        }

        public short RemainCut_SET_P4_Y(double y)
        {
            int mcr_val = (int)(y * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_remaincut_p4_y, mcr_val, dec_val);

            return ret;
        }

        public short RemainCut_GET_CE(ref double ce)
        {
            short ret = ReadMacroData(m_macro_remaincut_ce, ref ce);
            return ret;
        }

        public short RemainCut_GET_PE(ref double pe)
        {
            short ret = ReadMacroData(m_macro_remaincut_pe, ref pe);
            return ret;
        }


        public short RemainCut_GET_P1_X(ref double x)
        {
            short ret = ReadMacroData(m_macro_remaincut_p1_x, ref x);
            return ret;
        }

        public short RemainCut_GET_P1_Y(ref double y)
        {
            short ret = ReadMacroData(m_macro_remaincut_p1_y, ref y);
            return ret;
        }

        public short RemainCut_GET_P2_X(ref double x)
        {
            short ret = ReadMacroData(m_macro_remaincut_p2_x, ref x);
            return ret;
        }

        public short RemainCut_GET_P2_Y(ref double y)
        {
            short ret = ReadMacroData(m_macro_remaincut_p2_y, ref y);
            return ret;
        }

        public short RemainCut_GET_P3_X(ref double x)
        {
            short ret = ReadMacroData(m_macro_remaincut_p3_x, ref x);
            return ret;
        }

        public short RemainCut_GET_P3_Y(ref double y)
        {
            short ret = ReadMacroData(m_macro_remaincut_p3_y, ref y);
            return ret;
        }

        public short RemainCut_GET_P4_X(ref double x)
        {
            short ret = ReadMacroData(m_macro_remaincut_p1_x, ref x);
            return ret;
        }

        public short RemainCut_GET_P4_Y(ref double y)
        {
            short ret = ReadMacroData(m_macro_remaincut_p4_y, ref y);
            return ret;
        }

        public short RemainCut_GET_MachinePosition(ref double xpos, ref double ypos, ref double zpos)
        {
            return ReadMachinePosition(ref xpos, ref ypos, ref zpos);
        }
        #endregion

        #region  手动交换工作台
        public short WorkStation_ZLimit_ALARM()
        {
            return WritePmcDataByBit(m_workstation_zlimit_alarm_AdrType, m_workstation_zlimit_alarm_Adr, m_workstation_zlimit_alarm_AdrBit, true);
        }

        public short WorkStation_Start()
        {
            return WritePmcDataByBit(m_workstation_start_AdrType, m_workstation_start_Adr, m_workstation_start_AdrBit, true);
        }

        public short WorkStation_GET_MachinePosition(ref double xpos, ref double ypos, ref double zpos)
        {
            return ReadMachinePosition(ref xpos, ref ypos, ref zpos);
        }

        public short WorkStationMainUpPushCommand()
        {
            return WritePmcDataByBit(m_workstation_cmd_mainup_AdrType, m_workstation_cmd_mainup_Adr, m_workstation_cmd_mainup_AdrBit, true);
        }

        public short WorkStationMainUpReleaseCommand()
        {
            return WritePmcDataByBit(m_workstation_cmd_mainup_AdrType, m_workstation_cmd_mainup_Adr, m_workstation_cmd_mainup_AdrBit, false);
        }

        public short WorkStationMainLeftPushCommand()
        {
            return WritePmcDataByBit(m_workstation_cmd_mainleft_AdrType, m_workstation_cmd_mainleft_Adr, m_workstation_cmd_mainleft_AdrBit, true);
        }

        public short WorkStationMainLeftReleaseCommand()
        {
            return WritePmcDataByBit(m_workstation_cmd_mainleft_AdrType, m_workstation_cmd_mainleft_Adr, m_workstation_cmd_mainleft_AdrBit, false);
        }

        public short WorkStationMainRightPushCommand()
        {
            return WritePmcDataByBit(m_workstation_cmd_mainright_AdrType, m_workstation_cmd_mainright_Adr, m_workstation_cmd_mainright_AdrBit, true);
        }

        public short WorkStationMainRightReleaseCommand()
        {
            return WritePmcDataByBit(m_workstation_cmd_mainright_AdrType, m_workstation_cmd_mainright_Adr, m_workstation_cmd_mainright_AdrBit, false);
        }

        public short WorkStationMainDownPushCommand()
        {
            return WritePmcDataByBit(m_workstation_cmd_maindown_AdrType, m_workstation_cmd_maindown_Adr, m_workstation_cmd_maindown_AdrBit, true);
        }

        public short WorkStationMainDownReleaseCommand()
        {
            return WritePmcDataByBit(m_workstation_cmd_maindown_AdrType, m_workstation_cmd_maindown_Adr, m_workstation_cmd_maindown_AdrBit, false);
        }

        public short WorkStationSubUpPushCommand()
        {
            return WritePmcDataByBit(m_workstation_cmd_subup_AdrType, m_workstation_cmd_subup_Adr, m_workstation_cmd_subup_AdrBit, true);
        }

        public short WorkStationSubUpReleaseCommand()
        {
            return WritePmcDataByBit(m_workstation_cmd_subup_AdrType, m_workstation_cmd_subup_Adr, m_workstation_cmd_subup_AdrBit, false);
        }

        public short WorkStationSubLeftPushCommand()
        {
            return WritePmcDataByBit(m_workstation_cmd_subleft_AdrType, m_workstation_cmd_subleft_Adr, m_workstation_cmd_subleft_AdrBit, true);
        }

        public short WorkStationSubLeftReleaseCommand()
        {
            return WritePmcDataByBit(m_workstation_cmd_subleft_AdrType, m_workstation_cmd_subleft_Adr, m_workstation_cmd_subleft_AdrBit, false);
        }

        public short WorkStationSubRightPushCommand()
        {
            return WritePmcDataByBit(m_workstation_cmd_subright_AdrType, m_workstation_cmd_subright_Adr, m_workstation_cmd_subright_AdrBit, true);
        }

        public short WorkStationSubRightReleaseCommand()
        {
            return WritePmcDataByBit(m_workstation_cmd_subright_AdrType, m_workstation_cmd_subright_Adr, m_workstation_cmd_subright_AdrBit, false);
        }

        public short WorkStationSubDownPushCommand()
        {
            return WritePmcDataByBit(m_workstation_cmd_subdown_AdrType, m_workstation_cmd_subdown_Adr, m_workstation_cmd_subdown_AdrBit, true);
        }

        public short WorkStationSubDownReleaseCommand()
        {
            return WritePmcDataByBit(m_workstation_cmd_subdown_AdrType, m_workstation_cmd_subdown_Adr, m_workstation_cmd_subdown_AdrBit, false);
        }

        #endregion

        #region 简易套料
        public short SimpleNest_Start()
        {
            return WritePmcDataByBit(m_simplenest_start_AdrType, m_simplenest_start_Adr, m_simplenest_start_AdrBit, true);
        }

        public short SimpleNest_SET_ROW(int row)
        {
            int mcr_val = (int)(row * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_simplenest_row, mcr_val, dec_val);

            return ret;
        }

        public short SimpleNest_SET_COLOM(int colom)
        {
            int mcr_val = (int)(colom * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_simplenest_colom, mcr_val, dec_val);

            return ret;
        }

        public short SimpleNest_SET_XSIZE(double xsize)
        {
            int mcr_val = (int)(xsize * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_simplenest_xsize, mcr_val, dec_val);

            return ret;
        }

        public short SimpleNest_SET_YSIZE(double ysize)
        {
            int mcr_val = (int)(ysize * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_simplenest_ysize, mcr_val, dec_val);

            return ret;
        }

        public short SimpleNest_SET_G75G76(int g)
        {
            int mcr_val = (int)(g * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_simplenest_g75g76, mcr_val, dec_val);

            return ret;
        }

        public short SimpleNest_SET_Q(int q)
        {
            int mcr_val = (int)(q * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_simplenest_q, mcr_val, dec_val);

            return ret;
        }

        public short SimpleNest_SET_PROGRAM(int prg)
        {
            int mcr_val = (int)(prg * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_simplenest_program, mcr_val, dec_val);

            return ret;
        }

        public short SimpleNest_GET_ROW(ref int row)
        {
            double temp = 0;
            short ret = ReadMacroData(m_macro_simplenest_row, ref temp);
            row = (int)temp;
            return ret;
        }

        public short SimpleNest_GET_COLOM(ref int colom)
        {
            double temp = 0;
            short ret = ReadMacroData(m_macro_simplenest_colom, ref temp);
            colom = (int)temp;
            return ret;
        }

        public short SimpleNest_GET_XSIZE(ref double xsize)
        {
            short ret = ReadMacroData(m_macro_simplenest_xsize, ref xsize);
            return ret;
        }

        public short SimpleNest_GET_YSIZE(ref double ysize)
        {
            short ret = ReadMacroData(m_macro_simplenest_ysize, ref ysize);
            return ret;
        }
        public short SimpleNest_GET_G75G76(ref int g)
        {
            double temp = 0;
            short ret = ReadMacroData(m_macro_simplenest_g75g76, ref temp);
            g = (int)temp;
            return ret;
        }

        public short SimpleNest_GET_Q(ref int q)
        {
            double temp = 0;
            short ret = ReadMacroData(m_macro_simplenest_q, ref temp);
            q = (int)temp;
            return ret;
        }

        public short SimpleNest_GET_PRORGAM(ref int prg)
        {
            double temp = 0;
            short ret = ReadMacroData(m_macro_simplenest_program, ref temp);
            prg = (int)temp;
            return ret;
        }

        #endregion

        #region 方向键
        public void ArrorXplus_Click()
        {
            WritePmcDataByBit(12, 1020, 0, true);
        }

        public void ArrorXplus_UnClick()
        {
            WritePmcDataByBit(12, 1020, 0, false);
        }

        public void ArrorYplus_Click()
        {
            WritePmcDataByBit(12, 1020, 2, true);
        }

        public void ArrorYplus_UnClick()
        {
            WritePmcDataByBit(12, 1020, 2, false);
        }

        public void ArrorZplus_Click()
        {
            WritePmcDataByBit(12, 1020, 4, true);
        }

        public void ArrorZplus_UnClick()
        {
            WritePmcDataByBit(12, 1020, 4, false);
        }

        public void ArrorXminus_Click()
        {
            WritePmcDataByBit(12, 1020, 1, true);
        }

        public void ArrorXminus_UnClick()
        {
            WritePmcDataByBit(12, 1020, 1, false);
        }

        public void ArrorYminus_Click()
        {
            WritePmcDataByBit(12, 1020, 3, true);
        }

        public void ArrorYminus_UnClick()
        {
            WritePmcDataByBit(12, 1020, 3, false);
        }

        public void ArrorZminus_Click()
        {
            WritePmcDataByBit(12, 1020, 5, true);
        }

        public void ArrorZminus_UnClick()
        {
            WritePmcDataByBit(12, 1020, 5, false);
        }

        #endregion

        #region 焦点设定
        public short AutoFocalPoint_GET_1ST(ref double data)
        {
            short ret = ReadMacroData(511, ref data);
            return ret;
        }

        public short AutoFocalPoint_GET_2ND(ref double data)
        {
            short ret = ReadMacroData(512, ref data);
            return ret;
        }

        public short AutoFocalPoint_GET_3RD(ref double data)
        {
            short ret = ReadMacroData(513, ref data);
            return ret;
        }

        public short AutoFocalPoint_GET_CUT(ref double data)
        {
            short ret = ReadMacroData(514, ref data);
            return ret;
        }

        public short AutoFocalPoint_SET_1ST(double data)
        {
            int mcr_val = (int)(data * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(511, mcr_val, dec_val);

            return ret;
        }
        
        public short AutoFocalPoint_SET_2ND(double data)
        {
            int mcr_val = (int)(data * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(512, mcr_val, dec_val);

            return ret;
        }

        public short AutoFocalPoint_SET_3RD(double data)
        {
            int mcr_val = (int)(data * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(513, mcr_val, dec_val);

            return ret;
        }

        public short AutoFocalPoint_SET_CUT(double data)
        {
            int mcr_val = (int)(data * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(514, mcr_val, dec_val);

            return ret;
        }


        public short AutoFocalPoint_SET(double data1, double data2, double data3, double data4)
        {
            int mcr_val = (int)(data1 * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(511, mcr_val, dec_val);
            if (ret != 0) return ret;

            mcr_val = (int)(data2 * 1000);
            dec_val = 3;
            ret = WriteMacroData(512, mcr_val, dec_val);
            if (ret != 0) return ret;

            mcr_val = (int)(data3 * 1000);
            dec_val = 3;
            ret = WriteMacroData(513, mcr_val, dec_val);
            if (ret != 0) return ret;

            mcr_val = (int)(data4 * 1000);
            dec_val = 3;
            ret = WriteMacroData(514, mcr_val, dec_val);
            if (ret != 0) return ret;

            return 0;
        }

        #endregion

        #region 辅助气体测试
        public short AuxGasCheck_Get_Kind(ref short kind)
        {
            ushort flib = 0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            Focas1.IODBPSD buf = new Focas1.IODBPSD();
            ret = Focas1.cnc_rdparam(flib, 15100, 0, 8, buf);
            if (ret != 0) return ret;

            kind = buf.u.idata;

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;

        }

        public short AuxGasCheck_Get_Press(ref short press)
        {
            ushort flib = 0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            Focas1.IODBPSD buf = new Focas1.IODBPSD();
            ret = Focas1.cnc_rdparam(flib, 15136, 0, 8, buf);
            if (ret != 0) return ret;

            press = buf.u.idata;

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;

        }

        public short AuxGasCheck_Get_WaitTime(ref short time)
        {
            ushort flib = 0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            Focas1.IODBPSD buf = new Focas1.IODBPSD();
            ret = Focas1.cnc_rdparam(flib, 15135, 0, 8, buf);
            if (ret != 0) return ret;

            time = buf.u.idata;

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;

        }

        public short AuxGasCheck_Set_Kind(short kind)
        {
            ushort flib = 0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;


            int mcr_val = (int)(kind * 1000);
            short dec_val = 3;
            ret = WriteMacroData(6245, mcr_val, dec_val);

            //Focas1.IODBPSD buf = new Focas1.IODBPSD();
            //buf.datano = 15100;
            //buf.type = 0;
            //buf.u.idata = kind;
            //ret = Focas1.cnc_wrparam(flib, 8, buf);
            if (ret != 0) return ret;

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;
        }

        public short AuxGasCheck_Set_Press(short press)
        {
            ushort flib = 0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            int mcr_val = (int)(press * 1000);
            short dec_val = 3;
            ret = WriteMacroData(6247, mcr_val, dec_val);

            //Focas1.IODBPSD buf = new Focas1.IODBPSD();
            //buf.datano = 15136;
            //buf.type = 0;
            //buf.u.idata = press;
            //ret = Focas1.cnc_wrparam(flib, 8, buf);
            if (ret != 0) return ret;

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;
        }

        public short AuxGasCheck_Set_WaitTime(short time)
        {
            ushort flib = 0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            int mcr_val = (int)(time * 1000);
            short dec_val = 3;
            ret = WriteMacroData(6246, mcr_val, dec_val);
            if (ret != 0) return ret;

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;
        }

        public short AuxGasCheck_Start()
        {
            return 0;
        }

        public void GasBtn_Click()
        {
            WritePmcDataByBit(12, 1050, 0, true);
        }

        public void GasBtn_UnClick()
        {
            WritePmcDataByBit(12, 1050, 0, false);
        }


        #endregion

        #region 手动寻边

        public short GetMachinePosition(ref double xpos,ref double ypos)
        {
            ushort flib = 0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            Focas1.ODBAXIS buf = new Focas1.ODBAXIS();
            ret = Focas1.cnc_machine(flib, -1, 132, buf);
            if (ret != 0) return ret;
            xpos = (double)buf.data[0]/1000.0;
            ypos = (double)buf.data[1]/1000.0;
            FreeConnect(flib);

            return 0;

        }

        public short ManualFindSide_SET_XD(double xd)
        {
            int mcr_val = (int)(xd * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_autofindside_xd, mcr_val, dec_val);

            return ret;
        }

        public short ManualFindSide_SET_YD(double yd)
        {
            int mcr_val = (int)(yd * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(m_macro_autofindside_yd, mcr_val, dec_val);

            return ret;
        }

        public short ManualFindSide_SET_SITA(double sita)
        {
            int mcr_val = (int)(sita * 1000);
            short dec_val = 3;
            short ret = WriteMacroData(823, mcr_val, dec_val);

            return ret;
        }

        public short ManualFindSide_Test()
        {
            return SelectMainProgram("//CNC_MEM/USER/LIBRARY/O9018");

            //WritePmcDataByBit(m_autofindside_start_AdrType, m_autofindside_start_Adr, m_autofindside_start_AdrBit, true);
        }
        #endregion

        #endregion

        #region 扫描
        #region 静态
        private void ScannerStatic_BK(object sender, DoWorkEventArgs e)
        {
            short ret = -16;
            bool last_autoT = false;
            

            while (m_static_BackgroundWorker.CancellationPending == false)
            {
                Thread.Sleep(m_static_freq);
                
                if (ret != 0)
                {
                    ret = BuildConnect(ref m_static_flib);
                }

                Focas1.ODBST odbst=new Focas1.ODBST();
                ret = Focas1.cnc_statinfo(m_static_flib, odbst);
                if (ret == -16)
                {
                    CncState_Info.CncState = 4;

                    CncState_Info.CncModeState = "失去连接";
                    CncState_Info.CncRunState = "---";
                    CncState_Info.CncMotionState = "失去连接";
                    CncState_Info.CncMSTBState = "---";
                    CncState_Info.CncEmergState = "失去连接";
                    CncState_Info.CncAlarmState = "---";
                }
                else if(ret==0)
                {
                    if (odbst.alarm == 1)//故障
                    {
                        CncState_Info.CncState = 3;
                    }
                    else if (odbst.run > 0)//运行
                    {
                        CncState_Info.CncState = 1;
                    }
                    else if (odbst.emergency > 0)//待机(急停中)
                    {
                        CncState_Info.CncState = 2;
                    }
                    else//待机(非急停)
                    {
                        CncState_Info.CncState = 2;
                    }
                }
                else
                {
                    CncState_Info.CncState = 5;
                }

                bool svtemp = false;
                ReadPmcDataByBit_InTask(m_static_flib, 1, 0, 6, ref svtemp);
                CncState_Info.ServoState = svtemp == false ? 0 : 1;
                CncState_Info.LaserState = 1;


                string[] sMode =
                {
                        " MDI  ",
                        " MEM  ",
                        " **** ",
                        " EDIT ",
                        " HND  ",
                        " JOG  ",
                        " TJOG ",
                        " THND ",
                        " INC  ",
                        " REF  ",
                        " RMT  "
               };

                string[] sRun =
                {
                    " **** ",
                    " STOP ",
                    " HOLD ",
                    " STRT ",
                    " MSTR "
                };

                string[] sMotion =
                {
                    " *** ",
                    " MTN ",
                    " DWL "
                };

                string[] sMSTB =
                {
                    " *** ",
                    " FIN "
                };

                string[] sEmergency =
                {
                    " ***** ",
                    "  EMG  ",
                    " RESET "
                };
                ////在31iB上测试，先强制x8.4为1，再RESET+CAN，这时系统监测statinfo.alarm=8，sAlarm只有4个，现在补充5个，再次测试。changbysun20150928
                string[] sAlarm =
                {
                    " *** ",
                    " ALM ",
                    " BAT ",
                    " FAN ",
                    " *** ",
                    " *** ",
                    " *** ",
                    " *** ",
                    " PMC "
                };

                Focas1.ODBST buf = new Focas1.ODBST();
                var ret_st = Focas1.cnc_statinfo(m_static_flib, buf);
                if (ret_st == 0)
                {
                    CncState_Info.CncModeState = sMode[buf.aut];
                    CncState_Info.CncRunState = sRun[buf.run];
                    CncState_Info.CncMotionState = sMotion[buf.motion];
                    CncState_Info.CncMSTBState = sMSTB[buf.mstb];
                    CncState_Info.CncEmergState = sEmergency[buf.emergency];
                    CncState_Info.CncAlarmState = sAlarm[buf.alarm];
                }
                else
                {
                    CncState_Info.CncModeState = "连接错误";
                    CncState_Info.CncRunState = "连接错误";
                    CncState_Info.CncMotionState = "连接错误";
                    CncState_Info.CncMSTBState = "连接错误";
                    CncState_Info.CncEmergState = "连接错误";
                    CncState_Info.CncAlarmState = "连接错误";
                }


                Focas1.ODBSEQ seq = new Focas1.ODBSEQ();
                var ret_seq =Focas1.cnc_rdseqnum(m_static_flib, seq);
                if (ret_seq == 0)
                {
                    CncState_Info.BlockNum = "" + seq.data.ToString("00000000");
                }
                else
                {
                    CncState_Info.BlockNum = "---------";
                }

                StringBuilder str = new StringBuilder();
                var ret_pn = Focas1.cnc_pdf_rdmain(m_static_flib, str);
                if (ret_pn == 0)
                {
                    string[] sArray = str.ToString().Split('/');
                    CncState_Info.ProgramNum = sArray[sArray.Count() - 1];
                }
                else
                {
                    CncState_Info.ProgramNum = "连接错误";
                }

                Focas1.IODBPSD psd6757 = new Focas1.IODBPSD();
                var ret_6757 = Focas1.cnc_rdparam(m_static_flib, 6757, -1, 8, psd6757);
                Focas1.IODBPSD psd6758 = new Focas1.IODBPSD();
                var ret_6758 = Focas1.cnc_rdparam(m_static_flib, 6758, -1, 8, psd6758);
                if (ret_6757 == 0 && ret_6758 == 0)
                {
                    var time = psd6757.u.ldata / 1000 + psd6758.u.ldata * 60;
                    CncState_Info.CycleTime = (time / 3600).ToString() + @"H " + ((time % 3600) / 60).ToString() + @"M " + (((time % 3600) % 60) % 60).ToString() + @"S ";
                }
                else
                {
                    CncState_Info.CycleTime = "--H --M --S";
                }

                //读取报警信息
                Focas1.ODBALMMSG2 almmsg = new Focas1.ODBALMMSG2();
                short alarm_num = 10;
                var ret_alm = Focas1.cnc_rdalmmsg2(m_static_flib, -1, ref alarm_num, almmsg);
                if (ret_alm == 0)
                {
                    CncState_Info.CncAlarmList.Clear();
                    for (int i = 0; i < alarm_num; i++)
                    {
                        string strdata = "msg" + (i + 1).ToString();
                        object alm = almmsg.GetType().GetField(strdata).GetValue(almmsg);

                        int alm_no = int.Parse(alm.GetType().GetField("alm_no").GetValue(alm).ToString());
                        short type = short.Parse(alm.GetType().GetField("type").GetValue(alm).ToString());
                        short axis = short.Parse(alm.GetType().GetField("axis").GetValue(alm).ToString());
                        string alm_msg = alm.GetType().GetField("alm_msg").GetValue(alm).ToString();

                        alm_msg = alm_msg.Replace("\n", "");

                        CncState_Info.CncAlarmList.Add(new CncAlarm { Alm_No = alm_no, Type = type, Axis = axis, Alm_Msg = alm_msg });
                    }
                }
                else
                {
                    CncState_Info.CncAlarmList.Clear();
                }

                //读取操作信息
                Focas1.OPMSG3 opmsg = new Focas1.OPMSG3();
                short opmsg_num = 5;
                var ret_opmsg = Focas1.cnc_rdopmsg3(m_static_flib, -1, ref opmsg_num, opmsg);
                if (ret_opmsg == 0)
                {
                    if (opmsg_num != 0) CncState_Info.CncMessageFlag = 3;
                    else CncState_Info.CncMessageFlag = 1;

                    CncState_Info.CncMessageList.Clear();
                    for (int i = 0; i < opmsg_num; i++)
                    {
                        string strdata = "msg" + (i + 1).ToString();
                        object op = opmsg.GetType().GetField(strdata).GetValue(opmsg);

                        short op_no = short.Parse(op.GetType().GetField("datano").GetValue(op).ToString());
                        short op_type = short.Parse(op.GetType().GetField("type").GetValue(op).ToString());
                        string op_msg = op.GetType().GetField("data").GetValue(op).ToString();

                        if(op_no!=-1)
                        {
                            CncState_Info.CncMessageList.Add(new CncMessage { Msg_No = op_no, Type = op_type, Alm_Msg = op_msg });
                        }
                        
                    }
                }
                else
                {
                    CncState_Info.CncMessageFlag = 1;
                    CncState_Info.CncMessageList.Clear();
                }


                bool btemp = false;
                ReadPmcDataByBit_InTask(m_static_flib, m_laserstart_AdrType, m_laserstart_Adr, m_laserstart_AdrBit, ref btemp);
                CncState_Info.LaserStartStatus = btemp;
                ReadPmcDataByBit_InTask(m_static_flib, m_laseralarm_AdrType, m_laseralarm_Adr, m_laseralarm_AdrBit, ref btemp);
                CncState_Info.LaserAlarmStatus = btemp;

                Messenger.Default.Send<CncStateInfo>(CncState_Info, "CncStateMsg");

                //自动寻边
                if (m_autofindside_flag == true)
                {
                    double xd = 0;
                    var ret_xd = ReadMacroData(m_macro_autofindside_xd, ref xd);
                    AutoFindSide_Info.XD = xd;

                    double yd = 0;
                    var ret_yd = ReadMacroData(m_macro_autofindside_yd, ref yd);
                    AutoFindSide_Info.YD = yd;

                    double sita = 0;
                    var ret_sita = ReadMacroData(m_macro_autofindside_sita, ref sita);
                    AutoFindSide_Info.SITA = sita;

                    Messenger.Default.Send<AutoFindSideInfo>(AutoFindSide_Info, "AutoFindSideInfoMsg");
                }

                if (m_manualfindside_flag == true)
                {
                    double xd = 0;
                    var ret_xd = ReadMacroData(m_macro_autofindside_xd, ref xd);
                    ManualFindSide_Info.XD = xd;

                    double yd = 0;
                    var ret_yd = ReadMacroData(m_macro_autofindside_yd, ref yd);
                    ManualFindSide_Info.YD = yd;

                    double sita = 0;
                    var ret_sita = ReadMacroData(823, ref sita);
                    ManualFindSide_Info.SITA = sita;

                    Messenger.Default.Send<ManualFindSideInfo>(ManualFindSide_Info, "ManualFindSideInfoMsg");
                }

                //诊断
                if (m_diagnose_flag==true)
                {
                    Focas1.IODBMR buf_diagnose = new Focas1.IODBMR();

                    ret = Focas1.cnc_rdmacror(m_static_flib, 6041, 6043, 32, buf_diagnose);
                    if (ret == 0)
                    {
                        Diagnose_Info.DIAGNOSE_VALUE_PC = buf_diagnose.data.data1.mcr_val * Math.Pow(10, -buf_diagnose.data.data1.dec_val);
                        Diagnose_Info.DIAGNOSE_VALUE_FR = buf_diagnose.data.data2.mcr_val * Math.Pow(10, -buf_diagnose.data.data1.dec_val);
                        Diagnose_Info.DIAGNOSE_VALUE_DU = buf_diagnose.data.data3.mcr_val * Math.Pow(10, -buf_diagnose.data.data1.dec_val);
                    }

                    byte pmc_buf_diagnose_data = 0;
                    ret = ReadPmcDataByByte_InTask(m_static_flib, 0, 223, ref pmc_buf_diagnose_data);
                    if (ret == 0)
                    {
                        Diagnose_Info.DIAGNOSE_PERCENT_PC = pmc_buf_diagnose_data;
                    }

                    ret = ReadPmcDataByByte_InTask(m_static_flib, 0, 228, ref pmc_buf_diagnose_data);
                    if (ret == 0)
                    {
                        Diagnose_Info.DIAGNOSE_PERCENT_FR = pmc_buf_diagnose_data;
                    }

                    ret = ReadPmcDataByByte_InTask(m_static_flib, 0, 493, ref pmc_buf_diagnose_data);
                    if (ret == 0)
                    {
                        Diagnose_Info.DIAGNOSE_PERCENT_DU = pmc_buf_diagnose_data;
                    }

                    //TODO:冷却水诊断
                    Diagnose_Info.DIAGNOSE_REFLECTEDLIGHT = 46.5;
                    Diagnose_Info.DIAGNOSE_COOLWATER_FLUX_PATH1 = 60.1;
                    Diagnose_Info.DIAGNOSE_COOLWATER_FLUX_PATH2 = 59.5;
                    Diagnose_Info.DIAGNOSE_COOLWATER_TEMP = 60.0;
                    Diagnose_Info.DIAGNOSE_FOGGING_TEMP = 80.0;
                    Diagnose_Info.DIAGNOSE_LASER_HUMIDITY = 99.1;
                    Diagnose_Info.DIAGNOSE_LASER_TEMP = 103.2;


                    Messenger.Default.Send<DiagnoseInfo>(Diagnose_Info, "DiagnoseInfoMsg");
                }

                //新增主面板IO显示
                ReadPmcDataByBit_InTask(m_static_flib, 5, 38, 0, ref btemp);
                CncState_Info.WorkMode_Laser = btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 5, 38, 1, ref btemp);
                CncState_Info.WorkMode_Punch = btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 1, 221, 3, ref btemp);
                CncState_Info.LaserState_LaserOK = btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 1, 490, 5, ref btemp);
                CncState_Info.LaserState_MicroPower = btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 5, 35, 4, ref btemp);
                CncState_Info.PuhchState_Single = btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 5, 35, 5, ref btemp);
                CncState_Info.PuhchState_Roll = btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 5, 35, 6, ref btemp);
                CncState_Info.PuhchState_Mark = btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 5, 35, 7, ref btemp);
                CncState_Info.PuhchState_Double = btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 5, 36, 0, ref btemp);
                CncState_Info.PuhchPos_Unknow = btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 5, 36, 1, ref btemp);
                CncState_Info.PuhchPos_Change = btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 5, 36, 2, ref btemp);
                CncState_Info.PuhchPos_UDC = btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 5, 36, 3, ref btemp);
                CncState_Info.PuhchPos_DDC = btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 1, 94, 0, ref btemp);
                CncState_Info.REF_X = btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 1, 94, 1, ref btemp);
                CncState_Info.REF_Y = btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 1, 94, 3, ref btemp);
                CncState_Info.REF_T = btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 1, 94, 4, ref btemp);
                CncState_Info.REF_C = btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 1, 94, 7, ref btemp);
                CncState_Info.REF_Z = btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 1, 94, 5, ref btemp);
                CncState_Info.REF_A= btemp;

                ReadPmcDataByBit_InTask(m_static_flib, 1, 94, 6, ref btemp);
                CncState_Info.REF_B = btemp;

                //自动下发
                bool autoT = false;
                ReadPmcDataByBit_InTask(m_static_flib, autoLoad_TriggerType, autoLoad_TriggerAdr, autoLoad_TriggerBit, ref autoT);
                if(autoT==true )
                {
                    WritePmcDataByBit_InTask(m_static_flib, autoLoad_TriggerType, autoLoad_TriggerAdr, autoLoad_TriggerBit, false);

                    Task.Factory.StartNew(() =>
                    {
                        lock (autoK)
                        {
                            var ret_load = false;

                            //获得材料类型/厚度/气体种类
                            ushort task_flib = 0;
                            var ret_task = BuildConnect(ref task_flib);
                            if(ret_task != 0)
                            {
                                WritePmcDataByBit(autoLoad_ErrorType, autoLoad_ErrorAdr, autoLoad_ErrorBit, true);
                                Messenger.Default.Send<string>("自动加载工艺参数失败(连接失败)", "OperateNotice");
                            }

                            string materialType = "";
                            double materialTypeCode = 0;
                            bool mtFlag = false;
                            ret_task = ReadMacroData_InTask(task_flib, 6, ref materialTypeCode);

                            ////0826测试
                            //materialTypeCode = 0;
                            if (ret_task != 0)
                            {
                                WritePmcDataByBit(autoLoad_ErrorType, autoLoad_ErrorAdr, autoLoad_ErrorBit, true);
                                Messenger.Default.Send<string>("自动加载工艺参数失败(材料类型错误)", "OperateNotice");
                            }
                            else
                            {
                                var iMTC = (int)materialTypeCode;
                                var mc = materialCodes.Where(x => x.Code == iMTC).FirstOrDefault();
                                if(mc!=null)
                                {
                                    materialType = mc.Material;
                                    mtFlag = true;
                                }
                                else
                                {
                                    WritePmcDataByBit(autoLoad_ErrorType, autoLoad_ErrorAdr, autoLoad_ErrorBit, true);
                                    Messenger.Default.Send<string>("自动加载工艺参数失败(材料类型错误)", "OperateNotice");
                                }

                            }

                            double materialThickness = 0;
                            bool mttFlag = false;
                            ret_task = ReadMacroData_InTask(task_flib, 20, ref materialThickness);
                            ////0826测试
                            //materialThickness = 1.5;

                            if (ret_task != 0)
                            {
                                WritePmcDataByBit(autoLoad_ErrorType, autoLoad_ErrorAdr, autoLoad_ErrorBit, true);
                                Messenger.Default.Send<string>("自动加载工艺参数失败(材料厚度错误)", "OperateNotice");
                            }
                            else
                            {
                                mttFlag = true;
                            }

                            double cutterdiameter = 0;
                            bool cdFlag = false;
                            ret_task = ReadMacroData_InTask(task_flib, 7, ref cutterdiameter);
                            ////0826测试
                            //cutterdiameter = 2;

                            if (ret_task != 0)
                            {
                                WritePmcDataByBit(autoLoad_ErrorType, autoLoad_ErrorAdr, autoLoad_ErrorBit, true);
                                Messenger.Default.Send<string>("自动加载工艺参数失败(割嘴类型错误)", "OperateNotice");
                            }
                            else
                            {
                                cdFlag = true;
                            }

                            short g_kind = 0;
                            double g_kindCode = 0;
                            bool gkFlag = false;
                            ret_task = ReadMacroData_InTask(task_flib, 17, ref g_kindCode);
                            ////0826测试
                            //g_kindCode = 2;

                            if (ret_task != 0)
                            {
                                WritePmcDataByBit(autoLoad_ErrorType, autoLoad_ErrorAdr, autoLoad_ErrorBit, true);
                                Messenger.Default.Send<string>("自动加载工艺参数失败(气体类型错误)", "OperateNotice");
                            }
                            else
                            {
                                g_kind = (short)g_kindCode;
                                gkFlag = true;
                            }

                            if (mtFlag == true && mttFlag == true && cdFlag == true && gkFlag == true)
                            {
                                var srv = MachiningLibService.CreateInstance();
                                var cutting = srv.GetMachiningLibCuttingRecords(materialType, materialThickness, cutterdiameter, g_kind);
                                var ecutting = srv.GetMachiningLibEdgeCuttingRecords(materialType, materialThickness, cutterdiameter, g_kind);
                                var piercing = srv.GetMachiningLibPiercingRecords(materialType, materialThickness, cutterdiameter, g_kind);
                                var scontrol = srv.GetMachiningLibSlopeControlRecords(materialType, materialThickness, cutterdiameter, g_kind);

                                if (cutting.Count != 0 && ecutting.Count != 0 && piercing.Count != 0 && scontrol.Count != 0)
                                {
                                    var send_msg = SendMachiningLibToCnc_InTask(task_flib, cutting, ecutting, piercing, scontrol);
                                    if(send_msg!=null)
                                    {
                                        WritePmcDataByBit(autoLoad_ErrorType, autoLoad_ErrorAdr, autoLoad_ErrorBit, true);
                                        Messenger.Default.Send<string>(send_msg, "OperateNotice");
                                    }
                                    else
                                    {
                                        WritePmcDataByBit(autoLoad_FinType, autoLoad_FinAdr, autoLoad_FinBit, true);
                                        Messenger.Default.Send<string>("自动加载工艺库数据成功", "OperateNotice");
                                    }

                                }
                                else if(cutting.Count==0)
                                {
                                    WritePmcDataByBit(autoLoad_ErrorType, autoLoad_ErrorAdr, autoLoad_ErrorBit, true);
                                    Messenger.Default.Send<string>("自动加载工艺参数失败:没有检索到材料(切割)", "OperateNotice");
                                }
                                else if (ecutting.Count == 0)
                                {
                                    WritePmcDataByBit(autoLoad_ErrorType, autoLoad_ErrorAdr, autoLoad_ErrorBit, true);
                                    Messenger.Default.Send<string>("自动加载工艺参数失败:没有检索到材料(尖角)", "OperateNotice");
                                }
                                else if (piercing.Count == 0)
                                {
                                    WritePmcDataByBit(autoLoad_ErrorType, autoLoad_ErrorAdr, autoLoad_ErrorBit, true);
                                    Messenger.Default.Send<string>("自动加载工艺参数失败:没有检索到材料(穿孔)", "OperateNotice");
                                }
                                else
                                {
                                    WritePmcDataByBit(autoLoad_ErrorType, autoLoad_ErrorAdr, autoLoad_ErrorBit, true);
                                    Messenger.Default.Send<string>("自动加载工艺参数失败:没有检索到材料(功率控制)", "OperateNotice");
                                }
                            }

                            FreeConnect(task_flib);
                        }
                    });
                }

                //心跳
                bool heartbeat = false;
                ReadPmcDataByBit_InTask(m_static_flib, 12, 1040, 0, ref heartbeat);

                if(heartbeat==true)
                    WritePmcDataByBit_InTask(m_static_flib, 12, 1040, 0, false);
                else
                    WritePmcDataByBit_InTask(m_static_flib, 12, 1040, 0, true);


            }

            FreeConnect(m_static_flib);
        }

        public void ScannerStatic_Start()
        {
            //TODO:NO CNC
            if (m_simulate == false) m_static_BackgroundWorker.RunWorkerAsync();
        }

        public void ScannerStatic_Cancel()
        {
            m_static_BackgroundWorker.CancelAsync();
        }

        private void ScannerStatic_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FreeConnect(m_static_flib);
            m_static_flib = 0;
        }

        #endregion

        #region mop
        private void ScannerMop_BK(object sender, DoWorkEventArgs e)
        {
            short ret = -16;
            SiemensS200Smart s200 = new SiemensS200Smart("192.168.2.1", 102, 0);

            while (m_mop_BackgroundWorker.CancellationPending == false)
            {
                Thread.Sleep(m_mop_freq);

                if(ret!=0)
                {
                     ret = BuildConnect(ref m_mop_flib);
                }

                bool temp = false;
                ReadPmcDataByBit_InTask(m_mop_flib, 1, 3, 5, ref temp);
                MopKeySatus.Mop_Auto_Status = temp;
                ReadPmcDataByBit_InTask(m_mop_flib, 1, 3, 6, ref temp);
                MopKeySatus.Mop_Edit_Status = temp;
                ReadPmcDataByBit_InTask(m_mop_flib, 1, 3, 3, ref temp);
                MopKeySatus.Mop_Mdi_Status = temp;
                ReadPmcDataByBit_InTask(m_mop_flib, 1, 3, 4, ref temp);
                MopKeySatus.Mop_Rmt_Status = temp;
                ReadPmcDataByBit_InTask(m_mop_flib, 1, 4, 5, ref temp);
                MopKeySatus.Mop_Rtn_Status = temp;
                ReadPmcDataByBit_InTask(m_mop_flib, 1, 3, 2, ref temp);
                MopKeySatus.Mop_Jog_Status = temp;
                ReadPmcDataByBit_InTask(m_mop_flib, 1, 3, 1, ref temp);
                MopKeySatus.Mop_Handle_Status = temp;
                ReadPmcDataByBit_InTask(m_mop_flib, 5, 31, 6, ref temp);
                MopKeySatus.Mop_Step_Status = temp ;
                ReadPmcDataByBit_InTask(m_mop_flib, 5, 31, 7, ref temp);
                MopKeySatus.Mop_Skip_Status = temp;
                ReadPmcDataByBit_InTask(m_mop_flib, 5, 32, 1, ref temp);
                MopKeySatus.Mop_Opt_Status = temp;
                ReadPmcDataByBit_InTask(m_mop_flib, 5, 32, 2, ref temp);
                MopKeySatus.Mop_Dry_Status = temp;

                ReadPmcDataByBit_InTask(m_mop_flib, 5, 34, 4, ref temp);
                MopKeySatus.Mop_PiercingDelay_Status = temp;
                ReadPmcDataByBit_InTask(m_mop_flib, 5, 34, 7, ref temp);
                MopKeySatus.Mop_PiercingShorten_Status = temp;
                ReadPmcDataByBit_InTask(m_mop_flib, 5, 32, 3, ref temp);
                MopKeySatus.Mop_DustClear_Status = temp;
                ReadPmcDataByBit_InTask(m_mop_flib, 5, 32, 4, ref temp);
                MopKeySatus.Mop_LampOn_Status = temp;

                var mv = false;
                var mvd = false;
                ReadPmcDataByBit_InTask(m_mop_flib, 1, 102, 0, ref mv);
                ReadPmcDataByBit_InTask(m_mop_flib, 1, 106, 0, ref mvd);
                if(mv==true&& mvd==true)
                {
                    MopKeySatus.XMINUS = true;
                    MopKeySatus.XPLUS = false;
                }
                else if (mv == true && mvd == false)
                {
                    MopKeySatus.XPLUS = true;
                    MopKeySatus.XMINUS = false;
                }
                else
                {
                    MopKeySatus.XPLUS = false;
                    MopKeySatus.XMINUS = false;
                }

                ReadPmcDataByBit_InTask(m_mop_flib, 1, 102, 1, ref mv);
                ReadPmcDataByBit_InTask(m_mop_flib, 1, 106, 1, ref mvd);
                if (mv == true && mvd == true)
                {
                    MopKeySatus.YMINUS = true;
                    MopKeySatus.YPLUS = false;
                }
                else if(mv == true && mvd == false)
                {
                    MopKeySatus.YPLUS = true;
                    MopKeySatus.YMINUS = false;
                }
                else
                {
                    MopKeySatus.YPLUS = false;
                    MopKeySatus.YMINUS = false;
                }

                //xyytcabz
                ReadPmcDataByBit_InTask(m_mop_flib, 1, 102, 7, ref mv);
                ReadPmcDataByBit_InTask(m_mop_flib, 1, 106, 7, ref mvd);
                if (mv == true && mvd == true)
                {
                    MopKeySatus.ZMINUS = true;
                    MopKeySatus.ZPLUS = false;
                }
                else if (mv == true && mvd == false)
                {
                    MopKeySatus.ZPLUS = true;
                    MopKeySatus.ZMINUS = false;
                }
                else
                {
                    MopKeySatus.ZPLUS = false;
                    MopKeySatus.ZMINUS = false;
                }

                ReadPmcDataByBit_InTask(m_mop_flib, 1, 102, 6, ref mv);
                ReadPmcDataByBit_InTask(m_mop_flib, 1, 106, 6, ref mvd);
                if (mv == true && mvd == true)
                {
                    MopKeySatus.BMINUS = true;
                    MopKeySatus.BPLUS = false;
                }
                else if(mv == true && mvd == false)
                {
                    MopKeySatus.BPLUS = true;
                    MopKeySatus.BMINUS = false;
                }
                else
                {
                    MopKeySatus.BPLUS = false;
                    MopKeySatus.BMINUS = false;
                }


                float plc = 0;
                var ret_plc = s200.ReadData("V", 0, ref plc);
                if(ret_plc==true)MopKeySatus.AirPressure = Math.Round(plc,2);

                ret_plc = s200.ReadData("V", 10, ref plc);
                if (ret_plc == true) MopKeySatus.NAirPressure = Math.Round(plc, 2);

                ret_plc = s200.ReadData("V", 20, ref plc);
                if (ret_plc == true) MopKeySatus.OAirPressure = Math.Round(plc, 2);

                ret_plc = s200.ReadData("V", 50, ref plc);
                if (ret_plc == true) MopKeySatus.FocusPosition = Math.Round(plc, 2);

                ret_plc = s200.ReadData("V", 30, ref plc);
                if (ret_plc == true) MopKeySatus.CutPressureSet = Math.Round(plc, 2);

                ret_plc = s200.ReadData("V", 40, ref plc);
                if (ret_plc == true) MopKeySatus.CutPressureActual = Math.Round(plc, 2);

                bool air = false;
                ReadPmcDataByBit_InTask(m_mop_flib, 2, 41, 3, ref air);
                MopKeySatus.GAS_A = air;
                ReadPmcDataByBit_InTask(m_mop_flib, 2, 41, 4, ref air);
                MopKeySatus.GAS_N = air;
                ReadPmcDataByBit_InTask(m_mop_flib, 2, 41, 5, ref air);
                MopKeySatus.GAS_O = air;


                Messenger.Default.Send<MopKeyStatus>(MopKeySatus, "MopKeyStatusMsg");
            }

            FreeConnect(m_mop_flib);
        }

        public void ScannerMop_Start()
        {
            //TODO:NO CNC
            if (m_simulate == false) m_mop_BackgroundWorker.RunWorkerAsync();
        }

        public void ScannerMop_Cancel()
        {
            m_mop_BackgroundWorker.CancelAsync();
        }

        private void ScannerMop_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FreeConnect(m_mop_flib);
            m_mop_flib = 0;
        }

        #endregion

        #region 诊断
        private void ScannerDiagnose_BK(object sender, DoWorkEventArgs e)
        {
            short ret = -16;

            while (m_diagnose_BackgroundWorker.CancellationPending == false)
            {
                Thread.Sleep(m_diagnose_freq);

                if (ret != 0)
                {
                    ret = BuildConnect(ref m_diagnose_flib);
                }

                Focas1.IODBMR buf = new Focas1.IODBMR();

                ret = Focas1.cnc_rdmacror(m_diagnose_flib, 6041, 6043, 32, buf);
                if(ret==0)
                {
                    Diagnose_Info.DIAGNOSE_VALUE_PC = buf.data.data1.mcr_val * Math.Pow(10, -buf.data.data1.dec_val);
                    Diagnose_Info.DIAGNOSE_VALUE_FR = buf.data.data2.mcr_val * Math.Pow(10, -buf.data.data1.dec_val);
                    Diagnose_Info.DIAGNOSE_VALUE_DU = buf.data.data3.mcr_val * Math.Pow(10, -buf.data.data1.dec_val);
                }

                byte pmc_data=0;
                ret = ReadPmcDataByByte_InTask(m_diagnose_flib, 0, 223, ref pmc_data);
                if(ret==0)
                {
                    Diagnose_Info.DIAGNOSE_PERCENT_PC = pmc_data;
                }

                ret = ReadPmcDataByByte_InTask(m_diagnose_flib, 0, 228, ref pmc_data);
                if (ret == 0)
                {
                    Diagnose_Info.DIAGNOSE_PERCENT_FR = pmc_data;
                }

                ret = ReadPmcDataByByte_InTask(m_diagnose_flib, 0, 493, ref pmc_data);
                if (ret == 0)
                {
                    Diagnose_Info.DIAGNOSE_PERCENT_DU = pmc_data;
                }

                //TODO:冷却水诊断
                Diagnose_Info.DIAGNOSE_REFLECTEDLIGHT = 46.5;
                Diagnose_Info.DIAGNOSE_COOLWATER_FLUX_PATH1 = 60.1;
                Diagnose_Info.DIAGNOSE_COOLWATER_FLUX_PATH2 = 59.5;
                Diagnose_Info.DIAGNOSE_COOLWATER_TEMP = 60.0;
                Diagnose_Info.DIAGNOSE_FOGGING_TEMP = 80.0;
                Diagnose_Info.DIAGNOSE_LASER_HUMIDITY = 99.1;
                Diagnose_Info.DIAGNOSE_LASER_TEMP = 103.2;


                Messenger.Default.Send<DiagnoseInfo>(Diagnose_Info, "DiagnoseInfoMsg");


            }

            FreeConnect(m_diagnose_flib);
        }

        public void ScannerDiagnose_Start()
        {
            //TODO:NO CNC
            //if (m_simulate == false) m_diagnose_BackgroundWorker.RunWorkerAsync();
            if (m_simulate == false) m_diagnose_flag = true;
        }

        public void ScannerDiagnose_Cancel()
        {
            //m_diagnose_BackgroundWorker.CancelAsync();
            m_diagnose_flag = false;
        }

        private void ScannerDiagnose_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FreeConnect(m_diagnose_flib);
            m_diagnose_flib = 0;
        }

        #endregion

        #region 诊断 实际功率输出
        private void ScannerDiagnose_Top_BK(object sender, DoWorkEventArgs e)
        {
            short ret = -16;

            
            while (m_diagnose_top_BackgroundWorker.CancellationPending == false)
            {
                Thread.Sleep(m_diagnose_top_freq);

                if (ret != 0)
                {
                    ret = BuildConnect(ref m_diagnose_top_flib);
                }


                Messenger.Default.Send<double>(100, "RealOutputPower_Data");
            }


            FreeConnect(m_diagnose_top_flib);
        }

        public void ScannerDiagnose_Top_Start()
        {
            //TODO:NO CNC
            //if (m_simulate == false) m_diagnose_top_BackgroundWorker.RunWorkerAsync();
        }

        public void ScannerDiagnose_Top_Cancel()
        {
            m_diagnose_top_BackgroundWorker.CancelAsync();
        }

        private void ScannerDiagnose_Top_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FreeConnect(m_diagnose_top_flib);
            m_diagnose_top_flib = 0;
        }

        #endregion

        #region 轨迹仿真状态
        private void ScannerSimulation_BK(object sender, DoWorkEventArgs e)
        {
            short ret = -16;

            while (m_simulation_BackgroundWorker.CancellationPending == false)
            {
                Thread.Sleep(m_simulation_freq);

                if (ret != 0)
                {
                    ret = BuildConnect(ref m_simulation_flib);
                }

                Focas1.IODBMR buf = new Focas1.IODBMR();

                ret = Focas1.cnc_rdmacror(m_simulation_flib, 6200, 6202, 32, buf);
                if (ret == 0)
                {
                    Simulation_Info.SIMULATION_STATUS_PC = buf.data.data1.mcr_val * Math.Pow(10, -buf.data.data1.dec_val);
                    Simulation_Info.SIMULATION_STATUS_FR = buf.data.data2.mcr_val * Math.Pow(10, -buf.data.data1.dec_val);
                    Simulation_Info.SIMULATION_STATUS_DU = buf.data.data3.mcr_val * Math.Pow(10, -buf.data.data1.dec_val);
                }

                ret = Focas1.cnc_rdmacror(m_simulation_flib, 6030, 6031, 24, buf);
                if (ret == 0)
                {
                    Simulation_Info.SIMULATION_STATUS_E0XX = buf.data.data1.mcr_val * Math.Pow(10, -buf.data.data1.dec_val);
                    Simulation_Info.SIMULATION_STATUS_E10X = buf.data.data2.mcr_val * Math.Pow(10, -buf.data.data1.dec_val);
                }

                Focas1.ODBM sbuf = new Focas1.ODBM();
                ret = Focas1.cnc_rdmacro(m_simulation_flib, 6030, 10, sbuf);
                if (ret == 0)
                {
                    Simulation_Info.SIMULATION_STATUS_PA = sbuf.mcr_val * Math.Pow(10, -sbuf.dec_val);
                }

                bool data=false;
                ret = ReadPmcDataByBit_InTask(m_simulation_flib, 1, 490, 5, ref data);
                if (ret == 0)
                {
                    Simulation_Info.SIMULATION_STATUS_NANOPC = data;
                }

                ret = ReadPmcDataByBit_InTask(m_simulation_flib, 1, 224, 1, ref data);
                if (ret == 0)
                {
                    Simulation_Info.SIMULATION_STATUS_POWERCONTROL = data;
                }

                ret = ReadPmcDataByBit_InTask(m_simulation_flib, 1, 223, 6, ref data);
                if (ret == 0)
                {
                    Simulation_Info.SIMULATION_STATUS_EDGECUTTING = data;
                }

                Messenger.Default.Send<SimulationInfo>(Simulation_Info, "SimulationInfoMsg");


            }

            FreeConnect(m_simulation_flib);
        }

        public void ScannerSimulation_Start()
        {
            //TODO:NO CNC
            //if (m_simulate == false) m_simulation_BackgroundWorker.RunWorkerAsync();
        }

        public void ScannerSimulation_Cancel()
        {
            m_simulation_BackgroundWorker.CancelAsync();
        }

        private void ScannerSimulation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FreeConnect(m_simulation_flib);
            m_simulation_flib = 0;
        }

        #endregion

        #region 工作台状态
        private void ScannerWorkStation_BK(object sender, DoWorkEventArgs e)
        {
            short ret = -16;

            while (m_workstation_BackgroundWorker.CancellationPending == false)
            {
                Thread.Sleep(m_workstation_freq);

                if (ret != 0)
                {
                    ret = BuildConnect(ref m_workstation_flib);
                }

                bool res = false;
                ret=ReadPmcDataByBit_InTask(m_workstation_flib, m_workstation_state_mainup_AdrType, m_workstation_state_mainup_Adr, m_workstation_state_mainup_AdrBit,ref res);
                WorkStation_Info.MainWorkStationUp = res;
                res = false;
                ret = ReadPmcDataByBit_InTask(m_workstation_flib, m_workstation_state_maindown_AdrType, m_workstation_state_maindown_Adr, m_workstation_state_maindown_AdrBit, ref res);
                WorkStation_Info.MainWorkStationDown = res;
                res = false;
                ret = ReadPmcDataByBit_InTask(m_workstation_flib, m_workstation_state_mainleft_AdrType, m_workstation_state_mainleft_Adr, m_workstation_state_mainleft_AdrBit, ref res);
                WorkStation_Info.MainWorkStationLeft = res;
                res = false;
                ret = ReadPmcDataByBit_InTask(m_workstation_flib, m_workstation_state_mainright_AdrType, m_workstation_state_mainright_Adr, m_workstation_state_mainright_AdrBit, ref res);
                WorkStation_Info.MainWorkStationRight = res;

                res = false;
                ret = ReadPmcDataByBit_InTask(m_workstation_flib, m_workstation_state_subup_AdrType, m_workstation_state_subup_Adr, m_workstation_state_subup_AdrBit, ref res);
                WorkStation_Info.SubWorkStationUp = res;
                res = false;
                ret = ReadPmcDataByBit_InTask(m_workstation_flib, m_workstation_state_subdown_AdrType, m_workstation_state_subdown_Adr, m_workstation_state_subdown_AdrBit, ref res);
                WorkStation_Info.SubWorkStationDown = res;
                res = false;
                ret = ReadPmcDataByBit_InTask(m_workstation_flib, m_workstation_state_subleft_AdrType, m_workstation_state_subleft_Adr, m_workstation_state_subleft_AdrBit, ref res);
                WorkStation_Info.SubWorkStationLeft = res;
                res = false;
                ret = ReadPmcDataByBit_InTask(m_workstation_flib, m_workstation_state_subright_AdrType, m_workstation_state_subright_Adr, m_workstation_state_subright_AdrBit, ref res);
                WorkStation_Info.SubWorkStationRight = res;

                Messenger.Default.Send<WorkStationInfo>(WorkStation_Info, "WorkStationInfoMsg");


            }

            FreeConnect(m_workstation_flib);
        }

        public void ScannerWorkStation_Start()
        {
            //TODO:NO CNC
            if (m_simulate == false) m_workstation_BackgroundWorker.RunWorkerAsync();
        }

        public void ScannerWorkStation_Cancel()
        {
            m_workstation_BackgroundWorker.CancelAsync();
        }

        private void ScannerWorkStation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FreeConnect(m_workstation_flib);
            m_workstation_flib = 0;
        }

        #endregion

        #region 自动寻边
        private void ScannerAutoFindSide_BK(object sender, DoWorkEventArgs e)
        {
            short ret = -16;

            while (m_autofindside_BackgroundWorker.CancellationPending == false)
            {
                Thread.Sleep(m_autofindside_freq);

                if (ret != 0)
                {
                    ret = BuildConnect(ref m_autofindside_flib);
                }

                double xd = 0;
                ret = ReadMacroData(m_macro_autofindside_xd, ref xd);
                AutoFindSide_Info.XD = xd;

                double yd = 0;
                ret = ReadMacroData(m_macro_autofindside_yd, ref yd);
                AutoFindSide_Info.YD = yd;

                double sita = 0;
                ret = ReadMacroData(m_macro_autofindside_sita, ref sita);
                AutoFindSide_Info.SITA = sita;



                Messenger.Default.Send<AutoFindSideInfo>(AutoFindSide_Info, "AutoFindSideInfoMsg");


            }

            FreeConnect(m_autofindside_flib);
        }

        public void ScannerAutoFindSide_Start()
        {
            //TODO:NO CNC
            //if (m_simulate == false) m_autofindside_BackgroundWorker.RunWorkerAsync();

            if (m_simulate == false) m_autofindside_flag = true;
        }

        public void ScannerAutoFindSide_Cancel()
        {
            //m_autofindside_BackgroundWorker.CancelAsync();
            m_autofindside_flag = false;
        }

        private void ScannerAutoFindSide_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //FreeConnect(m_autofindside_flib);
            //m_autofindside_flib = 0;
        }

        #endregion

        #region 手动寻边
        public void ScannerManualFindSide_Start()
        {
            //TODO:NO CNC
            //if (m_simulate == false) m_autofindside_BackgroundWorker.RunWorkerAsync();

            if (m_simulate == false) m_manualfindside_flag = true;
        }

        public void ScannerManualFindSide_Cancel()
        {
            //m_autofindside_BackgroundWorker.CancelAsync();
            m_manualfindside_flag = false;
        }
        #endregion
        #endregion

        #region 公共函数
        private short BuildConnect(ref ushort flib)
        {
            short ret = 0;
            Focas1.cnc_freelibhndl(flib);

            if (m_simulate == false) ret = Focas1.cnc_allclibhndl3(m_ip, m_port, m_timeout, out flib);

            return ret;
        }

        private short FreeConnect(ushort flib)
        {
            short ret = Focas1.cnc_freelibhndl(flib);
            return ret;
        }

        private short WritePmcDataByBit(short type, ushort adr, ushort bit, bool data)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            Focas1.IODBPMC0 buf = new Focas1.IODBPMC0();
            buf.cdata = new byte[1];
            ret = Focas1.pmc_rdpmcrng(flib, type, 0, adr, adr, 9, buf);
            if (ret != 0) return ret;

            byte bd = (byte)(0x01 << bit);
            if (data == true)
            {
                buf.cdata[0] = (byte)(buf.cdata[0] | bd);
            }
            else
            {
                buf.cdata[0] = (byte)(buf.cdata[0] & (~bd));
            }

            ret = Focas1.pmc_wrpmcrng(flib, 9, buf);
            if (ret != 0) return ret;


            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;
        }

        private short WritePmcDataByByte(short type, ushort adr, byte data)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            Focas1.IODBPMC0 buf = new Focas1.IODBPMC0();
            buf.cdata = new byte[12];
            buf.cdata[0] = data;
            buf.datano_s = (short)adr;
            buf.datano_e = (short)adr;
            buf.type_a = type;
            buf.type_d = 0;
            ret = Focas1.pmc_wrpmcrng(flib, 9, buf);

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;
        }

        private short WritePmcDataByWord(short type, ushort adr, short data)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            Focas1.IODBPMC1 buf = new Focas1.IODBPMC1();
            buf.idata = new short[5];
            buf.idata[0] = data;
            buf.datano_s = (short)adr;
            buf.datano_e = (short)adr;
            buf.type_a = type;
            buf.type_d = 1;
            ret = Focas1.pmc_wrpmcrng(flib, 10, buf);

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;
        }

        private short WriteMacroData(short mac_num, int mcr_val, short dec_val)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            ret = Focas1.cnc_wrmacro(flib, mac_num, 10, mcr_val, dec_val);
            if (ret != 0) return ret;

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;
        }

        private short WriteMacroData_InTask(ushort flib, int mac_num, double data)
        {
            int num = 1;
            var ret = Focas1.cnc_wrmacror2(flib, mac_num, ref num, data);

            return 0;
        }

        private short ReadMacroData(short mac_num, ref double data)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            Focas1.ODBM buf = new Focas1.ODBM();

            ret = Focas1.cnc_rdmacro(flib, mac_num, 10, buf);
            if (ret != 0) return ret;
            int mcr = buf.mcr_val;
            short dec = buf.dec_val;
            dec = (short)(dec * (-1));
            data = (double)(mcr * Math.Pow(10, dec));

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;
        }

        private short ReadMacroData_InTask(ushort flib, short mac_num, ref double data)
        {
            Focas1.ODBM buf = new Focas1.ODBM();

            var ret = Focas1.cnc_rdmacro(flib, mac_num, 10, buf);
            if (ret != 0) return ret;
            int mcr = buf.mcr_val;
            short dec = buf.dec_val;
            dec = (short)(dec * (-1));
            data = (double)(mcr * Math.Pow(10, dec));

            return 0;
        }

        private short ReadPmcDataByByte_InTask(ushort flib, short type, ushort adr, ref byte data)
        {
            Focas1.IODBPMC0 buf = new Focas1.IODBPMC0();
            buf.cdata = new byte[1];
            short ret = Focas1.pmc_rdpmcrng(flib, type, 0, adr, adr, 9, buf);
            if (ret != 0) return ret;

            data = buf.cdata[0];

            return 0;
        }

        private short ReadPmcDataByWord_InTask(ushort flib, short type, ushort adr, ref short data)
        {
            Focas1.IODBPMC1 buf = new Focas1.IODBPMC1();
            buf.idata = new short[1];
            ushort adr_end = (ushort)(adr + 1);
            short ret = Focas1.pmc_rdpmcrng(flib, type, 0, adr, adr_end, 10, buf);
            if (ret != 0) return ret;

            data = buf.idata[0];

            return 0;
        }

        private short ReadPmcDataByBit_InTask(ushort flib, short type, ushort adr, ushort bit,ref bool data)
        {

            Focas1.IODBPMC0 buf = new Focas1.IODBPMC0();
            buf.cdata = new byte[1];
            short ret = Focas1.pmc_rdpmcrng(flib, type, 0, adr, adr, 9, buf);
            if (ret != 0) return ret;

            byte bd = (byte)(0x01 << bit);
            data = (buf.cdata[0] & bd) > 0;

            return 0;
        }

        private short WritePmcDataByBit_InTask(ushort flib,  short type, ushort adr, ushort bit, bool data)
        {

            Focas1.IODBPMC0 buf = new Focas1.IODBPMC0();
            buf.cdata = new byte[1];
            short ret = Focas1.pmc_rdpmcrng(flib, type, 0, adr, adr, 9, buf);
            if (ret != 0) return ret;

            byte bd = (byte)(0x01 << bit);
            if (data == true)
            {
                buf.cdata[0] = (byte)(buf.cdata[0] | bd);
            }
            else
            {
                buf.cdata[0] = (byte)(buf.cdata[0] & (~bd));
            }

            ret = Focas1.pmc_wrpmcrng(flib, 9, buf);
            if (ret != 0) return ret;

            return 0;
        }

        private short ReadMachinePosition(ref double xpos, ref double ypos, ref double zpos)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            Focas1.ODBAXIS buf = new Focas1.ODBAXIS();

            ret = Focas1.cnc_machine(flib, -1, 132, buf);
            if (ret != 0) return ret;

            xpos = (double)buf.data[0] / 1000.0;
            ypos = (double)buf.data[1] / 1000.0;
            zpos = (double)buf.data[2] / 1000.0;

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;
        }

        private short SelectMainProgram(string path)
        {
            ushort flib=0;
            short ret = BuildConnect(ref flib);
            if (ret != 0) return ret;

            ret = Focas1.cnc_pdf_slctmain(flib, path);

            ret = FreeConnect(flib);
            if (ret != 0) return ret;

            return 0;

        }

        private string SendMachiningLibToCnc_InTask(ushort flib, List<MachiningLib_Cutting> cuttings, List<MachiningLib_EdgeCutting> edgecuttings, 
            List<MachiningLib_Piercing> piercings, List<MachiningLib_SlopeControl> slopcontrols)
        {
            var ret_cutting = SendMachiningLibCuttingData_InTask(flib, cuttings);
            if (ret_cutting != null)
            {
                return "自动加载工艺参数失败(切割):" + ret_cutting;
            }
            else
            {
                var ret_ecutting = SendMachiningLibEdgeCutting_InTask(flib, edgecuttings);
                if (ret_ecutting != null)
                {
                    return "自动加载工艺参数失败(尖角):" + ret_ecutting;
                }
                else
                {
                    var ret_piercing = SendMachiningLibPiercing_InTask(flib, piercings);
                    if (ret_piercing != null)
                    {
                        return "自动加载工艺参数失败(穿孔):" + ret_piercing;
                    }
                    else
                    {
                        var ret_scontrol = SendMachiningLibSlopeControl_InTask(flib, slopcontrols);
                        if (ret_scontrol != null)
                        {
                            return "自动加载工艺参数失败(功率):" + ret_scontrol;
                        }
                    }
                }
            }

            return null;
        }

        #endregion
    }
}
