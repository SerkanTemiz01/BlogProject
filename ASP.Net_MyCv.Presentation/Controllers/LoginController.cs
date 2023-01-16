using ASP.Net_MyCv.Business.Models.DTOs;
using ASP.Net_MyCv.Business.Services.LoginServices;
using ASP.Net_MyCv.Core.Enums;
using ASP.Net_MyCv.Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;

namespace ASP.Net_MyCv.Presentation.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
       
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            var loggedUSer = await _loginService.Login(loginDTO);
          
            if (loggedUSer != null)
            {
                var jsonUser = JsonConvert.SerializeObject(loggedUSer);

                HttpContext.Session.SetString("loggedUser", jsonUser);

                var claims = new List<Claim>();
				claims.Add(new Claim(ClaimTypes.Role, loggedUSer.Roles.ToString()));
				var userIdentity = new ClaimsIdentity(claims, "Login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

				if (loggedUSer.Roles == Roles.Admin)
				{
					return RedirectToAction("Index", "Admin");
				}
				if (loggedUSer.Roles == Roles.User)
				{
					return RedirectToAction("Index", "Site");
				}
				await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
				HttpContext.Response.Cookies.Delete(CookieAuthenticationDefaults.AuthenticationScheme);
			}


			return View(loginDTO);
        }


        public async Task<IActionResult> SignUp()
        {
            return View();
        }

        [HttpPost]
		public async Task<IActionResult> SignUp(User user)
		{
			return View();
		}

		public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

    }
}
