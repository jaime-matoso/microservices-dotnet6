using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeekShopping.ProductAPI.Data.ValueObject
{
    public class ProductVO
    {
        public string Name { get; set; }
       
        public string Description { get; set; }

        public decimal Price { get; set; }

        public string CategoryName { get; set; }

        public string Image_Url { get; set; }
    }
}
