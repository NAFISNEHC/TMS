using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TMS.Common
{
    public class MessageBox
    {
        public static void Show(string message)
        {
                HttpContext.Current.Response.Write("<scritp>alert('" + message + "');</script>");
        }
    } 
}
