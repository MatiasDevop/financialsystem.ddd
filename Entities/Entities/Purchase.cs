using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    [Table("Purchase")]
    public class Purchase: Base
    {
        [Display(Name = "Datetime Register")]
        public DateTime RegisteredTime { get; set; }

        [Display(Name = "Datetime Change")]
        public DateTime ChangedTime { get; set; }

        [Display(Name = "Category")]
        [ForeignKey("Category")]
        [Column(Order = 1)]
        public int IdCategory { get; set; }
        public virtual Category Category { get; set; }
    }
}
