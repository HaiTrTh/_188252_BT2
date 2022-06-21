namespace _188252_BT2.Models
{
    public class ListBimTaModel
    {
        public List<Product> initBimTa()
        {
            List<Product> ListBimTas = new List<Product>();

            //Huggies

            for(int index = 1; index <= 5; index++)
            {
                ListBimTas.Add(new Product()
                {
                    Product_Id = index,
                    Product_Name = "Tã quần Huggies Dry size M 68 miếng (9 - 14 kg)",
                    Product_Price = 30000 * index,
                    Product_OldPrice = 38000 * index,
                    Product_DegreePercent = 5,
                    Product_Img = "https://cdn.tgdd.vn/Products/Images/2427/78694/ta-quan-huggies-dry-size-l-68-mieng-cho-be-9-14kg-260122-032548-600x600.png",
                    ProductDetail = new ProductDetailModel()
                    {
                        product_trademark = "Huggies",
                        product_size = "M",
                        product_type= "Miếng lót sơ sinh"
                    }
                });
            }

            for (int index = 6; index <= 10; index++)
            {
                ListBimTas.Add(new Product()
                {
                    Product_Id = index,
                    Product_Name = "Tã quần Bobby Dry size S 68 miếng (9 - 14 kg)",
                    Product_Price = 30000 * (index - 5),
                    Product_OldPrice = 38000 * (index - 5),
                    Product_DegreePercent = 10,
                    Product_Img = "https://cdn.tgdd.vn/Products/Images/2427/194738/ta-quan-bobby-size-xxl-56-mieng-cho-be-tren-16kg-1-600x600.png",
                    ProductDetail = new ProductDetailModel()
                    {
                        product_trademark = "Bobby",
                        product_size = "S",
                        product_type = "Tã vãi"
                    }
                });
            }


            for (int index = 11; index <= 15; index++)
            {
                ListBimTas.Add(new Product()
                {
                    Product_Id = index,
                    Product_Name = "Tã quần MOONY Dry size L miếng (9 - 14 kg)",
                    Product_Price = 30000 * (index - 10),
                    Product_OldPrice = 38000 * (index - 10),
                    Product_DegreePercent = 25,
                    Product_Img = "https://cdn.tgdd.vn/Products/Images/2427/230494/ta-dan-moony-natural-size-m-46-mieng-cho-be-6-11kg-160622-053020-600x600.jpg",
                    ProductDetail = new ProductDetailModel()
                    {
                        product_trademark = "Moony",
                        product_size = "L",
                        product_type = "Tã người lớn"
                    }
                });
            }

            for (int index = 16; index <= 20; index++)
            {
                ListBimTas.Add(new Product()
                {
                    Product_Id = index,
                    Product_Name = "Tã quần PamPers Dry size XXL miếng (9 - 14 kg)",
                    Product_Price = 30000 * (index - 15),
                    Product_OldPrice = 38000 * (index - 15),
                    Product_DegreePercent = 20,
                    Product_Img = "https://cdn.tgdd.vn/Products/Images/2427/238823/ta-quan-pampers-super-jumbo-size-xxl-56-mieng-cho-be-15-25kg-160622-013418-600x600.jpg",
                    ProductDetail = new ProductDetailModel()
                    {
                        product_trademark = "Pampers",
                        product_size = "XXL",
                        product_type = "Tã quần"
                    }
                });
            }

            for (int index = 21; index <= 25; index++)
            {
                ListBimTas.Add(new Product()
                {
                    Product_Id = index,
                    Product_Name = "Tã quần Merries Dry size XL miếng (9 - 14 kg)",
                    Product_Price = 30000 * (index - 20),
                    Product_OldPrice = 38000 * (index - 20),
                    Product_DegreePercent = 10,
                    Product_Img = "https://cdn.tgdd.vn/Products/Images/2427/273306/ta-quan-merries-size-l-56-mieng-9-14-kg-160622-014641-600x600.jpg",
                    ProductDetail = new ProductDetailModel()
                    {
                        product_trademark = "Merries",
                        product_size = "XL",
                        product_type = "Tã vãi"
                    }
                });
            }

            for (int index = 26; index <= 30; index++)
            {
                ListBimTas.Add(new Product()
                {
                    Product_Id = index,
                    Product_Name = "Tã quần Goo.n  size XL miếng (9 - 14 kg)",
                    Product_Price = 30000 * (index - 25),
                    Product_OldPrice = 38000 * (index - 25),
                    Product_DegreePercent = 10,
                    Product_Img = "https://cdn.tgdd.vn/Products/Images/2427/85714/ta-quan-goon-friend-pants-size-l-52-mieng-9-14kg-600x600.png",
                    ProductDetail = new ProductDetailModel()
                    {
                        product_trademark = "Goon",
                        product_size = "XL",
                        product_type = "Tã quần"
                    }
                });
            }

            for (int index = 31; index <= 60; index++)
            {
                ListBimTas.Add(new Product()
                {
                    Product_Id = index,
                    Product_Name = "Tã quần IQ.baby  size XL miếng (9 - 14 kg)",
                    Product_Price = 30000 * (index - 30),
                    Product_OldPrice = 38000 * (index - 30),
                    Product_DegreePercent = 10,
                    Product_Img = "https://cdn.tgdd.vn/Products/Images/2427/259197/ta-dan-so-sinh-iqbaby-size-s3-2-cai-bich-cho-be-6-9-thang-mau-ngau-nhien-600x600.jpg",
                    ProductDetail = new ProductDetailModel()
                    {
                        product_trademark = "IQBaby",
                        product_size = "XL",
                        product_type = "Tã quần"
                    }
                });
            }


            return ListBimTas;
        }

        public List<string> initBimTrademark()
        {
            List<string> ListTrademark = new List<string>();


            ListTrademark.Add("https://cdn.tgdd.vn/Products/Images/2427/78694/ta-quan-huggies-dry-size-l-68-mieng-cho-be-9-14kg-260122-032548-600x600.png");
            ListTrademark.Add("Phttps://cdn.tgdd.vn/Products/Images/2427/193656/ta-quan-bobby-size-xl-62-mieng-cho-be-12-17kg-600x600.png");
            ListTrademark.Add("https://cdn.tgdd.vn/Products/Images/2427/230494/ta-dan-moony-natural-size-m-46-mieng-cho-be-6-11kg-6-600x600.png");
            ListTrademark.Add("https://cdn.tgdd.vn/Products/Images/2427/81469/ta-quan-merries-size-m-58-mieng-cho-be-6-11kg-150622-060355-600x600.jpg");
            ListTrademark.Add("https://cdn.tgdd.vn/Products/Images/2427/238823/ta-quan-pampers-super-jumbo-size-xxl-56-mieng-cho-be-15-25kg-600x600.png");
            ListTrademark.Add("https://cdn.tgdd.vn/Products/Images/2427/279057/ta-quan-goon-excellent-soft-size-xxxl-26-mieng-18-30kg-010522-075619-600x600.png");
            ListTrademark.Add("https://cdn.tgdd.vn/Products/Images/2427/259198/ta-dan-mau-babymommy-size-m-cho-be-cho-be-6-11kg-mau-ngau-nhien-1.jpg");
            ListTrademark.Add("https://cdn.tgdd.vn/Products/Images/2427/259197/ta-dan-so-sinh-iqbaby-size-s3-2-cai-bich-cho-be-6-9-thang-mau-ngau-nhien-1.jpg");

            return ListTrademark;
        }
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

    }
}
