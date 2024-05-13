namespace Mango.Services.CouponAPI.Controllers.Models
{
    public class Coupon
    {
        public int CouponId { get; set; }
        public string CouponName { get; set; } = String.Empty;
        public string DiscountAmout{ get; set; } = String.Empty;
        public int MinAmout { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
