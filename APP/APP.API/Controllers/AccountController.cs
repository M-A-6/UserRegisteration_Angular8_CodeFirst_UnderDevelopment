using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP.BUSINESS;
using APP.MODEL.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IAccountService accountService;
        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [Route("register")]
        [HttpPost]
        public IActionResult Register([FromBody] RegisterViewModel register)
        {

            var result = accountService.Register(register).Result;

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }


            //if (!ModelState.IsValid || ModelState.ErrorCount > 0)
            //{
            //    var errors = ModelState.Values.SelectMany(m => m.Errors)
            //                     .Select(e => e.ErrorMessage)
            //                     .ToList();
            //    return new JsonResult(errors);
            //}

            return new JsonResult(result);

        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login([FromBody] LoginViewModel login)
        {
            var result = accountService.Login(login).Result;
            if (result.Succeeded)
            {
                accountService.SignIn(login.Email);
            }
            return new JsonResult(result);
        }

    }
}
