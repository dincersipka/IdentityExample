using IdentityExample.Application.Abstractions.Token;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace IdentityExample.Infrastructure.Services.Token
{
    public class TokenHandler : ITokenHandler
    {
        private readonly IConfiguration _Configuration;

        public TokenHandler(IConfiguration Configuration)
        {
            _Configuration = Configuration;
        }

        public Application.DTOs.Token CreateToken()
        {
            Application.DTOs.Token AccessToken = new();

            SymmetricSecurityKey SecurityKey = new(Encoding.UTF8.GetBytes(_Configuration["Token:SecretKey"]));

            SigningCredentials SigningCredentials = new(SecurityKey, SecurityAlgorithms.HmacSha256);

            AccessToken.Expiration = DateTime.UtcNow.AddHours(1);

            JwtSecurityToken JwtSecurityToken = new(
                audience: _Configuration["Token:Audience"],
                issuer: _Configuration["Token:Issuer"],
                expires: AccessToken.Expiration,
                notBefore: DateTime.UtcNow,
                signingCredentials: SigningCredentials);

            AccessToken.AccessToken = new JwtSecurityTokenHandler().WriteToken(JwtSecurityToken);

            return AccessToken;
        }
    }
}
