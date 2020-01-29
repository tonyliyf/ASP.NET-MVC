﻿using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class LoginByAjaxController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            ViewData["Time"] = DateTime.Now.ToString();
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Name, string Pwd)
        {
            if (Name == "admin" && Pwd == "123456")
            {
                ViewData["Time"] = DateTime.Now.ToString();
                return Content("true");
            }
            else
            {
                ViewData["Time"] = DateTime.Now.ToString();
                return Content("error");
            }
        }
    }
}