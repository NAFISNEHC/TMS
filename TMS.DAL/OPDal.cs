using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;

namespace TMS.DAL
{
    public class OPDal
    {
        public OP[] GetOP()
        {
            string sql = "select d.Code,d.Famliy,d.Name,BillNo,d.Model,Location from T_ToolDefine d JOIN T_ToolEnlity e on d.Code=e.Code";
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text);
            OP[] op = null;
            if (da.Rows.Count > 0)
            {
                op = new OP[da.Rows.Count];
                for (int i = 0; i < da.Rows.Count; i++)
                {
                    op[i] = new OP();
                }
                LoadEntity(op, da);
            }
            return op;
        }
        public void LoadEntity(OP[] op, DataTable d)
        {
            for (int i = 0; i < d.Rows.Count; i++)
            {
                op[i].Code = d.Rows[i]["Code"] != DBNull.Value ? d.Rows[i]["Code"].ToString() : string.Empty;
                op[i].Name = d.Rows[i]["Name"] != DBNull.Value ? d.Rows[i]["Name"].ToString() : string.Empty;
                op[i].Famliy = d.Rows[i]["Famliy"] != DBNull.Value ? d.Rows[i]["Famliy"].ToString() : string.Empty;
                op[i].Model = d.Rows[i]["Model"] != DBNull.Value ? d.Rows[i]["Model"].ToString() : string.Empty;
                op[i].BillNo = d.Rows[i]["BillNo"] != DBNull.Value ? d.Rows[i]["BillNo"].ToString() : string.Empty;
                op[i].Location = d.Rows[i]["Location"] != DBNull.Value ? d.Rows[i]["Location"].ToString() : string.Empty;
            }
        }
    }
}
