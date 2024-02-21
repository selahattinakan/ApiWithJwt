using ApiTest.Models;

namespace ApiTest.Interfaces
{
    public interface ITokenService
    {
        public Task<TokenResponse> GenerateToken(TokenRequest request);
    }
}
