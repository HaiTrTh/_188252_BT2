using Microsoft.AspNetCore.Mvc;
namespace _188252_BT2.Models
{
    public class ProductItemComponent : ViewComponent
    {
       
        public IViewComponentResult Invoke(ProductListModel listproduct)
        {
            return View(listproduct);
        }
    }
}