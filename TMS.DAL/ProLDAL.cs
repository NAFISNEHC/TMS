using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;

namespace TMS.DAL
{
    public class ProLDAL
    {
        public ProL[] GetPl()
        {
            string sql = "select * from T_Product";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            ProL[] pl = null;
            if (da.Rows.Count > 0)
            {
                pl = new ProL[da.Rows.Count];
                for (int i = 0; i < da.Rows.Count; i++)
                {
                    pl[i] = new ProL();
                }
                LoadEntity(pl, da);
            }
            return pl;
        }
        public void LoadEntity(ProL[] pl, DataTable d)
        {
            for (int i = 0; i < d.Rows.Count; i++)
            {
                pl[i].pl = d.Rows[i]["production"] != DBNull.Value ? d.Rows[i]["production"].ToString() : string.Empty;
            }
        }
    }
}
