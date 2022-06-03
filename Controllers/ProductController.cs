using _188252_BT2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace _188252_BT2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            return View();
        }

        public IActionResult ProductDetail(int id)
        {
            CollectionDataModel model = new CollectionDataModel();
            var listproduct = new ProductListModel().initProducts();
            var product = listproduct.Find(x=>x.Product_Id == id);
            model.product = product;
            model.productList = listproduct;
            return View(model);

        }

        public IActionResult ProductImg(int id)
        {
            CollectionDataModel model = new CollectionDataModel();  
            var listproduct = new ProductListModel().initProducts();
            var product = listproduct.First(x=>x.Product_Id == id);
            model.product = product;
            model.productList = listproduct;
            model.productList[0] = product;
            return View(model);

        }



        public JsonResult Search(string pr)
        {
            var listproduct = new ProductListModel().initProducts();
            //var result = listproduct.Where(a => a.Product_Name.Contains(pr) || a.Product_Img.Contains(pr)).Take(1).Select(a => new {
            //    resultItem = a.Product_Name + a.Product_Price + a.Product_DegreePercent
            //}).ToList();      
            //return Json(result);


            var Name = (from product in listproduct
                        where product.Product_Name.StartsWith(pr)
                        select new { product });
            return Json(Name);
            //new Newtonsoft.Json.JsonSerializerSettings()
        }




    }
}
