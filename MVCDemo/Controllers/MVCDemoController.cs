using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class MVCDemoController : Controller
    {
        // GET: MVCDemo
        public ActionResult Index()
        {
            ViewBag.Greeting = DateTime.Now.Hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public ViewResult RsvpForm(GuestResponse response)
        {
            if (!Request.IsAuthenticated)
            {
                return View("UnAuthenticate");
            }
            //TODO: 发送邮件给晚会组织者
            return View("Thanks", response);
        }

        /// <summary>
        /// 致谢页面
        /// </summary>
        /// <returns></returns>
        public ViewResult Thanks()
        {
            return View();
        }

        /// <summary>
        /// 未验证
        /// </summary>
        /// <returns></returns>
        public ViewResult UnAuthenticate()
        {
            return View();
        }
    }
}