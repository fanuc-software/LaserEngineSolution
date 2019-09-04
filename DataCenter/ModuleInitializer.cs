using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using AutoMapper;
using DataCenter.Model;
using DataCenter.Entities;

namespace DataCenter
{
    public abstract class ModuleInitializer
    {
        ///// <summary>
        ///// 加载SimpleInject配置
        ///// </summary>
        ///// <param name="container"></param>
        //public abstract void LoadIoc(Container container);

        /// <summary>
        /// 加载AutoMapper配置
        /// </summary>
        public abstract void LoadMapper(IMapperConfigurationExpression cfg);
    }


}
