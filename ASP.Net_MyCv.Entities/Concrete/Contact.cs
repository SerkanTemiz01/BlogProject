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
    public class Contact :IContact,IBaseEntity
    {
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? Message { get; set; }
    }
}
