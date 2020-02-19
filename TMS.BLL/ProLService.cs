using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;

namespace TMS.BLL
{
    public class ProLService
    {
        DAL.ProLDAL pldal = new DAL.ProLDAL();
        public ProL[] GetPl()
        {
            return pldal.GetPl();
        }
    }
}
