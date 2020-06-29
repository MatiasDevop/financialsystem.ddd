using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    [Table("ItemPurchase")]
    public class ItemPurchase: Base
    {
        [Display(Name = "Value")]
        public decimal Value { get; set; }

        [Display(Name = "Purchase")]
        public bool Purchased { get; set; }

        [Display(Name = "Date Registered")]
        public DateTime DateRegistered { get; set; }

        [Display(Name = "Date changed")]
        public DateTime DateChanged { get; set; }

        [Display(Name = "Date Purchased")]
        public DateTime DatePuchased { get; set; }


        [Display(Name = "Puchase")]
        [ForeignKey("Purchase")]
        [Column(Order = 1)]
        public int IdPurchase { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}
