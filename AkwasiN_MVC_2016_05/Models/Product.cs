using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AkwasiN_MVC_2016_05.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required, DisplayName("Product Name")]
        public string Name { get; set; }
        public string ProductText { get; set; }
        [Required, MinLength(4)]
        public int ProductNumber { get; set; }
        [Required, Range(1,20000)]
        public int Price { get; set; }
        public int ProductInStock { get; set; }
    }
}