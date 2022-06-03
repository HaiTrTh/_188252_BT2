using System.Linq;
namespace _188252_BT2.Models
{
    public class ProductListModel 
    {
    
       
        public List<Product> initProducts()
        {
            List<Product> ListProducts = new List<Product>();
            ListProducts.Add(new Product()
            {
                Product_Id = 1,
                Product_Name = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                Product_Price =  993200,
                Product_OldPrice =  1399000,
                Product_DegreePercent = 29,
                Product_Img = "/Img/0.jpg",
                ProductDetail = new ProductDetailModel()
                {
                    product_trademark = "Lego (Đan Mạch)",
                    product_type = "Đồ chơi bé trai",
                    product_type2 = "Đồ chơi lắp ráp",
                    product_age = "Từ 4 tuổi",
                    product_substance = "Nhựa",
                    product_size = "38x26x5.6",
                    product_weight = 595,
                    product_note = "Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    product_placeproduce = "Trung Quốc",

                }
            });
            ListProducts.Add(new Product()
            {
                Product_Id = 2,
                Product_Name = "Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                Product_Price =  988200,
                Product_OldPrice = 1349000,
                Product_DegreePercent = 26,
                Product_Img = "/Img/1.jpg",
                ProductDetail = new ProductDetailModel()
                {
                    product_trademark = "HOT WHEELS (Mỹ)",
                    product_type = "Đồ chơi bé trai",
                    product_type2 = "Đồ chơi nhập vai", 
                    product_age = "Từ 4 đến 8 tuổi",
                    product_substance = "Kim loại Nhựa",
                    product_size = "56x30x15 cm",
                    product_weight = 1071,
                    product_note = "Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    product_placeproduce = "Trung Quốc",

                }
            });
            ListProducts.Add(new Product()
            {
                Product_Id = 3,
                Product_Name = "Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                Product_Price = 1002400,
                Product_OldPrice = 1319000,
                Product_DegreePercent = 24,
                Product_Img = "/Img/2.jpg",
                ProductDetail = new ProductDetailModel()
                {
                    product_trademark = "Lego (Đan Mạch)",
                    product_type = "Đồ chơi bé trai",
                    product_type2 = "Đồ chơi lắp ráp",
                    product_age = "Từ 1.5 tuổi trở lên",
                    product_substance = "Nhựa",
                    product_size = "38x26x5.6",
                    product_weight = 1046,
                    product_note = "Chỉ thích hợp cho trẻ em từ 1.5 tuổi trở lên",
                    product_placeproduce = "Trung Quốc",

                }
            });
            ListProducts.Add(new Product()
            {
                Product_Id = 4,
                Product_Name = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                Product_Price =  993200,
                Product_OldPrice = 1399000,
                Product_DegreePercent = 29,
                Product_Img = "/Img/3.jpg",
                ProductDetail = new ProductDetailModel()
                {
                    product_trademark = "Lego (Đan Mạch)",
                    product_type = "Đồ chơi bé trai",
                    product_type2 = "Đồ chơi nhập vai",
                    product_age = "Từ 4 tuổi trở lên",
                    product_substance = "Nhựa",
                    product_size = "38x26x5.6",
                    product_weight = 595,
                    product_note = "Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    product_placeproduce = "Trung Quốc",

                }
            });
            ListProducts.Add(new Product()
            {
                Product_Id = 5,
                Product_Name = "Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                Product_Price =  1039200,
                Product_OldPrice =  1299000,
                Product_DegreePercent = 20,
                Product_Img = "/Img/4.jpg",
                ProductDetail = new ProductDetailModel()
                {
                    product_trademark = "Lego (Đan Mạch)",
                    product_type = "Đồ chơi bé gái",
                    product_type2 = "Đồ chơi bé trai",
                    product_type3 = "Đồ chơi lắp ráp",
                    product_age = " Từ 4 tuổi trở lên",
                    product_substance = "Nhựa",
                    product_size = "38x26x6 ",
                    product_weight = 634,
                    product_note = "Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    product_placeproduce = "Trung Quốc",

                }
            });
            ListProducts.Add(new Product()
            {
                Product_Id = 6,
                Product_Name = "Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                Product_Price =  1002000,
                Product_OldPrice = 1299000,
                Product_DegreePercent = 23,
                Product_Img = "/Img/5.jpg",
                ProductDetail = new ProductDetailModel()
                {
                    product_trademark = "Lego (Đan Mạch)",
                    product_type = "Đồ chơi bé trai",
                    product_type2 = "Đồ chơi lắp ráp",
                    product_age = "Từ 8 tuổi trở lên",
                    product_substance = "Nhựa",
                    product_size = "38x26x5.6",
                    product_weight = 672,
                    product_note = "Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    product_placeproduce = "Trung Quốc",

                }
            });
            ListProducts.Add(new Product()
            {
                Product_Id = 7,
                Product_Name = "Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
                Product_Price =  1002500,
                Product_OldPrice =  1269000,
                Product_DegreePercent = 21, 
                Product_Img = "/Img/6.jpg",
                ProductDetail = new ProductDetailModel()
                {
                    product_trademark = "Lego (Đan Mạch)",
                    product_type = "Đồ chơi bé trai",
                    product_type2 = "Đồ chơi láp ráp",
                    product_age = "Từ 6 tuổi trở lên",
                    product_substance = "Nhựa",
                    product_size = "38x26x5.6",
                    product_weight = 482,
                    product_note = "Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    product_placeproduce = "Trung Quốc",

                }
            });
            return ListProducts;
        }
            
        //public Product filterProduct()
        //{
        //    Product product = new Product();
        //    product = initProducts().Where(x=> x.Product_Name.ToLower().Contains(SearchValue.Trim().To))


        //    return product;        
        //}
       
    }

}
