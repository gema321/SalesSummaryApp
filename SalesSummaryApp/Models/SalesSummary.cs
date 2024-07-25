using System.ComponentModel.DataAnnotations;

namespace SalesSummaryApp.Models
{
    public class SalesSummary
    {
        [Key]
        public int Id { get; set; }
        public string Item { get; set; }
        public decimal Revenue { get; set; }
    }
}
