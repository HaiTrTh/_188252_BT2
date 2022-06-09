namespace _188252_BT2.Models
{
    public class ProductSearch : Product
    {
        public string _Product_Price { get; set; }

        public string _Product_OldPrice { get; set; }    
        
        public ProductSearch(){
            
            this._Product_Price = "";
            this._Product_OldPrice = "";
        }
    }
}
