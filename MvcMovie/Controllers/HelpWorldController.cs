﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelpWorldController : Controller
    {
        // GET: HelpWorld
        //public string Index()
        //{
        //    return "This is my <b>default</b> action ...";
        //}
        //public string Welcome(string name, int  numTimes=1)
        //{
        //    return HttpUtility.HtmlEncode("Hello"+name+", NumItmes is : "+numTimes);
        //}
        //public string Welcome(string name, int ID = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello" + name + ", ID is : " + ID);
        //}
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome(string name, int numTimes=1)
        {
            ViewBag.Message = "Hello" + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }

    }
}