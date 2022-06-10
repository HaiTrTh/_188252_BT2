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
        public IActionResult ProductImgs(int id)
        {
            ProductListModel productListModel = new ProductListModel();
            var productList = productListModel.initProducts();
            var product = productList.First(x => x.Product_Id == id);
            return View(product);
        }

    }
}
