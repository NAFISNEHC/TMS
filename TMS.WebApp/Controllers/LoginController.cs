using TMS.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMS.Model;
using TMS.Common;

namespace TMS.WebApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult UserLogin()
        {
            string userId = Request.Form["userId"];
            string userPwd = Request.Form["userPassword"];
            UserInfoService UserInfoService = new UserInfoService();
            UserInfo userInfo = UserInfoService.GetUserInfo(userId, userPwd);
            if (userInfo != null)
            {
                Session["userInfo"] = userInfo;
                if (userInfo.UserOpt.Equals("Operator1"))
                {
                    var script = String.Format("<script>location.href='{0}'</script>", Url.Action("Index", "Home", userInfo));
                    return Content(script, "text/html");
                }
                else if (userInfo.UserOpt.Equals("Operator2"))
                {
                    var script = String.Format("<script>location.href='{0}'</script>", Url.Action("Index2", "Home", userInfo));
                    return Content(script, "text/html");
                }
                else if (userInfo.UserOpt.Equals("Supervisor"))
                {
                    var script = String.Format("<script>location.href='{0}'</script>", Url.Action("Index3", "Home", userInfo));
                    return Content(script, "text/html");
                }
                else if (userInfo.UserOpt.Equals("Manager"))
                {
                    var script = String.Format("<script>location.href='{0}'</script>", Url.Action("Index4", "Home", userInfo));
                    return Content(script, "text/html");
                }
                else if (userInfo.UserOpt.Equals("Admin"))
                {
                    var script = String.Format("<script>location.href='{0}'</script>", Url.Action("Index5", "Home", userInfo));
                    return Content(script, "text/html");
                }
                else
                    return Content("text/html");
            }
            else
            {
                var script = String.Format("<script>alert('用户名或密码错误！');location.href='{0}'</script>", Url.Action("Index", "Login"));
                return Content(script, "text/html");
            }
        }
        public ActionResult UserRegister()
        {
            string userName = Request.Form["userName"];
            string userId = Request.Form["userId"];
            string WorkCell = Request.Form["WorkCell"];
            string userOpt = Request.Form["userOpt"];
            string userPwd = Request.Form["userPassword"];
            string userEmail = Request.Form["userEmail"];
            UserRegister UserRegister = new UserRegister();
            Boolean flag = UserRegister.SetUserInfo(userName, userId, WorkCell, userOpt ,userPwd, userEmail);
            if (flag)
            {
                var script = String.Format("<script>alert('注册成功！');location.href='{0}'</script>", Url.Action("Index", "Login"));
                return Content(script, "text/html");
            }
            else
            {
                var script = String.Format("<script>alert('注册失败！');location.href='{0}'</script>", Url.Action("Register", "Login"));
                return Content(script, "text/html");
            }
        }
    }
}