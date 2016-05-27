using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkwasiN_MVC_2016_05.Models
{
    public class Store
    {
        public virtual int StoreId { get; set; }
        [Required, MinLength(2), DisplayName("Store Name")]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public List<Product> Products { get; set; }
    }
}