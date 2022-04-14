using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketApp.Models
{
    public class Product
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string BrandName { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public productType ProductType { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [DisplayFormat(DataFormatString ="{0:0.0#}")]
        [Range(0,5)]
        public decimal Review { get; set; }
        [Required]
        public DateTime ProductionDate { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        [Display(Name ="Product Image")]
        public string productImage { get; set; }
    }
}
