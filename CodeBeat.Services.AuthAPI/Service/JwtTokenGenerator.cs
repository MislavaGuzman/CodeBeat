using CodeBeat.Services.AuthAPI.Models;
using CodeBeat.Services.AuthAPI.Service.IService;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CodeBeat.Services.AuthAPI.Service
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        public readonly JWTOptions _jwTOptions;
        public JwtTokenGenerator(IOptions<JWTOptions> jwTOptions)
        {
            _jwTOptions = jwTOptions.Value;
        }
        public string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwTOptions.Secret);

            var claimList = new List<Claim>
            {
               new Claim(JwtRegisteredClaimNames.Email, applicationUser.Email),
               new Claim(JwtRegisteredClaimNames.Sub, applicationUser.Id),
               new Claim(JwtRegisteredClaimNames.Name, applicationUser.UserName)

            };

            claimList.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

            var tokenDescriptior = new SecurityTokenDescriptor
            {
                Audience = _jwTOptions.Audience,
                Issuer = _jwTOptions.Issuer,
                Subject = new ClaimsIdentity(claimList),
                Expires = DateTime.UtcNow.AddDays(4),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            };
            var token = tokenHandler.CreateToken(tokenDescriptior);
            return tokenHandler.WriteToken(token);
               
        }

        
    }
}
