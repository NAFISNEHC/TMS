using TMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TMS.DAL
{
    public class UserInfoDal
    {
        public UserInfo GetUserInfo(string userId, string userPwd)
        {
            string sql = "select * from T_UserInfo join T_WorkCell on T_UserInfo.UserId=T_WorkCell.UserId where T_UserInfo.UserId=@UserId and UserPwd=@UserPwd";
            SqlParameter[] pars = {
                   new SqlParameter("@UserId",SqlDbType.VarChar,11),
                   new SqlParameter("@UserPwd",SqlDbType.VarChar,50),
            };
            pars[0].Value = userId;
            pars[1].Value = userPwd;
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            UserInfo userInfo = null;
            if (da.Rows.Count > 0)
            {
                userInfo = new UserInfo();
                LoadEntity(userInfo, da.Rows[0]);
            }
            return userInfo;
        }
        public void LoadEntity(UserInfo userInfo, DataRow row)
        {
            userInfo.UserId = row["UserId"]!=DBNull.Value ? row["UserId"].ToString() : string.Empty;
            userInfo.UserPwd = row["UserPwd"]!=DBNull.Value ? row["UserPwd"].ToString() : string.Empty;
            userInfo.UserName = row["UserName"] != DBNull.Value ? row["UserName"].ToString() : string.Empty;
            userInfo.WorkCell = row["WorkCell"] != DBNull.Value ? row["WorkCell"].ToString() : string.Empty;
            userInfo.UserOpt = row["UserOpt"] != DBNull.Value ? row["UserOpt"].ToString() : string.Empty;
            userInfo.RegTime = Convert.ToDateTime(row["RegTime"]);
            userInfo.UserEmail = row["UserEmail"] != DBNull.Value ? row["UserEmail"].ToString() : string.Empty;
        }
    }
}
