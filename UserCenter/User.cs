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
using DataCenter.Services;
using DataCenter.Model;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace UserCenter
{
    public class User 
    {
        private UserService _uSrv;
        private static User _instance = null;

        private string m_Name;
        public string Name
        {
            get { return m_Name; }
            set
            {
                if (m_Name != value)
                {
                    m_Name = value;
                }
            }
        }

        private List<UserRoleDto> userRoles = new List<UserRoleDto>();
        public List<UserRoleDto> UserRoles
        {
            get { return userRoles; }
            set
            {
                if (userRoles != value)
                {
                    userRoles = value;
                }
            }
        }

        private bool rootLibOperate;
        public bool RootLibOperate
        {
            get { return rootLibOperate; }
            set
            {
                if (rootLibOperate != value)
                {
                    rootLibOperate = value;
                }
            }
        }

        #region Ctor

        public static User CreateInstance()
        {
            if (_instance == null)

            {
                _instance = new User();
            }
            return _instance;
        }

        public User()
        {
            this._uSrv = SimpleIoc.Default.GetInstance<UserService>(); ;
        }

        #endregion

        #region 登陆、修改密码
        public bool Login(string name, string password)
        {
            var ret = _uSrv.Login(name, password);
            if (ret == true)
            {
                this.m_Name = name;
                GetUserRoles();
                GetUserLibRootRoles();
            }

            return ret;
        }

        #endregion

        #region 获取授权
        public void GetUserRoles()
        {
            UserRoles = _uSrv.GetUserRoles(m_Name);
        }


        public void GetUserLibRootRoles()
        {
            string RootLibOperate;
            var item = UserRoles.Where(x => x.RoleName == "Lib_RootOperate" & x.IsAuth == true).FirstOrDefault();
            if (item != null) RootLibOperate = "Visible";
            else RootLibOperate = "Hidden";

            Messenger.Default.Send<string>(RootLibOperate, "RootLibOperateMsg");
        }

        #endregion

    }
}
