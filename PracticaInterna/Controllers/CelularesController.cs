using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticaInterna.Models.ViewModels;

namespace PracticaInterna.Controllers
{
    public class CelularesController : Controller
    {
        // GET: Celulares
        public ActionResult Index()
        {
            List<ProductsViewModel> lst = new List<ProductsViewModel>();
            ProductsViewModel oProductViewMOdel = new ProductsViewModel();

            lst = oProductViewMOdel.CelularesProductViewModel();

            return View(lst);
        }

        public ActionResult Detalle(int Id)
        {
            List<ProductsViewModel> lst = new List<ProductsViewModel>();
            List<ProductsViewModel> lstDetalle = new List<ProductsViewModel>();
            ProductsViewModel oProductViewModel = new ProductsViewModel();

            lst = oProductViewModel.CelularesProductViewModel();

            foreach (ProductsViewModel product in lst)
            {
                if(product.Id == Id)
                {
                    lstDetalle.Add(product);
                }
            }

            return View(lstDetalle);
        }
    }
}