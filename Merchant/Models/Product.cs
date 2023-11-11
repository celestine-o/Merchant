using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Merchant.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        [DisplayName("Image Link")]
        public string ImageLink { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
    }
}
