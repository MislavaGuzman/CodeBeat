
using CodeBeat.Web.Models;

namespace CodeBeat.Web.Service.IService
{
    public interface IAuthService
    {
        Task<ResponseDto?>LoginAsync(LoginRequestDto loginRequestDto);
        Task<ResponseDto?> RegisterAsync(RegistrationRequestDto resgistrationRequestDto);
        Task<ResponseDto?> AssingnRoleAsync(RegistrationRequestDto resgistrationRequestDto);

    }
}
