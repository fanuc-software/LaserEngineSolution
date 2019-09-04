using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using AutoMapper;
using FanucCnc;
using LaserEngineHmi.Model;
using UserCenter;

namespace LaserEngineHmi.ViewModel
{
    public class UserPopViewModel : ViewModelBase
    {
        private User _user;

        private string m_UserName;
        public string UserName
        {
            get { return m_UserName; }
            set
            {
                if (m_UserName != value)
                {
                    m_UserName = value;
                    RaisePropertyChanged(() => UserName);
                }
            }
        }

        private ICommand ReLoginCommand { get; set; }
        private ICommand CancelCommand { get; set; }

        public UserPopViewModel(User user)
        {
            this._user = user;

            UserName = user.Name;
        }
    }
}
