using System.Threading.Tasks;
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Users;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eShopSolution.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
        Task<PagedResult<UserVm>> GetUSerPagings(GetUserPagingRequest request);

        Task<bool> RegisterUser(RegisterRequest request);
    }
}