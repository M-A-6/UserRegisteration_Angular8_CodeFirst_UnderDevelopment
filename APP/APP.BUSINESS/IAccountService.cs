using APP.MODEL.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APP.BUSINESS
{
    public interface IAccountService
    {
        Task<IdentityResult> Register(RegisterViewModel register);
        Task<SignInResult> Login(LoginViewModel login);
        Task SignIn(string email);
    }
}
