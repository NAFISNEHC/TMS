using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TMS.Model;

namespace TMS.DAL
{
    public class EnlityDal
    {
        public Enlity[] GetEnlity(string code)
        {
            string sql = "select * from T_ToolEnlity where Code=@Code";
            SqlParameter[] pars = {
                   new SqlParameter("@Code",SqlDbType.VarChar,50),
            };
            pars[0].Value = code;
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            Enlity[] enlity = null;
            if (da.Rows.Count > 0)
            {
                enlity = new Enlity[da.Rows.Count];
                for (int i = 0; i < da.Rows.Count; i++)
                {
                    enlity[i] = new Enlity();
                }
                LoadEntity(enlity, da);
            }
            return enlity;
        }
        public void LoadEntity(Enlity[] enlity, DataTable d)
        {
            for (int i = 0; i < d.Rows.Count; i++)
            {
                enlity[i].Code = d.Rows[i]["Code"] != DBNull.Value ? d.Rows[i]["Code"].ToString() : string.Empty;
                enlity[i].BillNo = d.Rows[i]["BillNo"] != DBNull.Value ? d.Rows[i]["BillNo"].ToString() : string.Empty;
                enlity[i].Location = d.Rows[i]["Location"] != DBNull.Value ? d.Rows[i]["Location"].ToString() : string.Empty;
                enlity[i].SeqID = Convert.ToInt32(d.Rows[i]["SeqID"].ToString());
                enlity[i].UsedCount = Convert.ToInt32(d.Rows[i]["UsedCount"]);
                enlity[i].RegData = Convert.ToDateTime(d.Rows[i]["RegData"].ToString());
            }
        }
    }
}
