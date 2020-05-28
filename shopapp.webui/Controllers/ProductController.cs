using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;
using System.Collections.Generic;

namespace shopapp.webui.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index()
        {


            //ViewBag
            //Model
            //ViewData

            var product = new Product { Name = "Iphone XR", Price = 6000, Description = "Pahalı Telefon" };

            // ViewData["Category"]="Telefonlar";
            // ViewData["Product"]=product;

            ViewBag.Category = "Telefonlar";
            // ViewBag.Product=product;


            return View(product);

        }

        //localhost:5000/product/list
        public IActionResult List()
        {

            var products = new List<Product>(){
                new Product{Name="Iphone 8", Price=3000,Description="Çok iyi Telefon",isApproved=true},
                new Product{Name="Iphone XR", Price=6000,Description="Pahalı Telefon", isApproved=true},
                new Product{Name="Iphone 7", Price=1000,Description="Çok iyi Telefon",isApproved=true},
                 new Product{Name="Iphone 11", Price=2000,Description="Pahalı Telefon",isApproved=true}
           };

            var category = new Category { Name = "Telefonlar", Description = "Telefonların yer aldığı kategori" };

            var productViewModel = new ProductViewModel()
            {
                Category = category,
                Products = products
            };


            return View(productViewModel);
        }


        //localhost:5000/product/details
        public IActionResult Details(int id)
        {
            //name: "samsung note 3"
            //price: 3000
            //description: "iyi bir telefon"

            // ViewBag.Name="Samsung Note 3";
            // ViewBag.Price=3000;
            // ViewBag.Description="İyi bir telefon";

            var p = new Product();
            p.Name = "Samsung Note 3";
            p.Price = 3000;
            p.Description = "İyi bir telefon";



            return View(p);
        }
    }
}