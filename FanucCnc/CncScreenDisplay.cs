using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using GalaSoft.MvvmLight.Messaging;
using ConfigCenter;

namespace FanucCnc
{

    public class CncScreenDisplay
    {
        private static CncScreenDisplay _instance = null;
        private string m_ip = "192.168.1.1";
        private ushort m_port = 8193;
        private string m_root = "C:";
        private string m_csdfolder = @"C:\Program Files (x86)\CNCScreenE";

        [DllImport("FanucCncScreenDisplay.dll")]
        public static extern void _CreateCncScreenDisplay(IntPtr hwnd, string ip,
            int xSrc, int ySrc, int xDest, int yDest, int nSrcWidth, int nSrcHeight, int nDestWidth, int nDestHeight);

        [DllImport("FanucCncScreenDisplay.dll")]
        public static extern void _StartRefresh();

        [DllImport("FanucCncScreenDisplay.dll")]
        public static extern void _StopRefresh();

        [DllImport("FanucCncScreenDisplay.dll")]
        public static extern void _SendKey(short state, short key);


        public CncScreenDisplay()
        {

            var cfg = new ConfigHelper();
            ushort timeout = 0;
            var ret = cfg.GetMachineInfo_Base(out m_ip,out m_port, out timeout);
            if (ret != 0) return;

            cfg.GetCsdInfo(out m_csdfolder);
            if (ret != 0) return;

            m_root = m_csdfolder.Substring(0, 2);


            this.ServerStop();

            System.Threading.Thread.Sleep(1000);

            this.ServerStart();
        }

        public static CncScreenDisplay CreateInstance()
        {
            if (_instance == null)

            {
                _instance = new CncScreenDisplay();
            }
            return _instance;
        }

        public void ServerStart()
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口
            p.Start();//启动程序

            //向cmd窗口发送输入信息
            var startcmd = @"#ROOT# && cd #CSDPATH# && CNCSCRNE /SERVER /H=#IP#:#PORT#";
            startcmd = startcmd.Replace("#ROOT#", m_root);
            startcmd = startcmd.Replace("#CSDPATH#", m_csdfolder);
            startcmd = startcmd.Replace("#IP#", m_ip);
            startcmd = startcmd.Replace("#PORT#", m_port.ToString());

            p.StandardInput.WriteLine(startcmd);

            p.StandardInput.AutoFlush = true;
            p.WaitForExit(1000);//等待程序执行完退出进程
            p.Close();

        }

        public void ServerStop()
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口
            p.Start();//启动程序

            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(@"taskkill /f /im cncscrne.exe");

            p.StandardInput.AutoFlush = true;
            p.WaitForExit(1000);//等待程序执行完退出进程
            p.Close();
        }

        public void CreateCncScreenDisplay(IntPtr hwnd)
        {
            try
            {
                _CreateCncScreenDisplay(hwnd, m_ip, 0, 0, -5, -32, 640, 480, 640, 480);

            }
            catch (Exception)
            {


            }
        }

        public void StartRefreshCncScreenDisplay()
        {
            try
            {
                _StartRefresh();
                Messenger.Default.Register<byte>(this, "CsdKeyMsg", OnKey);
                Messenger.Default.Register<string>(this, "CsdSoftKeyMsg", OnSoftKey);
                Messenger.Default.Register<string>(this, "CsdMenuKeyMsg", OnMenuKey);
            }
            catch { }
        }

        public void StopRefreshCncScreenDisplay()
        {
            try
            {
                _StopRefresh();
                Messenger.Default.Unregister<byte>(this, "CsdKeyMsg", OnKey);
                Messenger.Default.Unregister<string>(this, "CsdSoftKeyMsg", OnSoftKey);
                Messenger.Default.Unregister<string>(this, "CsdMenuKeyMsg", OnMenuKey);
            }
            catch { }
        }

        #region key
        public void OnKey(byte key)
        {
            switch (key)
            {

                #region KEY BOARD
                case 27://ESC
                    SendKey2CSD(1, 0x90);
                    SendKey2CSD(0, 0x90);
                    break;
                case 8://BACKSPACE
                    SendKey2CSD(1, 0x86);
                    SendKey2CSD(0, 0x86);
                    break;

                case 9://tab
                    SendKey2CSD(1, 0x09);
                    SendKey2CSD(0, 0x09);
                    break;

                case 13://tab
                    SendKey2CSD(1, 0x98);
                    SendKey2CSD(0, 0x98);
                    break;

                case 32://space
                    SendKey2CSD(1, 0x20);
                    SendKey2CSD(0, 0x20);
                    break;

                case 33://！
                    SendKey2CSD(1, 0x21);
                    SendKey2CSD(0, 0x21);
                    break;

                case 34://""
                    SendKey2CSD(1, 0x22);
                    SendKey2CSD(0, 0x22);
                    break;

                case 35://#
                    SendKey2CSD(1, 0x23);
                    SendKey2CSD(0, 0x23);
                    break;

                case 36://$
                    SendKey2CSD(1, 0x24);
                    SendKey2CSD(0, 0x24);
                    break;

                case 37://%
                    SendKey2CSD(1, 0x25);
                    SendKey2CSD(0, 0x25);
                    break;

                case 38://&
                    SendKey2CSD(1, 0x26);
                    SendKey2CSD(0, 0x26);
                    break;

                case 39://''
                    SendKey2CSD(1, 0x27);
                    SendKey2CSD(0, 0x27);
                    break;

                case 40://(
                    SendKey2CSD(1, 0x28);
                    SendKey2CSD(0, 0x28);
                    break;

                case 41://)
                    SendKey2CSD(1, 0x29);
                    SendKey2CSD(0, 0x29);
                    break;

                case 42://*
                    SendKey2CSD(1, 0x2A);
                    SendKey2CSD(0, 0x2A);
                    break;

                case 43://+
                    SendKey2CSD(1, 0x2B);
                    SendKey2CSD(0, 0x2B);
                    break;

                case 44://,
                    SendKey2CSD(1, 0x2C);
                    SendKey2CSD(0, 0x2C);
                    break;

                case 45://-
                    SendKey2CSD(1, 0x2D);
                    SendKey2CSD(0, 0x2D);
                    break;

                case 46://.
                    SendKey2CSD(1, 0x2E);
                    SendKey2CSD(0, 0x2E);
                    break;

                case 47:///
                    SendKey2CSD(1, 0x2F);
                    SendKey2CSD(0, 0x2F);
                    break;

                case 48://0
                    SendKey2CSD(1, 0x30);
                    SendKey2CSD(0, 0x30);
                    break;

                case 49://1
                    SendKey2CSD(1, 0x31);
                    SendKey2CSD(0, 0x31);
                    break;

                case 50://2
                    SendKey2CSD(1, 0x32);
                    SendKey2CSD(0, 0x32);
                    break;

                case 51://3
                    SendKey2CSD(1, 0x33);
                    SendKey2CSD(0, 0x33);
                    break;

                case 52://4
                    SendKey2CSD(1, 0x34);
                    SendKey2CSD(0, 0x34);
                    break;

                case 53://5
                    SendKey2CSD(1, 0x35);
                    SendKey2CSD(0, 0x35);
                    break;

                case 54://6
                    SendKey2CSD(1, 0x36);
                    SendKey2CSD(0, 0x36);
                    break;

                case 55://7
                    SendKey2CSD(1, 0x37);
                    SendKey2CSD(0, 0x37);
                    break;

                case 56://8
                    SendKey2CSD(1, 0x38);
                    SendKey2CSD(0, 0x38);
                    break;

                case 57://9
                    SendKey2CSD(1, 0x39);
                    SendKey2CSD(0, 0x39);
                    break;

                case 58://:
                    SendKey2CSD(1, 0x3A);
                    SendKey2CSD(0, 0x3A);
                    break;

                case 59://;
                    SendKey2CSD(1, 0x3B);
                    SendKey2CSD(0, 0x3B);
                    break;

                case 60://<
                    SendKey2CSD(1, 0x3C);
                    SendKey2CSD(0, 0x3C);
                    break;

                case 61://=
                    SendKey2CSD(1, 0x3D);
                    SendKey2CSD(0, 0x3D);
                    break;

                case 62://>
                    SendKey2CSD(1, 0x3E);
                    SendKey2CSD(0, 0x3E);
                    break;

                case 63://?
                    SendKey2CSD(1, 0x3F);
                    SendKey2CSD(0, 0x3F);
                    break;

                case 64://@
                    SendKey2CSD(1, 0x40);
                    SendKey2CSD(0, 0x40);
                    break;

                case 65://A
                    SendKey2CSD(1, 0x41);
                    SendKey2CSD(0, 0x41);
                    break;

                case 66://B
                    SendKey2CSD(1, 0x42);
                    SendKey2CSD(0, 0x42);
                    break;

                case 67://C
                    SendKey2CSD(1, 0x43);
                    SendKey2CSD(0, 0x43);
                    break;

                case 68://D
                    SendKey2CSD(1, 0x44);
                    SendKey2CSD(0, 0x44);
                    break;

                case 69://E
                    SendKey2CSD(1, 0x45);
                    SendKey2CSD(0, 0x45);
                    break;

                case 70://F
                    SendKey2CSD(1, 0x46);
                    SendKey2CSD(0, 0x46);
                    break;

                case 71://G
                    SendKey2CSD(1, 0x47);
                    SendKey2CSD(0, 0x47);
                    break;

                case 72://H
                    SendKey2CSD(1, 0x48);
                    SendKey2CSD(0, 0x48);
                    break;

                case 73://I
                    SendKey2CSD(1, 0x49);
                    SendKey2CSD(0, 0x49);
                    break;

                case 74://J
                    SendKey2CSD(1, 0x4A);
                    SendKey2CSD(0, 0x4A);
                    break;

                case 75://K
                    SendKey2CSD(1, 0x4B);
                    SendKey2CSD(0, 0x4B);
                    break;

                case 76://L
                    SendKey2CSD(1, 0x4C);
                    SendKey2CSD(0, 0x4C);
                    break;

                case 77://M
                    SendKey2CSD(1, 0x4D);
                    SendKey2CSD(0, 0x4D);
                    break;

                case 78://N
                    SendKey2CSD(1, 0x4E);
                    SendKey2CSD(0, 0x4E);
                    break;

                case 79://O
                    SendKey2CSD(1, 0x4F);
                    SendKey2CSD(0, 0x4F);
                    break;

                case 80://P
                    SendKey2CSD(1, 0x50);
                    SendKey2CSD(0, 0x50);
                    break;

                case 81://Q
                    SendKey2CSD(1, 0x51);
                    SendKey2CSD(0, 0x51);
                    break;

                case 82://R
                    SendKey2CSD(1, 0x52);
                    SendKey2CSD(0, 0x52);
                    break;

                case 83://S
                    SendKey2CSD(1, 0x53);
                    SendKey2CSD(0, 0x53);
                    break;

                case 84://T
                    SendKey2CSD(1, 0x54);
                    SendKey2CSD(0, 0x54);
                    break;

                case 85://U
                    SendKey2CSD(1, 0x55);
                    SendKey2CSD(0, 0x55);
                    break;

                case 86://V
                    SendKey2CSD(1, 0x56);
                    SendKey2CSD(0, 0x56);
                    break;

                case 87://W
                    SendKey2CSD(1, 0x57);
                    SendKey2CSD(0, 0x57);
                    break;

                case 88://X
                    SendKey2CSD(1, 0x58);
                    SendKey2CSD(0, 0x58);
                    break;

                case 89://Y
                    SendKey2CSD(1, 0x59);
                    SendKey2CSD(0, 0x59);
                    break;

                case 90://Z
                    SendKey2CSD(1, 0x5A);
                    SendKey2CSD(0, 0x5A);
                    break;

                case 91://[
                    SendKey2CSD(1, 0x5B);
                    SendKey2CSD(0, 0x5B);
                    break;

                case 92://￥
                    SendKey2CSD(1, 0x5C);
                    SendKey2CSD(0, 0x5C);
                    break;

                case 93://]
                    SendKey2CSD(1, 0x5D);
                    SendKey2CSD(0, 0x5D);
                    break;

                case 94://^
                    SendKey2CSD(1, 0x5E);
                    SendKey2CSD(0, 0x5E);
                    break;

                case 95://_
                    SendKey2CSD(1, 0x5F);
                    SendKey2CSD(0, 0x5F);
                    break;

                case 96://`
                    SendKey2CSD(1, 0x60);
                    SendKey2CSD(0, 0x60);
                    break;

                case 97://a
                    SendKey2CSD(1, 0x61);
                    SendKey2CSD(0, 0x61);
                    break;

                case 98://b
                    SendKey2CSD(1, 0x62);
                    SendKey2CSD(0, 0x62);
                    break;

                case 99://c
                    SendKey2CSD(1, 0x63);
                    SendKey2CSD(0, 0x63);
                    break;

                case 100://d
                    SendKey2CSD(1, 0x64);
                    SendKey2CSD(0, 0x64);
                    break;

                case 101://e
                    SendKey2CSD(1, 0x65);
                    SendKey2CSD(0, 0x65);
                    break;

                case 102://f
                    SendKey2CSD(1, 0x66);
                    SendKey2CSD(0, 0x66);
                    break;

                case 103://g
                    SendKey2CSD(1, 0x67);
                    SendKey2CSD(0, 0x67);
                    break;

                case 104://h
                    SendKey2CSD(1, 0x68);
                    SendKey2CSD(0, 0x68);
                    break;

                case 105://i
                    SendKey2CSD(1, 0x69);
                    SendKey2CSD(0, 0x69);
                    break;

                case 106://j
                    SendKey2CSD(1, 0x6A);
                    SendKey2CSD(0, 0x6A);
                    break;

                case 107://k
                    SendKey2CSD(1, 0x6B);
                    SendKey2CSD(0, 0x6B);
                    break;

                case 108://l
                    SendKey2CSD(1, 0x6C);
                    SendKey2CSD(0, 0x6C);
                    break;

                case 109://m
                    SendKey2CSD(1, 0x6D);
                    SendKey2CSD(0, 0x6D);
                    break;

                case 110://n
                    SendKey2CSD(1, 0x6E);
                    SendKey2CSD(0, 0x6E);
                    break;

                case 111://o
                    SendKey2CSD(1, 0x6F);
                    SendKey2CSD(0, 0x6F);
                    break;

                case 112://p
                    SendKey2CSD(1, 0x70);
                    SendKey2CSD(0, 0x70);
                    break;

                case 113://q
                    SendKey2CSD(1, 0x71);
                    SendKey2CSD(0, 0x71);
                    break;

                case 114://r
                    SendKey2CSD(1, 0x72);
                    SendKey2CSD(0, 0x72);
                    break;

                case 115://s
                    SendKey2CSD(1, 0x73);
                    SendKey2CSD(0, 0x73);
                    break;

                case 116://t
                    SendKey2CSD(1, 0x74);
                    SendKey2CSD(0, 0x74);
                    break;

                case 117://u
                    SendKey2CSD(1, 0x75);
                    SendKey2CSD(0, 0x75);
                    break;

                case 118://v
                    SendKey2CSD(1, 0x76);
                    SendKey2CSD(0, 0x76);
                    break;

                case 119://w
                    SendKey2CSD(1, 0x77);
                    SendKey2CSD(0, 0x77);
                    break;

                case 120://x
                    SendKey2CSD(1, 0x78);
                    SendKey2CSD(0, 0x78);
                    break;

                case 121://y
                    SendKey2CSD(1, 0x79);
                    SendKey2CSD(0, 0x79);
                    break;

                case 122://z
                    SendKey2CSD(1, 0x7A);
                    SendKey2CSD(0, 0x7A);
                    break;

                #endregion

                default:
                    break;
            }
        }

        private void OnSoftKey(string key)
        {
            switch (key)
            {
                case "FL":
                    SendKey2CSD(1, 0xFF);
                    SendKey2CSD(0, 0xFF);
                    break;
                case "F1":
                    SendKey2CSD(1, 0xF0);
                    SendKey2CSD(0, 0xF0);
                    break;
                case "F2":
                    SendKey2CSD(1, 0xF1);
                    SendKey2CSD(0, 0xF1);
                    break;
                case "F3":
                    SendKey2CSD(1, 0xF2);
                    SendKey2CSD(0, 0xF2);
                    break;
                case "F4":
                    SendKey2CSD(1, 0xF3);
                    SendKey2CSD(0, 0xF3);
                    break;
                case "F5":
                    SendKey2CSD(1, 0xF4);
                    SendKey2CSD(0, 0xF4);
                    break;
                case "F6":
                    SendKey2CSD(1, 0xF5);
                    SendKey2CSD(0, 0xF5);
                    break;
                case "F7":
                    SendKey2CSD(1, 0xF6);
                    SendKey2CSD(0, 0xF6);
                    break;
                case "F8":
                    SendKey2CSD(1, 0xF7);
                    SendKey2CSD(0, 0xF7);
                    break;
                case "F9":
                    SendKey2CSD(1, 0xF8);
                    SendKey2CSD(0, 0xF8);
                    break;
                case "F10":
                    SendKey2CSD(1, 0xF9);
                    SendKey2CSD(0, 0xF9);
                    break;
                case "FR":
                    SendKey2CSD(1, 0xFE);
                    SendKey2CSD(0, 0xFE);
                    break;
                case "SVF1":
                    SendKey2CSD(1, 0xA0);
                    SendKey2CSD(0, 0xA0);
                    break;

                default:
                    break;

            }
        }

        public void OnMenuKey(string key)
        {
            switch (key)
            {
                case "POS":
                    SendKey2CSD(1, 0xE8);
                    SendKey2CSD(0, 0xE8);
                    break;
                case "PROG":
                    SendKey2CSD(1, 0xE9);
                    SendKey2CSD(0, 0xE9);
                    break;
                case "OFS":
                    SendKey2CSD(1, 0xEA);
                    SendKey2CSD(0, 0xEA);
                    break;
                case "SYS":
                    SendKey2CSD(1, 0xEB);
                    SendKey2CSD(0, 0xEB);
                    break;
                case "MSG":
                    SendKey2CSD(1, 0xEC);
                    SendKey2CSD(0, 0xEC);
                    break;
                case "GRA":
                    SendKey2CSD(1, 0xED);
                    SendKey2CSD(0, 0xED);
                    break;
                case "CUS1":
                    SendKey2CSD(1, 0xEE);
                    SendKey2CSD(0, 0xEE);
                    break;
                case "CUS2":
                    SendKey2CSD(1, 0xEF);
                    SendKey2CSD(0, 0xEF);
                    break;
                case "PAGEUP":
                    SendKey2CSD(1, 0x8F);
                    SendKey2CSD(0, 0x8F);
                    break;
                case "PAGEDOWN":
                    SendKey2CSD(1, 0x8E);
                    SendKey2CSD(0, 0x8E);
                    break;
                case "UP":
                    SendKey2CSD(1, 0x8B);
                    SendKey2CSD(0, 0x8B);
                    break;
                case "DOWN":
                    SendKey2CSD(1, 0x8A);
                    SendKey2CSD(0, 0x8A);
                    break;
                case "LEFT":
                    SendKey2CSD(1, 0x89);
                    SendKey2CSD(0, 0x89);
                    break;
                case "RIGHT":
                    SendKey2CSD(1, 0x88);
                    SendKey2CSD(0, 0x88);
                    break;
                case "HOME":
                    SendKey2CSD(1, 0x90);
                    SendKey2CSD(0, 0x90);
                    break;
                case "DELETE":
                    SendKey2CSD(1, 0x95);
                    SendKey2CSD(0, 0x95);
                    break;

                default:
                    break;

            }
        }

        #endregion

        private void SendKey2CSD(short state, short key)
        {
            try
            {
                _SendKey(state, key);
            }
            catch { }
        }
    }

}
