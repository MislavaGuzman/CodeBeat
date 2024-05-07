
using CodeBeat.Web.Models;


namespace CodeBeat.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string couponCode);
        Task<ResponseDto?> GetAllCouponsAsync();
        Task<ResponseDto?> GetCouponById(int id);
        Task<ResponseDto?> CreateCopuponsAsync(CouponDto couponDtio);
        Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDtio);
        Task<ResponseDto?> DeleteCouponAsync(int id);
    }
}
