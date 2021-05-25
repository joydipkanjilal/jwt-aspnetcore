using JWTASPNetCore.Models;

namespace JWTASPNetCore
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, UserDTO user);
        //string GenerateJSONWebToken(string key, string issuer, UserDTO user);
        bool IsTokenValid(string key, string issuer, string token);
    }
}
