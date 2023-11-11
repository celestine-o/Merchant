using System.ComponentModel.DataAnnotations;

namespace Merchant.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public string Amount { get; set; }
        public string IsComplete { get; set; }
        public virtual Order Order { get; set; }
    }
}
