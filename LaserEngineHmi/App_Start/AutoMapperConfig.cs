using AutoMapper;
using DataCenter;
using FanucCnc;

namespace LaserEngineHmi.App_Start
{
    public class AutoMapperConfig
    {
        private static MapperConfiguration _mapperConfiguration;

        /// <summary>
        /// 注册模块
        /// </summary>
        public static void Register()
        {
            //var moduleInitializers = new ModuleInitializer[]
            //{
            //    new LaserEngineModuleInitializer()
            //};


            var moduleInitializers = new LaserEngineModuleInitializer();
            _mapperConfiguration = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<CncMemObjectInfo, CncMemObjectInfoDto>();
                moduleInitializers.LoadMapper(cfg);
            });
        }

        /// <summary>
        /// 获取配置
        /// </summary>
        /// <returns></returns>
        public static MapperConfiguration GetMapperConfiguration()
        {
            if (_mapperConfiguration == null)
                Register();

            return _mapperConfiguration;
        }
    }
}
