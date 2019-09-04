using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCenter.Entities;
using DataCenter.Model;
using System.Collections.ObjectModel;
using AutoMapper;
using DataCenter.Enum;

namespace DataCenter.Services
{
    public class LibInfoService
    {
        private readonly IMapper _mapper;
        private DataCenterEnum _datacenter;


        public LibInfoService(IMapper mapper)
        {
            this._mapper = mapper;
        }

        public void  SetDataCenterEnum(DataCenterEnum data)
        {
            _datacenter = data;
        }

        public string GetCurrentLibInfo()
        {

                    try
                    {
                        using (var scope = new LaserEngineDBEntities())
                        {
                            var item = scope.LibInfo.OrderByDescending(x => x.UpdataDateTime).FirstOrDefault();

                            if (item != null)
                            {
                                return item.Name + "." + item.Version;
                            }

                            return  "数据库加载失败!";
                        }
                    }
                    catch (Exception ex)
                    {
                return "数据库加载失败!";
                    }
            
        }
    }
}
