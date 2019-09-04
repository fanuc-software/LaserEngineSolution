using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using GalaSoft.MvvmLight.Messaging;

namespace LaserEngineHmi.Hook
{
    public class NewKeyboardHook
    {
        private static NewKeyboardHook _instance = null;

        public static NewKeyboardHook CreateInstance()
        {
            if (_instance == null)

            {
                _instance = new NewKeyboardHook();
            }
            return _instance;
        }

        private NewKeyboardHook()
        {
            //this.KeyPressEvent += new System.Windows.Forms.KeyPressEventHandler(hook_KeyPress);
            //this.MyKeyPressEvent += new NewKeyboardHook.MyKeyPressEventHandler(hook_MyKeyPress);
        }

        private void hook_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            byte key = (byte)e.KeyChar;
            Messenger.Default.Send<byte>(key, "CsdKeyMsg");
        }

        private void hook_MyKeyPress(object sender, string e)
        {
            Messenger.Default.Send<string>(e, "CsdMyKeyMsg");
        }

        public delegate void MyKeyPressEventHandler(object sender, string e);

        public event KeyEventHandler KeyDownEvent;
        public event KeyPressEventHandler KeyPressEvent;
        public event KeyEventHandler KeyUpEvent;
        public event MyKeyPressEventHandler MyKeyPressEvent;

        public delegate int HookProc(int nCode, Int32 wParam, IntPtr lParam);
        static int hKeyboardHook = 0; //声明键盘钩子处理的初始值
        //值在Microsoft SDK的Winuser.h里查询
        public const int WH_KEYBOARD_LL = 13;   //线程键盘钩子监听键盘消息设为2，全局键盘监听鼠标消息设为13
        HookProc KeyboardHookProcedure; //声明KeyboardHookProcedure作为HookProc类型
        //键盘结构 
        [StructLayout(LayoutKind.Sequential)]
        public class KeyboardHookStruct
        {
            public int vkCode;  //定一个虚拟键码。该代码必须有一个价值的范围1至254
            public int scanCode; // 指定的硬件扫描码的关键
            public int flags;  // 键标志
            public int time; // 指定的时间戳记的这个讯息
            public int dwExtraInfo; // 指定额外信息相关的信息
        }
        //使用此功能，安装了一个钩子
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);
        
        //调用此函数卸载钩子
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);


        //使用此功能，通过信息钩子继续下一个钩子
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode, Int32 wParam, IntPtr lParam);

        // 取得当前线程编号（线程钩子需要用到） 
        [DllImport("kernel32.dll")]
        static extern int GetCurrentThreadId();

        //使用WINDOWS API函数代替获取当前实例的函数,防止钩子失效
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string name);

        public void Start()
        {
            // 安装键盘钩子
            if (hKeyboardHook == 0)
            {

                KeyboardHookProcedure = new HookProc(KeyboardHookProc);
                //hKeyboardHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyboardHookProcedure, GetModuleHandle(System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName), 0);
                hKeyboardHook = SetWindowsHookEx(WH_KEYBOARD_LL,
                    KeyboardHookProcedure,
                    GetModuleHandle(System.Diagnostics.Process.GetCurrentProcess().ProcessName),
                    0);
                //hKeyboardHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyboardHookProcedure, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
                //************************************ 
                //键盘线程钩子 
                //SetWindowsHookEx( 2,KeyboardHookProcedure, IntPtr.Zero, GetCurrentThreadId());//指定要监听的线程idGetCurrentThreadId(),
                //键盘全局钩子,需要引用空间(using System.Reflection;) 
                //SetWindowsHookEx(13, 
                //  KeyboardHookProcedure, 
                //  Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 
                //  0); 
                // 
                //关于SetWindowsHookEx (int idHook, HookProc lpfn, IntPtr hInstance, int threadId)函数将钩子加入到钩子链表中，说明一下四个参数： 
                //idHook 钩子类型，即确定钩子监听何种消息，上面的代码中设为2，即监听键盘消息并且是线程钩子，如果是全局钩子监听键盘消息应设为13， 
                //线程钩子监听鼠标消息设为7，全局钩子监听鼠标消息设为14。lpfn 钩子子程的地址指针。如果dwThreadId参数为0 或是一个由别的进程创建的 
                //线程的标识，lpfn必须指向DLL中的钩子子程。 除此以外，lpfn可以指向当前进程的一段钩子子程代码。钩子函数的入口地址，当钩子钩到任何 
                //消息后便调用这个函数。hInstance应用程序实例的句柄。标识包含lpfn所指的子程的DLL。如果threadId 标识当前进程创建的一个线程，而且子 
                //程代码位于当前进程，hInstance必须为NULL。可以很简单的设定其为本应用程序的实例句柄。threaded 与安装的钩子子程相关联的线程的标识符
                //如果为0，钩子子程与所有的线程关联，即为全局钩子
                //************************************ 
                //如果SetWindowsHookEx失败
                if (hKeyboardHook == 0)
                {
                    Stop();
                    throw new Exception("安装键盘钩子失败");
                }

            }
        }
        public void Stop()
        {
            bool retKeyboard = true;


            if (hKeyboardHook != 0)
            {
                retKeyboard = UnhookWindowsHookEx(hKeyboardHook);
                hKeyboardHook = 0;
            }

            //if (!(retKeyboard)) throw new Exception("卸载钩子失败！");
        }
        //ToAscii职能的转换指定的虚拟键码和键盘状态的相应字符或字符
        [DllImport("user32")]
        public static extern int ToAscii(int uVirtKey, //[in] 指定虚拟关键代码进行翻译。 
                                         int uScanCode, // [in] 指定的硬件扫描码的关键须翻译成英文。高阶位的这个值设定的关键，如果是（不压）
                                         byte[] lpbKeyState, // [in] 指针，以256字节数组，包含当前键盘的状态。每个元素（字节）的数组包含状态的一个关键。如果高阶位的字节是一套，关键是下跌（按下）。在低比特，如果设置表明，关键是对切换。在此功能，只有肘位的CAPS LOCK键是相关的。在切换状态的NUM个锁和滚动锁定键被忽略。
                                         byte[] lpwTransKey, // [out] 指针的缓冲区收到翻译字符或字符。 
                                         int fuState); // [in] Specifies whether a menu is active. This parameter must be 1 if a menu is active, or 0 otherwise. 

        //获取按键的状态
        [DllImport("user32")]
        public static extern int GetKeyboardState(byte[] pbKeyState);


        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern short GetKeyState(int vKey);

        [DllImport("user32")]

        public static extern short GetAsyncKeyState(int vKey);

        private const int WM_KEYDOWN = 0x100;//KEYDOWN 
        private const int WM_KEYUP = 0x101;//KEYUP
        private const int WM_SYSKEYDOWN = 0x104;//SYSKEYDOWN
        private const int WM_SYSKEYUP = 0x105;//SYSKEYUP

        private int KeyboardHookProc(int nCode, Int32 wParam, IntPtr lParam)
        {
            // 侦听键盘事件
            if ((nCode >= 0) && (KeyDownEvent != null || KeyUpEvent != null || KeyPressEvent != null))
            {
                KeyboardHookStruct MyKeyboardHookStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));

                ////KeyDown
                if (KeyDownEvent != null && (wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN))
                {
                    Keys keyData = (Keys)MyKeyboardHookStruct.vkCode;
                    KeyEventArgs e = new KeyEventArgs(keyData);
                    KeyDownEvent(this, e);
                }

                ////键盘抬起
                if (KeyUpEvent != null && (wParam == WM_KEYUP || wParam == WM_SYSKEYUP))
                {
                    Keys keyData = (Keys)MyKeyboardHookStruct.vkCode;
                    KeyEventArgs e = new KeyEventArgs(keyData);
                    KeyUpEvent(this, e);
                }

                ////键盘按下
                if (KeyPressEvent != null && wParam == WM_KEYDOWN)
                {
                    byte[] keyState = new byte[256];
                    byte[] inBuffer = new byte[2];

                    if (ToAscii(MyKeyboardHookStruct.vkCode,
                    MyKeyboardHookStruct.scanCode,
                    ModifyKeyState(Keys.ShiftKey),
                    inBuffer,
                    MyKeyboardHookStruct.flags) == 1)
                    {
                        KeyPressEventArgs e = new KeyPressEventArgs((char)inBuffer[0]);
                        if (e.KeyChar <= 122 && e.KeyChar >= 97 )//字母
                        {
                            if (GetKeyState((int)Keys.CapsLock) > 0)
                            {
                                e.KeyChar = (char)(e.KeyChar - 32);
                                KeyPressEvent(this, e);
                            }
                            else
                            {
                                KeyPressEvent(this, e);
                            }
                        }
                        else//非字母字符
                        {
                            KeyPressEvent(this, e);
                        }
                    }
                    else
                    {
                        switch (MyKeyboardHookStruct.vkCode)
                        {
                            case 46://Page Up
                                MyKeyPressEvent(this, "DELETE");
                                break;
                            case 33://Page Up
                                MyKeyPressEvent(this, "PAGEUP");
                                break;
                            case 34://Page Down
                                MyKeyPressEvent(this, "PAGEDOWN");
                                break;
                            case 37://left
                                MyKeyPressEvent(this, "LEFT");
                                break;
                            case 38://up
                                MyKeyPressEvent(this, "UP");
                                break;
                            case 39://right
                                MyKeyPressEvent(this, "RIGHT");
                                break;
                            case 40://down
                                MyKeyPressEvent(this, "DOWN");
                                break;
                            case 36://HOME
                                var res36 = (int)GetAsyncKeyState(17) & 32768;
                                if (res36 > 1)
                                {
                                    MyKeyPressEvent(this, "HOME");
                                }
                                break;
                            case 112://POS
                                var res112 = (int)GetAsyncKeyState(17) & 32768;
                                if (res112 > 1)
                                {
                                    MyKeyPressEvent(this, "POS");
                                }
                                break;
                            case 113://PROG
                                var res113 = (int)GetAsyncKeyState(17) & 32768;
                                if (res113 > 1)
                                {
                                    MyKeyPressEvent(this, "PROG");
                                }
                                break;
                            case 114://OFS
                                var res114 = (int)GetAsyncKeyState(17) & 32768;
                                if (res114 > 1)
                                {
                                    MyKeyPressEvent(this, "OFS");
                                }
                                break;
                            case 115://SYS
                                var res115 = (int)GetAsyncKeyState(17) & 32768;
                                if (res115 > 1)
                                {
                                    MyKeyPressEvent(this, "SYS");
                                }
                                break;
                            case 116://MSG
                                var res116 = (int)GetAsyncKeyState(17) & 32768;
                                if (res116 > 1)
                                {
                                    MyKeyPressEvent(this, "MSG");
                                }
                                break;
                            case 117://GRA
                                var res117 = (int)GetAsyncKeyState(17) & 32768;
                                if (res117 > 1)
                                {
                                    MyKeyPressEvent(this, "GRA");
                                }
                                break;
                            case 118://CUS1
                                var res118 = (int)GetAsyncKeyState(17) & 32768;
                                if (res118 > 1)
                                {
                                    MyKeyPressEvent(this, "CUS1");
                                }
                                break;
                            case 119://CUS2
                                var res119 = (int)GetAsyncKeyState(17) & 32768;
                                if (res119 > 1)
                                {
                                    MyKeyPressEvent(this, "CUS2");
                                }
                                break;
                            case 120://F9
                                var res120 = (int)GetAsyncKeyState(17) & 32768;
                                if (res120 > 1)
                                {
                                    MyKeyPressEvent(this, "F9");
                                }
                                break;
                            case 121://RESET
                                var res121 = (int)GetAsyncKeyState(17) & 32768;
                                if (res121 > 1)
                                {
                                    MyKeyPressEvent(this, "RESET");
                                }
                                break;

                            default:
                                break;
                        }

                    }
                }
            }
            

            //如果返回1，则结束消息，这个消息到此为止，不再传递。
            //如果返回0或调用CallNextHookEx函数则消息出了这个钩子继续往下传递，也就是传给消息真正的接受者 
            return CallNextHookEx(hKeyboardHook, nCode, wParam, lParam);
        }

        ~NewKeyboardHook()
        {
            Stop();
        }

        private const byte HighBit = 0x80;
        private static byte[] GetKeyState2(Keys modifiers)
        {
            var keyState = new byte[256];
            foreach (Keys key in System.Enum.GetValues(typeof(Keys)))
            {
                if ((modifiers & key) == key)
                {
                    keyState[(int)key] = HighBit;
                }
            }
            return keyState;
        }

        private static byte[] ModifyKeyState(Keys modifiers)
        {
            var keyState = new byte[256];
            if ((GetKeyState((int)modifiers) & 0x8000) == 0x8000)
            {
                keyState[(int)modifiers] = 0x80;
            }
            return keyState;
        }
    }
}
