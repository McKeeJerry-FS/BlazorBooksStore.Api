using BooksStore.Api.Models;

namespace BooksStore.Api.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<LoginResponse> LoginAsync(LoginRequest model);
    }
}
