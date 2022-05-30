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

        //public IActionResult ProductDetail()
        //{
        //    var listproduct = new ProductListModel().initProducts();

        //    return View(listproduct);
        //}

        public IActionResult ProductDetail(int id)
        {
            var product = new ProductListModel().initProducts().Where(product => product.Product_Id == id);
            var listproduct = new ProductListModel();
            
            return View(product);
        }

        //public IActionResult ProductDetail(int id)
        //{

        //    var product = new Product();
        //    return View(product.Product_Id);
        //}
    }
}
