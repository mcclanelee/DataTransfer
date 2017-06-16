using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataTransfer.Models.Domain;

namespace DataTransfer.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public ActionResult GetValueByQueryString()
        {
            //Request属性可用来获取querystring,form表单以及cookie中的值
            var querystring = Request["method"];
            ViewBag.Show = "From ViewBag " + " by query string ";
            ViewData["Show"] = "From ViewBag" + " by query string ";
            TempData["Show"] = "From TempData" + " by query string ";
            return View(100);
        }

        public ActionResult GetValueByRouteData()
        {
            var value = RouteData.Values["id"];
            object obj = "by route data";
            return View(obj);
        }

        public ActionResult GetValueByRouteData2(int id)
        {
            object obj = id.ToString();
            ViewBag.Show = "by route data";
            return View(obj);
        }

        public ActionResult GetValueFromForm()
        {
            var name = Request["username"];
            var age = Request["age"];
            var btn = Request["button"];
            ViewBag.Show = name + age;
            object obj = "From Form";
            return View(obj);
        }

        public ActionResult GetValueFromFormByModel(User user)
        {
            ViewBag.Show = user.UserName + user.Age.ToString();
            return View();
        }

        public ActionResult GetValueByParam(string username, int age)
        {
            ViewBag.Show = username + age;
            return View();
        }

        public ActionResult GetValueByCookie()
        {
            if (System.Web.HttpContext.Current.Request.Cookies["ckey"] != null)
            {
                try
                {
                    string cookieValue = System.Web.HttpContext.Current.Request.Cookies["ckey"].Value.ToString();
                    ViewBag.Show = cookieValue;
                }
                catch (Exception ex)
                {

                }
            }
           
            return View();
        }

        public void  GetData(string username, int age)
        {
            ViewBag.Show = username + age;
        }

        public JsonResult SendData()
        {
            return Json(new { UserName = "mcclane", Age = 24 });
        }
    }
}