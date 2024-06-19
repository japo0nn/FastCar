using FastCarServer.Application.Common.Models;

namespace FastCarServer.Application.Common.Interfaces.Data
{
    public interface IIdentityService
    {
        Task<string?> GetUserNameAsync(string userId);

        Task<bool> AuthorizeAsync(string userId, string policyName);

        Task<(Result Result, string UserId)> CreateUserAsync(string phoneNumber, string password);

        Task<Result> DeleteUserAsync(string userId);
    }
}
