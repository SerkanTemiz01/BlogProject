using ASP.Net_MyCv.Core.Entities.Abstract;
using ASP.Net_MyCv.Core.Enums;
using ASP.Net_MyCv.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_MyCv.Entities.Concrete
{
    public class Admin :IUser,IBaseEntity
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
		public Roles Roles { get; set; }

	}
}
