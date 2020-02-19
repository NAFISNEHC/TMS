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
    public class UserRegisterDal
    {
        public Boolean SetUserInfo(string userName, string userId, string workCell, string userOpt,string userPwd, string userEmail)
        {
            string sql = "select * from T_UserInfo where UserId=@UserId";
            SqlParameter[] pars = {
                   new SqlParameter("@UserId",SqlDbType.VarChar,11),
            };
            pars[0].Value = userId;
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            if (da.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                string sql2 = "insert into T_UserInfo values(@UserName,@UserId,@UserPwd,getdate(),@UserEmail)";
                SqlParameter[] pars2 = {
                    new SqlParameter("@UserName",SqlDbType.VarChar,50),
                    new SqlParameter("@UserId",SqlDbType.VarChar,11),
                    new SqlParameter("@UserPwd",SqlDbType.VarChar,50),
                    new SqlParameter("@UserEmail",SqlDbType.VarChar,50),
                };
                pars2[0].Value = userName;
                pars2[1].Value = userId;
                pars2[2].Value = userPwd;
                pars2[3].Value = userEmail;
                int row = SqlHelper.ExecuteNonquery(sql2, CommandType.Text, pars2);
                if (row > 0)
                {
                    string sql3 = "insert into T_WorkCell values(@UserId,@UserOpt,@WorkCell)";
                    SqlParameter[] pars3 = {
                        new SqlParameter("@UserId", SqlDbType.VarChar,11),
                        new SqlParameter("@UserOpt", SqlDbType.VarChar,50),
                        new SqlParameter("@WorkCell", SqlDbType.VarChar,50),
                    };
                    pars3[0].Value = userId;
                    pars3[1].Value = userOpt;
                    pars3[2].Value = workCell;
                    int row2 = SqlHelper.ExecuteNonquery(sql3, CommandType.Text, pars3);
                    if (row > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            
        }
    }
}
