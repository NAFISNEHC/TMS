using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.DAL;
using TMS.Model;


namespace TMS.BLL
{
    public class EnlityService
    {
        DAL.EnlityDal EnlityDal = new DAL.EnlityDal();
        public Enlity[] GetEnlity(string code)
        {
            return EnlityDal.GetEnlity(code);
        }
    }
}
