using ApiTest.Models;

namespace ApiTest.Interfaces
{
    public interface IAuthService
    {
        public Task<LoginResponse> LoginUserAsync(LoginRequest request);
    }
}
