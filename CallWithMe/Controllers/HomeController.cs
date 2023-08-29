using CallWithMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CallWithMe.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        //English

        public ActionResult Index()
        {
            if ((int)(Session["lng"]) == 0)
            {
                Session["lng"] = 1;
           
                //long ipStart = ipToLong(Request.UserHostAddress);
                //var db = new DataAccessDataContext();
                //if (db.ipTbls.Any(c => ipStart >= c.from && ipStart <= c.to))
                //{
                    return RedirectToAction("Index");
                //}
              
            }
            return View();
        }

        #region english
        //خرید پلن
        public ActionResult enPlanTana()
        {
            return View();
        }
        #endregion

        #region فارسی

        public ActionResult faIndex()
        {
            if ((int)(Session["lng"]) == 0)
            {
                Session["lng"] = 1;
                long ipStart = ipToLong(Request.UserHostAddress);
                var db = new DataAccessDataContext();
                if (!db.ipTbls.Any(c => ipStart >= c.from && ipStart <= c.to))
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }


        //تیم تانا
        public ActionResult faTanaTeam()
        {
            return View();
        }

        //شماره تماس ها
        public ActionResult faContactTana()
        {
            return View();
        }

        //خدمات
        public ActionResult faServiceTana()
        {
            return View();
        }

        //خرید پلن
        public ActionResult faPlanTana()
        {
            return View();
        }

        //ترمز
        public ActionResult faTerms()
        {
            return View();
        }

        //اینترنت
        public ActionResult faInternetTana()
        {
            return View();
        }
        //voip
        public ActionResult faVoipTana()
        {
            return View();
        }
        //ارزش افزوده
        public ActionResult faVasTana()
        {
            return View();
        }

        //نرم افزار موبایل
        public ActionResult faMobileTana()
        {
            return View();
        }
        //طراحی نرم افزار تحت وب
        public ActionResult faWebTana()
        {
            return View();
        }
        //تجارت الکترونیک
        public ActionResult faEBusinessTana()
        {
            return View();
        }
        //سخت افزار
        public ActionResult faHardwareTana()
        {
            return View();
        }
        #endregion

        [HttpPost]
        [ValidateAntiForgeryTokenOnAllPosts]
        public JsonResult sendMail(string to, string subject, string text)
        {
            var result = new Result();


            if(ModelState.IsValid==false)
            {
                result.code = 1;
                result.message = "اطلاعات وارد شده صحیح نمی باشد";
                return Json(result);
            }

            if (to == "" || subject == "" || text == "")
            {
                result.code = 1;
                result.message = "اطلاعات وارد شده صحیح نمی باشد";
                return Json(result);
            }

            if (Session["captcha"] != null)
            {
                result.code = 2;
                result.message = "جهت ارسال مجدد پیام کمی صبر کنید";
                return Json(result);
            }
            try
            {
                Method.sendMail(to, subject, text);
                result.message = "عملیات با موفقیت انجام شد";
                result.code = 0;
                Session["captcha"] = "1";
                return Json(result);
            }
            catch 
            {
                result.code = 1;
                result.message = "خطا در ارسال پیام. دوباره تلاش کنید";
                return Json(result);

            }
        }

        public long ipToLong(string ip)
        {
            var arr = ip.Split('.');
            var a = int.Parse(arr[0]);
            var b = int.Parse(arr[1]);
            var c = int.Parse(arr[2]);
            var d = int.Parse(arr[3]);

            return (a * (256 * 256 * 256)) + (b * (256 * 256)) + (c * (256)) + d;

        }
    }
}
