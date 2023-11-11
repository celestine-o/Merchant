using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Merchant.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string IsDelivered {  get; set; }
        public string Total {  get; set; }
        public string DateCreated { get; set; }


    }
}
