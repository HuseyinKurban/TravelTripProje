﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;


namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {

            var deger = c.Blogs.ToList();
            return View(deger);
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial2()
        {

            var degerler = c.Blogs.OrderByDescending(x => x.ID)
                                  .Skip(2) // Sondan 3. öğeye ulaşmak için 2 öğe atla
                          .Take(1) // Sadece 1 öğe al
                          .ToList();
            return PartialView(degerler);
        }

  
    }
}