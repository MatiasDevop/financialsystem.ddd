using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class Product : Base
    {
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Active")]
        public bool Active { get; set; }

        
    }
}
