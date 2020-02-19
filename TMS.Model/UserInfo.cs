using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model
{
    public class UserInfo
    {
        public string UserName { get; set; }
        public string UserId { get; set; }
        public string UserPwd { get; set; }
        public string WorkCell { get; set; }
        public string UserOpt { get; set; }
        public DateTime RegTime { get; set; }
        public string UserEmail { get; set; }
    }
}
