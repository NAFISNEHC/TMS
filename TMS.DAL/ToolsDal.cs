using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using TMS.Model;

namespace TMS.DAL
{
    public class ToolsDal
    {
        public Tools[] GetTools(string workCell)
        {
            string sql = "select * from T_ToolDefine where WorkCell=@WorkCell";
            SqlParameter[] pars = {
                   new SqlParameter("@WorkCell",SqlDbType.VarChar,50),
            };
            pars[0].Value = workCell;
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            Tools[] tools = null;
            if (da.Rows.Count > 0)
            { 
                tools = new Tools[da.Rows.Count];
                for (int i = 0; i < da.Rows.Count; i++)
                {
                    tools[i] = new Tools();
                }
                LoadEntity(tools, da);
            }
            return tools;
        }
        public void LoadEntity(Tools []tools, DataTable d)
        {
            for (int i = 0; i < d.Rows.Count; i++)
            {
                tools[i].Code = d.Rows[i]["Code"] != DBNull.Value ? d.Rows[i]["Code"].ToString() : string.Empty;
                tools[i].Name = d.Rows[i]["Name"] != DBNull.Value ? d.Rows[i]["Name"].ToString() : string.Empty;
                tools[i].Famliy = d.Rows[i]["Famliy"] != DBNull.Value ? d.Rows[i]["Famliy"].ToString() : string.Empty;
                tools[i].WorkCell = d.Rows[i]["WorkCell"] != DBNull.Value ? d.Rows[i]["WorkCell"].ToString() : string.Empty;
                tools[i].Model = d.Rows[i]["Model"] != DBNull.Value ? d.Rows[i]["Model"].ToString() : string.Empty;
                tools[i].PartNo = d.Rows[i]["PartNo"] != DBNull.Value ? d.Rows[i]["PartNo"].ToString() : string.Empty;
                tools[i].UsedFor = d.Rows[i]["UsedFor"] != DBNull.Value ? d.Rows[i]["UsedFor"].ToString() : string.Empty;
                tools[i].UPL = Convert.ToInt32(d.Rows[i]["UPL"].ToString());
                tools[i].Owner = d.Rows[i]["Owner"] != DBNull.Value ? d.Rows[i]["Owner"].ToString() : string.Empty;
                tools[i].PMPeriod = Convert.ToInt32(d.Rows[i]["PMPeriod"]);
                tools[i].RecOn = Convert.ToDateTime(d.Rows[i]["RecOn"]);
                tools[i].RecBy = d.Rows[i]["RecBy"] != DBNull.Value ? d.Rows[i]["RecBy"].ToString() : string.Empty;
                tools[i].EditOn = Convert.ToDateTime(d.Rows[i]["EditOn"]);
                tools[i].EditBy = d.Rows[i]["EditBy"] != DBNull.Value ? d.Rows[i]["EditBy"].ToString() : string.Empty;
            }
        }
    }
}