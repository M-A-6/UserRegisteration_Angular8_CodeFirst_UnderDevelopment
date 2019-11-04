using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using APP.MODEL.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace APP.BUSINESS
{
    public class AccountService : IAccountService
    {

        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountService(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<IdentityResult> Register(RegisterViewModel register)
        {

            var user = new IdentityUser
            {
                UserName = register.Email,
                Email = register.Email
            };
            return await userManager.CreateAsync(user, register.Password);
        }

        public async Task<SignInResult> Login(LoginViewModel login)
        {
            return await signInManager.PasswordSignInAsync(login.Email, login.Password, login.RememberMe, false);
        }
        public async Task SignIn(string email)
        {
             await signInManager.SignInAsync(userManager.FindByEmailAsync(email).Result,isPersistent:false);
        }
    }

     
}
