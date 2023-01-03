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
    public class Project :IProject,IBaseEntity
    {
        public Guid ProjectID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime ProjectDate { get; set; }
        public string ProjectPicture { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
