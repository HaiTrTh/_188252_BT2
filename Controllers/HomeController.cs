using _188252_BT2.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace _188252_BT2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        public IActionResult Index()
        {
            var listproduct = new ProductListModel().initProducts();


            return View(listproduct);
        }

        public IActionResult Privacy()
        {
            return View();
        }

      
        public JsonResult Search(string searchkeyWork)
        {
            var value = string.Empty;
            if (searchkeyWork != null)
            {
                var product = new ProductListModel().LitsAll().Where(x => x.Product_Name.ToLower().Contains(searchkeyWork.ToLower())).ToList();
                {
                    value = JsonConvert.SerializeObject(product, Formatting.Indented, new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                    });
                    return Json(value);
                }
            }
            return Json(value);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }