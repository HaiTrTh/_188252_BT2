namespace _188252_BT2.Models
{
    public class Product
    {
        public double Product_Id { get; set; }
        public string Product_Name { get; set; }
        public decimal Product_Price { get; set; }
        public decimal Product_OldPrice { get; set; }
        public decimal Product_DegreePercent { get; set; }
        public string Product_Img { get; set; }
        public ProductDetailModel ProductDetail { get; set; }

        public  List<string> ProductListImg { get; set; }


     
        public string ConvertNumber(decimal price)
        {
            var NewPrice = price.ToString();
            var length = NewPrice.Length;
            while (length > 0)
            {
                if (length - 3 > 0)
                {
                    NewPrice = NewPrice.Insert(length - 3, ".");
                }
                length = length - 3;
            }
            return NewPrice;
        }

        public decimal CaculatePrice(decimal oldprice, decimal percent)
        {
            decimal price;
            price = (oldprice * percent) / 100;
            return price;
        }

       


    }
    public class QuerySearch
    {
        public List<string> Product_type { get; set; }

        public List<string> Product_trademark { get; set; }
        public List<string> Product_size { get; set; }
        public string totalPage { get; set; }

        public string pageNumber { get; set; }
        
        public string orderType { get; set; }


    }
}
