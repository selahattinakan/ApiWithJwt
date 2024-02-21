using ApiTest.Interfaces;
using ApiTest.Models;

namespace ApiTest.Services
{
    public class AuthService : IAuthService
    {
        readonly ITokenService tokenService;

        public AuthService(ITokenService tokenService)
        {
            this.tokenService = tokenService;
        }
        public async Task<LoginResponse> LoginUserAsync(LoginRequest request)
        {
            LoginResponse response = new();

            if (string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (request.Username == "sakan" && request.Password == "1q2w3e4r")
            {
                var generatedTokenInformation = await tokenService.GenerateToken(new TokenRequest { Username = request.Username });

                response.AuthenticateResult = true;
                response.AuthToken = generatedTokenInformation.Token;
                response.AccessTokenExpireDate = generatedTokenInformation.TokenExpireDate;
            }

            return response;
        }
    }
}
