using System.Diagnostics;
using FoodOrderSignalrCore.Helper;
using Microsoft.AspNetCore.Mvc;
using WebMvcSignalrCore.Models;

namespace WebMvcSignalrCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Kitchen()
        {
            var order = FoodDummyHelper.CreateDummyOrder(1);
            return View(order.FoodOrders);
        }

        public IActionResult Waitress()
        {
            var order = FoodDummyHelper.CreateDummyOrder(1);
            return View(order.FoodOrders);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }  
    }
}