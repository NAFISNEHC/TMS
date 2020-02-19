using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Model;

namespace TMS.BLL
{
    public class OPService
    {
        DAL.OPDal OPDal = new DAL.OPDal();
        public OP[] GetOP()
        {
            return OPDal.GetOP();
        }
    }
}
