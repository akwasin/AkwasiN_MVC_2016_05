using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AkwasiN_MVC_2016_05.Models
{
    public class Product
    {
        public virtual int ProductId { get; set; }
        [Required, DisplayName("Product Name"),MinLength(4)]
        public string Name { get; set; }
        public string ProductText { get; set; }
        [MinLength(4)] //CustomAttributeValidation har skapats men den krashar min CRUD
        public string ProductNumber { get; set; }
        [Required, Range(1,20000)]
        public int Price { get; set; }
        public int ProductInStock { get; set; }
        //public virtual int StoreId { get; set; }
    }
}