using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    [Table("Category")]
    public class Category : Base
    {
        [Display(Name = "System Code")]
        [ForeignKey("FinancialSystem")]
        [Column(Order = 1)]
        public int IdSystem { get; set; }
        public virtual FinancialSystem FinancialSystem { get; set; }
    }
}
