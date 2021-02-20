﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticaInterna.Models.ViewModels;

namespace PracticaInterna.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<ProductsViewModel> lst = new List<ProductsViewModel>();
            ProductsViewModel oProductViewMOdel = new ProductsViewModel();

            lst = oProductViewMOdel.CelularesProductViewModel();

            return View(lst);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}