using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaInterna.Models.ViewModels
{
    public class ProductsViewModel
    {
        public int Id { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public string newPrice { get; set; }
        public string oldPrice { get; set; }

        public List<ProductsViewModel> CelularesProductViewModel()
        {
            List<ProductsViewModel> lst = new List<ProductsViewModel>();
            ProductsViewModel prod1 = new ProductsViewModel();
            ProductsViewModel prod2 = new ProductsViewModel();
            ProductsViewModel prod3 = new ProductsViewModel();
            ProductsViewModel prod4 = new ProductsViewModel();

            prod1.Id = 1;
            prod1.image = "https://www.tiendamonge.com/media/catalog/product/1/6/169794_0.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=300&width=175&canvas=175:300";
            prod1.name = "Celular 4G Xiaomi Redmi 9 Gris";
            prod1.newPrice = "₡89.901";
            prod1.oldPrice = "₡119.900";
            lst.Add(prod1);

            prod2.Id = 2;
            prod2.image = "https://www.tiendamonge.com/media/catalog/product/1/6/167770_0.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=300&width=175&canvas=175:300";
            prod2.name = "Celular 4G Motorola ONE FUSION Verde";
            prod2.newPrice = "₡119.900";
            prod2.oldPrice = "₡129.900";
            lst.Add(prod2);

            prod3.Id = 3;
            prod3.image = "https://www.tiendamonge.com/media/catalog/product/1/6/166666_1_1.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=300&width=175&canvas=175:300";
            prod3.name = "Celular 4G BLU G9 PRO Azul";
            prod3.newPrice = "₡129.900";
            prod3.oldPrice = "₡149.900";
            lst.Add(prod3);

            prod4.Id = 4;
            prod4.image = "https://www.tiendamonge.com/media/catalog/product/cache/95333050a0060ecff16fdd50ff46c307/1/6/165170_promocr.jpg";
            prod4.name = "CELULAR 4G SAMSUNG A51 AZUL";
            prod4.newPrice = "₡184.900";
            prod4.oldPrice = "₡194.900";
            lst.Add(prod4);


            return lst;
        }
    }
}