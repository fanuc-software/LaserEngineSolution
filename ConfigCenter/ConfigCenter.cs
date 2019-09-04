using System.Xml;

namespace ConfigCenter
{
    public class ConfigHelper
    {
        private static string path = "LaserEngineMachineConfiguration.xml";

        public short GetSimulateInfo(out bool simulate)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/simulate");
                simulate = bool.Parse(node.GetElementsByTagName("noCnc").Item(0).InnerText);

                return 0;
            }
            catch (XmlException ex)
            {
                simulate = true;
                return -1;
            }
        }

        public short GetMachineInfo_Base(out string ip, out ushort port, out ushort timeout)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machine");
                ip = node.GetElementsByTagName("ip").Item(0).InnerText;
                port = ushort.Parse( node.GetElementsByTagName("port").Item(0).InnerText);
                timeout = ushort.Parse(node.GetElementsByTagName("timeOut").Item(0).InnerText);

                return 0;
            }
            catch (XmlException ex)
            {
                ip = "192.168.1.1";
                port = 8193;
                timeout = 10;
                return -1;
            }
        }

        public short GetCsdInfo(out string folder)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/cncscreendisplay");
                folder = node.GetElementsByTagName("folder").Item(0).InnerText;

                return 0;
            }
            catch (XmlException ex)
            {
                folder = @"C:\Program Files (x86)\CNCScreen";
                return -1;
            }
        }

        public short GetProgramRoot(out string pcRoot, out string ncRoot)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/program");
                pcRoot = node.GetElementsByTagName("pcRoot").Item(0).InnerText;
                ncRoot = node.GetElementsByTagName("ncRoot").Item(0).InnerText;

                return 0;
            }
            catch (XmlException ex)
            {
                pcRoot = @"C:\";
                ncRoot = @"//CNC_MEM/USER/PATH1";
                return -1;
            }
        }

        #region 机床配置
        public short GetMachiningConfigurationInfo(out string laser, out string cutter, out string optical)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                laser = node.GetElementsByTagName("laserType").Item(0).InnerText;
                cutter = node.GetElementsByTagName("cutterType").Item(0).InnerText;
                optical = node.GetElementsByTagName("opticalType").Item(0).InnerText;

                return 0;
            }
            catch (XmlException ex)
            {
                laser = "";
                cutter = "";
                optical = "";
                return -1;
            }
        }

        public short GetCncType(out string cnctype)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                cnctype = node.GetElementsByTagName("cncType").Item(0).InnerText;

                
            }
            catch (XmlException ex)
            {
                cnctype = "";
                return -1;
            }

            return 0;
        }

        public short SetCncType(string cnctype)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                node.GetElementsByTagName("laserType").Item(0).InnerText = cnctype;
            }
            catch (XmlException ex)
            {
                return -1;
            }

            return 0;
        }

        public short GetMachineType(out string machinetype)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                machinetype = node.GetElementsByTagName("machineType").Item(0).InnerText;


            }
            catch (XmlException ex)
            {
                machinetype = "";
                return -1;
            }

            return 0;
        }

        public short SetMachineType(string machinetype)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                node.GetElementsByTagName("machineType").Item(0).InnerText = machinetype;
            }
            catch (XmlException ex)
            {
                return -1;
            }

            return 0;
        }

        public short GetXDistance(out double xdis)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                var temp = node.GetElementsByTagName("xDistance").Item(0).InnerText;

                xdis = double.Parse(temp);

            }
            catch (XmlException ex)
            {
                xdis = 0;
                return -1;
            }

            return 0;
        }

        public short SetXDistance(double xdis)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                node.GetElementsByTagName("xDistance").Item(0).InnerText = xdis.ToString();
            }
            catch (XmlException ex)
            {
                return -1;
            }

            return 0;
        }

        public short GetYDistance(out double ydis)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                var temp = node.GetElementsByTagName("yDistance").Item(0).InnerText;

                ydis = double.Parse(temp);

            }
            catch (XmlException ex)
            {
                ydis = 0;
                return -1;
            }

            return 0;
        }

        public short SetYDistance(double ydis)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                node.GetElementsByTagName("yDistance").Item(0).InnerText = ydis.ToString();
            }
            catch (XmlException ex)
            {
                return -1;
            }

            return 0;
        }

        public short GetZDistance(out double zdis)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                var temp = node.GetElementsByTagName("zDistance").Item(0).InnerText;

                zdis = double.Parse(temp);

            }
            catch (XmlException ex)
            {
                zdis = 0;
                return -1;
            }

            return 0;
        }

        public short SetZDistance(double zdis)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                node.GetElementsByTagName("zDistance").Item(0).InnerText = zdis.ToString();
            }
            catch (XmlException ex)
            {
                return -1;
            }

            return 0;
        }

        public short GetXMotorType(out string xmotor)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                xmotor = node.GetElementsByTagName("xMotorType").Item(0).InnerText;
                

            }
            catch (XmlException ex)
            {
                xmotor = "";
                return -1;
            }

            return 0;
        }

        public short SetXMotorType(string xmotor)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                node.GetElementsByTagName("xMotorType").Item(0).InnerText = xmotor;
            }
            catch (XmlException ex)
            {
                return -1;
            }

            return 0;
        }

        public short GetYMotorType(out string ymotor)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                ymotor = node.GetElementsByTagName("yMotorType").Item(0).InnerText;


            }
            catch (XmlException ex)
            {
                ymotor = "";
                return -1;
            }

            return 0;
        }

        public short SetYMotorType(string ymotor)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                node.GetElementsByTagName("yMotorType").Item(0).InnerText = ymotor;
            }
            catch (XmlException ex)
            {
                return -1;
            }

            return 0;
        }

        public short GetZMotorType(out string zmotor)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                zmotor = node.GetElementsByTagName("zMotorType").Item(0).InnerText;


            }
            catch (XmlException ex)
            {
                zmotor = "";
                return -1;
            }

            return 0;
        }

        public short SetZMotorType(string zmotor)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                node.GetElementsByTagName("zMotorType").Item(0).InnerText = zmotor;
            }
            catch (XmlException ex)
            {
                return -1;
            }

            return 0;
        }

        public short GetLaserType(out string laser)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                laser = node.GetElementsByTagName("laserType").Item(0).InnerText;


            }
            catch (XmlException ex)
            {
                laser = "";
                return -1;
            }

            return 0;
        }

        public short SetLaserType(string laser)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                node.GetElementsByTagName("laserType").Item(0).InnerText = laser;
            }
            catch (XmlException ex)
            {
                return -1;
            }

            return 0;
        }

        public short GetCutterType(out string cutter)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                cutter = node.GetElementsByTagName("cutterType").Item(0).InnerText;


            }
            catch (XmlException ex)
            {
                cutter = "";
                return -1;
            }

            return 0;
        }

        public short SetCutterType(string cutter)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                node.GetElementsByTagName("cutterType").Item(0).InnerText = cutter;
            }
            catch (XmlException ex)
            {
                return -1;
            }

            return 0;
        }

        public short GetOpticalType(out string optical)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                optical = node.GetElementsByTagName("opticalType").Item(0).InnerText;


            }
            catch (XmlException ex)
            {
                optical = "";
                return -1;
            }

            return 0;
        }

        public short SetOpticalType(string optical)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/machining");
                node.GetElementsByTagName("opticalType").Item(0).InnerText = optical;
            }
            catch (XmlException ex)
            {
                return -1;
            }

            return 0;
        }

        #endregion

        #region 软件配置
        public short GetLanguage(out string language)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/software");
                language = node.GetElementsByTagName("language").Item(0).InnerText;


            }
            catch (XmlException ex)
            {
                language = "pack://application:,,,/LaserEngineHmi;component/Resources/zh-cn.xaml";
                return -1;
            }

            return 0;
        }

        public short SetLanguage(string language)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/software");
                node.GetElementsByTagName("language").Item(0).InnerText = language;
            }
            catch (XmlException ex)
            {
                return -1;
            }

            return 0;
        }

        public short GetSoftwareInfo(out string info)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/software");
                var name = node.GetElementsByTagName("name").Item(0).InnerText;
                var version = node.GetElementsByTagName("version").Item(0).InnerText;

                info = name + "." + version;
            }
            catch (XmlException ex)
            {
                info = "获得软件版本失败";
                return -1;
            }

            return 0;
        }
        #endregion

        #region csd
        public string GetCncScreenDisplayStartCmd()
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/cncscreendisplay");

                return node.GetElementsByTagName("start").Item(0).InnerText;
                
            }
            catch (XmlException ex)
            {
                return null;
            }
        }
        #endregion

        #region 工作台
        public string GetWorkStationZLimit()
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/workstation");
                return node.GetElementsByTagName("zlimit").Item(0).InnerText;

            }
            catch (XmlException ex)
            {
                return null;
            }
        }

        public short SetWorkStationZLimit(string zlimit)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/workstation");
                node.GetElementsByTagName("zlimit").Item(0).InnerText = zlimit;
            }
            catch (XmlException ex)
            {
                return -1;
            }

            return 0;
        }

        public string GetWorkStationHorizontal()
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/workstation");
                return node.GetElementsByTagName("horizontal").Item(0).InnerText;

            }
            catch (XmlException ex)
            {
                return null;
            }
        }

        public short SetWorkStationHorizontal(string horizontal)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/workstation");
                node.GetElementsByTagName("horizontal").Item(0).InnerText = horizontal;
            }
            catch (XmlException ex)
            {
                return -1;
            }

            return 0;
        }

        public string GetWorkStationVertical()
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/workstation");
                return node.GetElementsByTagName("vertical").Item(0).InnerText;

            }
            catch (XmlException ex)
            {
                return null;
            }
        }

        public short SetWorkStationVertical(string vertical)
        {
            try
            {
                XmlDocument xml = new XmlDocument();//初始化一个xml实例
                xml.Load(path);//导入指定xml文件
                XmlElement node = (XmlElement)xml.SelectSingleNode("/laser_engine_machine/workstation");
                node.GetElementsByTagName("vertical").Item(0).InnerText = vertical;
            }
            catch (XmlException ex)
            {
                return -1;
            }

            return 0;
        }

        #endregion
    }
}
