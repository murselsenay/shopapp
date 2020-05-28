using System;
using Microsoft.AspNetCore.Mvc;

namespace shopapp.webui.Controllers
{
    //localhost:5000/home
    public class HomeController:Controller
    {
        public IActionResult Index(){

            int hour=DateTime.Now.Hour;
            ViewBag.Greeting =hour>12?"İyi günler":"günaydın";
            ViewBag.UserName="Mürsel Şenay";
            return View();
        }
        public IActionResult About(){
            return View();
        }
        public IActionResult Contact(){
            return View();
        }
    }
}