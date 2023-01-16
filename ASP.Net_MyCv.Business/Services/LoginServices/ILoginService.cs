using ASP.Net_MyCv.Business.Models.DTOs;
using ASP.Net_MyCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_MyCv.Business.Services.LoginServices
{
    public interface ILoginService
    {
        Task<User> Login(LoginDTO loginDTO);


	}
}
