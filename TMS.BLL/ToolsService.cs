using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.DAL;
using TMS.Model;

namespace TMS.BLL
{
    public class ToolsService
    {
        DAL.ToolsDal ToolsDal = new DAL.ToolsDal();
        public Tools[] GetTools(string workCell)
        {
            return ToolsDal.GetTools(workCell);
        }
    }
}
