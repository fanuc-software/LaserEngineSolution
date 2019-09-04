using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppContainers
{
    /// <summary>
    /// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
    ///
    /// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中: 
    ///
    ///     xmlns:MyNamespace="clr-namespace:AppContainer"
    ///
    ///
    /// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中: 
    ///
    ///     xmlns:MyNamespace="clr-namespace:AppContainer;assembly=AppContainer"
    ///
    /// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
    /// 并重新生成以避免编译错误: 
    ///
    ///     在解决方案资源管理器中右击目标项目，然后依次单击
    ///     “添加引用”->“项目”->[选择此项目]
    ///
    ///
    /// 步骤 2)
    /// 继续操作并在 XAML 文件中使用控件。
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    [TemplatePart(Name = "PART_Host", Type = typeof(WindowsFormsHost))]
    public class AppContainer : Control
    {
        #region Fields

        private WindowsFormsHost _winFormHost = null;
        public System.Windows.Forms.Panel _hostPanel = null;

        private ManualResetEvent _eventDone = new ManualResetEvent(false);
        public Process _process = null;

        public IntPtr _embededWindowHandle = (IntPtr)0;

        #endregion

        #region Properties

        #endregion

        #region Dependency Properties

        #endregion

        #region Wrappers

        #endregion

        #region Constructors

        static AppContainer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AppContainer), new FrameworkPropertyMetadata(typeof(AppContainer)));
        }

        #endregion

        #region Override Methods

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _winFormHost = GetTemplateChild("PART_Host") as WindowsFormsHost;
            if(_winFormHost != null)
            {
                _hostPanel = new System.Windows.Forms.Panel();
                _winFormHost.Child = _hostPanel;
            }
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            if (_process != null)
            {
                Win32Api.MoveWindow(_process.MainWindowHandle, 0, 0, (int)ActualWidth, (int)ActualHeight, true);
            }
            base.OnRender(drawingContext);
        }

        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            this.InvalidateVisual();
            base.OnRenderSizeChanged(sizeInfo);
        }

        #endregion

        #region Dependency Property Changed Callbacks

        #endregion

        #region Private Methods

        /// <summary>
        /// 启动外进程
        /// </summary>
        /// <param name="appPath"></param>
        /// <returns></returns>
        public virtual Process StartApp(string appPath)
        {
            if (!File.Exists(appPath))
            {
                return null;
            }
            ProcessStartInfo info = new ProcessStartInfo(appPath)
            {
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Minimized
            };
            Process process = Process.Start(info);

            return process;
        }

        /// <summary>
        /// 关闭外进程
        /// </summary>
        /// <param name="process"></param>
        private void CloseApp(Process process)
        {
            if (process != null && !process.HasExited)
            {
                process.Kill();
            }
        }

        /// <summary>
        /// 将外进程嵌入到当前程序
        /// </summary>
        /// <param name="process"></param>
        public virtual bool EmbedApp(Process process)
        {
            //是否嵌入成功标志，用作返回值
            bool isEmbedSuccess = false;
            //外进程句柄
            IntPtr processHwnd = process.MainWindowHandle;
            
            //容器句柄
            IntPtr panelHwnd = _hostPanel.Handle;

            if (processHwnd != (IntPtr)0 && panelHwnd != (IntPtr)0)
            {
                //把本窗口句柄与目标窗口句柄关联起来
                int setTime = 0;
                while (!isEmbedSuccess && setTime < 10)
                {
                    isEmbedSuccess = (Win32Api.SetParent(processHwnd, panelHwnd) != 0);
                    Thread.Sleep(100);
                    setTime++;
                }
                //设置初始尺寸和位置
                Win32Api.MoveWindow(_process.MainWindowHandle, 0, 0, (int)ActualWidth, (int)ActualHeight, true);
            }

            if(isEmbedSuccess)
            {
                _embededWindowHandle = _process.MainWindowHandle;
            }

            return isEmbedSuccess;
        }

        #endregion

        #region Public Methods

        public bool StartAndEmbedProcess(string processPath)
        {
            bool isStartAndEmbedSuccess = false;
            _eventDone.Reset();

            //启动进程
            _process = StartApp(processPath);
            if (_process == null)
            {
                return false;
            }

            //确保可获取到句柄
            Thread thread = new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    if (_process.MainWindowHandle != (IntPtr)0)
                    {
                        _eventDone.Set();
                        break;
                    }
                    Thread.Sleep(10);
                }
            }));
            thread.Start();

            //嵌入进程
            if (_eventDone.WaitOne(10000))
            {
                isStartAndEmbedSuccess = EmbedApp(_process);
                if (!isStartAndEmbedSuccess)
                {
                    CloseApp(_process);
                }
            }
            return isStartAndEmbedSuccess;
        }

        public void CloseProcess()
        {
            CloseApp(_process);
        }

        public bool EmbedExistProcess(Process process)
        {
            _process = process;
            return EmbedApp(process);
        }

        #endregion

    }
}
