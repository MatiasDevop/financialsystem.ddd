using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    [Table("Suggestion")]
    public class Suggestion: Base
    {
        [Display(Name = "Suggestion")]
        public string Description { get; set; }

        [Display(Name = "User Email")]
        public string UserEmail { get; set; }
    }
}
