﻿using System.ComponentModel;

namespace GeekShopping.Web.Models
{
    public class ProductModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        [DisplayName("Category")]
        public string CategoryName { get; set; }
        
        [DisplayName("Image Url")]
        public string Image_Url { get; set; }
    }
}
