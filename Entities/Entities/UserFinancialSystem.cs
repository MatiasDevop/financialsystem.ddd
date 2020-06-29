using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    [Table("UserFinancialSystem")]
    public class UserFinancialSystem
    {
        [Display(Name = "Code")]
        public int Id { get; set; }

        [Display(Name = "User Email")]
        public string UserEmail { get; set; }

        [Display(Name = "Administrator")]
        public bool Admin { get; set; }

        [Display(Name = "Current system")]
        public bool CurrentSystem { get; set; }

        [Display(Name = "System Code")]
        [ForeignKey("FinancialSystem")]
        [Column(Order = 1)]
        public int IdSystem { get; set; }
        public virtual FinancialSystem FinancialSystem { get; set; }
    }
}
