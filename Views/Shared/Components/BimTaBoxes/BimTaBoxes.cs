using _188252_BT2.Controllers;
using _188252_BT2.Models;
using Microsoft.AspNetCore.Mvc;
namespace _188252_BT2.Models
{
    public class BimTaBoxes : ViewComponent
    {
        ListBimTaModel listBimTa = new ListBimTaModel();
        public IViewComponentResult Invoke(double intID)
        {
           
           
            var products = listBimTa.initBimTa();

            var productsSearched = (from product in products
                                    where product.Product_Id == intID
                                    select product).ToList();
            Product productA = productsSearched.First();

            return View<Product>(productA); //mặc định sẽ chạy Default.cshtml
        }
    }

}


