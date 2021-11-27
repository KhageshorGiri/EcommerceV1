using Ecommerce.Entities;
using Ecommerce.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductService service = new ProductService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductTable(string search)
        {
            var products = service.getProduct();

            if (search != null)  //string.IsNullOrEmpty(search) == false
            {
                products = products.Where(x => x.Name != null && x.Name.ToLower().Contains(search.ToLower())).ToList();
            }

            return PartialView(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(Product product)
        {
            service.saveProduct(product);
            return Redirect("Index");
        }
    }
}