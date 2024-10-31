using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace school_system.Jwt
{
    public class Token : IToken
    {
        private readonly IConfiguration configuration_;
        public Token(IConfiguration configuration)
        {
           configuration_ = configuration;
        }

        public string GeterateJwtToken()
        {
            var encodeKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration_["Jwt:Key"]));
            var increaptedKey = new SigningCredentials(encodeKey , SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: configuration_["Jwt:Issuer"],
                audience: configuration_["Jwt:Audince"],
                signingCredentials:increaptedKey,
                expires:DateTime.UtcNow.AddMinutes(30),
                claims: new[] {new Claim("name" , "mohamed") , new Claim("email" , "mo@gmail.com")}
             );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
