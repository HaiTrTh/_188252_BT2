namespace _188252_BT2.Models
{
    public class Product
    {
        public double Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Price { get; set; }
        public string Product_OldPrice { get; set; }
        public int Product_DegreePercent { get; set; }
        public string Product_Img { get; set; }
        public ProductDetailModel ProductDetail { get; set; }
      
    }
}
