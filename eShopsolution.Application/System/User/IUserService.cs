using System.Threading.Tasks;
using eShopSolution.ViewModels.System.Users;

namespace eShopsolution.Application.System.User
{
    public interface IUserService
    {
        Task<string> Authencate(LoginRequest request);

        Task<bool> Register(RegisterRequest request);
    }
}