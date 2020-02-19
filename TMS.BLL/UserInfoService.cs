using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;

namespace TMS.BLL
{
    public class UserInfoService
    {
        DAL.UserInfoDal UserInfoDal = new DAL.UserInfoDal();
        public UserInfo GetUserInfo(string userId, string userPwd)
        {
            return UserInfoDal.GetUserInfo(userId, userPwd);
        }
    }
}
