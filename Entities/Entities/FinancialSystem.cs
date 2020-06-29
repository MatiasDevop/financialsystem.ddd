using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("FinancialSystem")]
    public class FinancialSystem : Base
    {
        [Display(Name = "Month System")]
        public int Month { get; set; }

        [Display(Name = "Year System")]
        public int Year { get; set; }

        [Display(Name = "Day init of Month")]
        public int DayClosed { get; set; }

        [Display(Name = "Generate copy of Expenses")]
        public bool GenerateCopyExpenses { get; set; }

        [Display(Name = "Date copied")]
        public int MonthCopied { get; set; }

        [Display(Name = "Year system copied")]
        public int YearCopied { get; set; }
    }
}