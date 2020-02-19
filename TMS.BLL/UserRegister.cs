using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.BLL
{
    public class UserRegister
    {
        DAL.UserRegisterDal UserRegisterDal = new DAL.UserRegisterDal();
        public Boolean SetUserInfo(string userName, string userId, string workCell, string userOpt,string userPwd, string userEmail)
        {
            return UserRegisterDal.SetUserInfo(userName, userId, workCell, userOpt, userPwd, userEmail);
        }
    }
}
