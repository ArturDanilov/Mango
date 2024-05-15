using System.ComponentModel.DataAnnotations;

namespace Mango.Services.CouponAPI.Models
{
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }

        [Required]
        public string CouponCode { get; set; } = string.Empty;

        [Required]
        public int DiscountAmount { get; set; }

        public int MinAmount { get; set; }
    }
}
