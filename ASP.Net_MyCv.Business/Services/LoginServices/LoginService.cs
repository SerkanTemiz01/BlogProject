using ASP.Net_MyCv.Business.Models.DTOs;
using ASP.Net_MyCv.DataAccess.Abstract;
using ASP.Net_MyCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ASP.Net_MyCv.Business.Services.LoginServices.LoginService;

namespace ASP.Net_MyCv.Business.Services.LoginServices
{
    public class LoginService : ILoginService
    {
        private readonly IAdminRepo _adminRepo;
        private readonly IUserRepo _userRepo;

		public LoginService(IAdminRepo adminRepo, IUserRepo userRepo)
		{
			_adminRepo = adminRepo;
			_userRepo = userRepo;
		}
		public async Task<User> Login(LoginDTO loginDTO)
        {
            var user = await _userRepo.GetDefault(x => x.UserName == loginDTO.UserName && x.Password == loginDTO.Password);

			return user;
        }
		
	}

}