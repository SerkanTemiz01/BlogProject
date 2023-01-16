using ASP.Net_MyCv.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_MyCv.Entities.Abstract
{
    public interface IUser
    {
        Guid UserId { get; set; }

        string UserName { get; set; }
        string Password { get; set; }
		public Roles Roles { get; set; }

	}
}
