using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Merchant.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public string Quantity { get; set; }
        public string UnitPrice { get; set; }
        public string Price { get; set; }
        public virtual ICollection<Product>? Products { get; set; }


    }
}
