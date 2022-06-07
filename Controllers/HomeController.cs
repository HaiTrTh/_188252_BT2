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

        //public JsonResult Search(string pr)
        //{
        //    //var result = listproduct.Where(a => a.Product_Name.Contains(pr) || a.Product_Img.Contains(pr)).Take(1).Select(a => new {
        //    //    resultItem = a.Product_Name + a.Product_Price + a.Product_DegreePercent
        //    //}).ToList();      
        //    //return Json(result);

        //    var listproduct = new ProductListModel().initProducts();
        //    var Name = (from product in listproduct
        //                where product.Product_Name.StartsWith(pr)
        //                select new { product });
        //    return Json(Name, new Newtonsoft.Json.JsonSerializerSettings());
        //}

        //public JsonResult Search(string prefix)
        //{
        //    var product = new ProductListModel().initProducts();

        //    var customers = (from pro in product
        //                     where pro.Product_Name.Contains(prefix)
        //                     select new
        //                     {
        //                         pro
        //                     }).ToList();

        //    return Json(customers);
        //}
        //public JsonResult Search(string value)
        //{
        //    var product = new ProductListModel().initProducts();
        //    value = JsonConvert.SerializeObject(product, Formatting.Indented, new JsonSerializerSettings
        //    {

        //        ReferenceLoopHandling = ReferenceLoopHandling.Ignore

        //    });
        //    return Json(value);
        //}

        public JsonResult Search(string searchkeyWork)
        {
            var value = string.Empty;
            if (searchkeyWork != null)
            {
                var product = new ProductListModel().initProducts().Where(x => x.Product_Name.ToLower().Contains(searchkeyWork.ToLower())).ToList();
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