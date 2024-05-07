using CodeBeat.Services.AuthAPI.Models;

namespace CodeBeat.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string>roles);
    }
}
