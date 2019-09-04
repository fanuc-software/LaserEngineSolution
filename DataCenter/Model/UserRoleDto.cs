using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCenter.Model
{
    public class UserRoleDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
        public bool IsAuth { get; set; }
    }
}
