using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YShopSolution.ViewModels.Request.System.Users;

namespace YShopSolution.Application.System.Users
{
    public interface IUserService
    {
        Task<string> AuthencateAsync(LoginRequest request);
        Task<bool> RegisterAsync(RegisterRequest request);
    }
}
