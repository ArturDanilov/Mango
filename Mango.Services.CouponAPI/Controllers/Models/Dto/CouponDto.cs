namespace Mango.Services.CouponAPI.Controllers.Models.Dto
{
    public class CouponDto
    {
        public int CouponId { get; set; }
        
        public string CouponName { get; set; } = String.Empty;
        
        public string DiscountAmout { get; set; } = String.Empty;
        
        public int MinAmout { get; set; }
        
        public DateTime LastUpdate { get; set; }
    }
}
