using _188252_BT2.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PagedList;
using System.Linq;


namespace _188252_BT2.Controllers
{
    public class BimTaController : Controller
    {
        private List<Product> productsSearchedBrand;


        public IActionResult Index()
        {

            var listbimta = new ListBimTaModel().initBimTa();

            return View(listbimta);
        }
        public IActionResult RenderTrademark()
        {
            var listTrademark = new ListBimTaModel().initBimTrademark();
            return View(listTrademark);
        }



        public IActionResult LoadBimTa(List<Product> BimTaList)
        {
            return PartialView("_BimTaFilter", BimTaList);
        }



        [HttpGet]
        public IActionResult SearchFilter(string jsonprd)
        {

            QuerySearch? qry = JsonConvert.DeserializeObject<QuerySearch>(jsonprd);

            var products = new ListBimTaModel().initBimTa();
            productsSearchedBrand = products;
            try
            {

                if (qry.Product_trademark.Count != 0 || qry.Product_type.Count != 0 || qry.Product_size.Count != 0)
                {
                    productsSearchedBrand = (from product in products
                                             where qry.Product_trademark.Contains(product.ProductDetail.product_trademark)
                                             || qry.Product_type.Contains(product.ProductDetail.product_type)
                                             || qry.Product_size.Contains(product.ProductDetail.product_size)
                                             select product).ToList();
                }

            }
            catch (ArgumentNullException)
            {
                return Json("Nothing");
            }
            string value = string.Empty;
            value = JsonConvert.SerializeObject(productsSearchedBrand, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(value);
        }

        public IActionResult OrderFilter(string jsonprd)
        {

            QuerySearch? qry = JsonConvert.DeserializeObject<QuerySearch>(jsonprd);

            var products = new ListBimTaModel().initBimTa();
            productsSearchedBrand = products;
            try
            {
                switch (qry.orderType)
                {
                    case "bestDis":
                        productsSearchedBrand = productsSearchedBrand.OrderByDescending(x => x.Product_DegreePercent).ToList();
                        break;
                    case "priceAsc":
                        productsSearchedBrand = productsSearchedBrand.OrderBy(x => x.Product_Price).ToList();
                        break;
                    case "priceDesc":
                        productsSearchedBrand = productsSearchedBrand.OrderByDescending(x => x.Product_Price).ToList();
                        break;
                    default:
                        productsSearchedBrand = productsSearchedBrand.ToList();
                        break;
                }

              

                string pageSize = qry.totalPage;
                string pageNumberCur = (qry.pageNumber ?? "1");

                productsSearchedBrand = productsSearchedBrand.Skip(Int32.Parse(pageSize) * (Int32.Parse(pageNumberCur) - 1)).Take(10).ToList();
              
              
            }
            catch (ArgumentNullException)
            {
                return Json("Nothing");
            }
            string value = string.Empty;
            value = JsonConvert.SerializeObject(productsSearchedBrand, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(value);
        }
   
    }
}
