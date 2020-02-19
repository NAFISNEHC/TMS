using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMS.BLL;
using TMS.Common;
using TMS.Model;

namespace TMS.WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // Operator 1
        public ActionResult Index(UserInfo userInfo)
        {
            GetData(userInfo);
            return View();
        }
        public ActionResult Index2(UserInfo userInfo)
        {
            GetData(userInfo);
            return View();
        }
        public ActionResult Index3(UserInfo userInfo)
        {
            GetData(userInfo);
            return View();
        }
        public ActionResult Index4(UserInfo userInfo)
        {
            GetData(userInfo);
            return View();
        }
        public ActionResult Index5(UserInfo userInfo)
        {
            GetData(userInfo);
            return View();
        }
        public void GetData(UserInfo userInfo)
        {
            ViewBag.user = userInfo;
            string workCell = userInfo.WorkCell;
            ToolsService ToolsService = new ToolsService();
            Tools[] tools = ToolsService.GetTools(workCell);

            if (userInfo != null)
            {
                Session["tools"] = tools;
                ViewBag.tools = tools;
            }
            Enlity[][] enlity = new Enlity[tools.Length][];
            for (int i = 0; i < tools.Length; i++)
            {
                EnlityService EnlityService = new EnlityService();
                enlity[i] = EnlityService.GetEnlity(tools[i].Code);
            }
            ViewBag.enlity = enlity;
        }
        public ActionResult Storeroom(UserInfo userInfo)
        {
            GetData(userInfo);
            OPService OPService = new OPService();
            OP[] op= OPService.GetOP();
            ViewBag.op = op;
            ProLService ProLService = new ProLService();
            ProL[] pl = ProLService.GetPl();
            ViewBag.pl = pl;
            return View();
        }

        public ActionResult Storeroom2(UserInfo userInfo)
        {
            GetData(userInfo);
            OPService OPService = new OPService();
            OP[] op = OPService.GetOP();
            ViewBag.op = op;
            ProLService ProLService = new ProLService();
            ProL[] pl = ProLService.GetPl();
            ViewBag.pl = pl;
            return View();
        }
    }
}