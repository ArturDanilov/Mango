using System.ComponentModel.DataAnnotations;

namespace Mango.Services.CouponAPI.Controllers.Models
{
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }

        [Required]
        public string CouponName { get; set; } = String.Empty;

        [Required]
        public int DiscountAmout{ get; set; }
        
        public int MinAmout { get; set; }
        
        public DateTime LastUpdate { get; set; }
    }
}
