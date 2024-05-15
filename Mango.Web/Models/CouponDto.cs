namespace Mango.Web.Models
{
    public class CouponDto
    {
        public int CouponId { get; set; }

        public string CouponCode { get; set; } = string.Empty;

        public int DiscountAmout { get; set; }

        public int MinAmout { get; set; }
    }
}
