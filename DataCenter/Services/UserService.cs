using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCenter.Entities;
using DataCenter.Model;
using System.Collections.ObjectModel;
using AutoMapper;

namespace DataCenter.Services
{
    public class UserService
    {
        private readonly IMapper _mapper;

        public UserService(IMapper mapper)
        {
            this._mapper = mapper;
        }

        public bool Login(string name, string password)
        {
            var temp=System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5");

            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    var item = scope.User.Where(x => x.Name == name & x.Password == temp).FirstOrDefault();

                    if (item != null) return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }

        public List<UserRoleDto> GetUserRoles(string name)
        {
            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    var list = scope.UserRole.Where(x => x.UserName == name ).ToList();

                    return _mapper.Map<List<UserRole>, List<UserRoleDto>>(list);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
