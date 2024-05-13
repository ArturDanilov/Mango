namespace Mango.Services.CouponAPI.Controllers.Models.Dto
{
    public class CouponDto
    {
        public int CouponId { get; set; }
        
        public string CouponName { get; set; } = String.Empty;

        public int DiscountAmout { get; set; }
        
        public int MinAmout { get; set; }
        
        public DateTime LastUpdate { get; set; }
    }
}
