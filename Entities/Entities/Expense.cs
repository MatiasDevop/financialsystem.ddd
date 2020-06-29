using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    [Table("Purchase")]
    public class Expense: Base
    {
        [Display(Name = "Value")]
        public decimal Valor { get; set; }

        [Display(Name = "Month")]
        public int Month { get; set; }

        [Display(Name = "Year")]
        public int Year { get; set; }

        [Display(Name = "ExpenseType")]
        public EnumExpenseType ExpenseType { get; set; }

        [Display(Name = "Date Registerd")]
        public DateTime RegisteredDate { get; set; }

        [Display(Name = "Changed date")]
        public DateTime ChangedDate { get; set; }

        [Display(Name = "Payment time")]
        public DateTime PaymentDate { get; set; }

        [Display(Name = "Expiration date")]
        public DateTime ExpirationDate { get; set; }

        [Display(Name = "Payment")]
        public bool Payment { get; set; }

        [NotMapped]
        public bool ExpenseDelayed { get; set; }


        [Display(Name = "Category")]
        [ForeignKey("Category")]
        [Column(Order = 1)]
        public int IdCategory { get; set; }
        public virtual Category Category { get; set; }


    }
}
