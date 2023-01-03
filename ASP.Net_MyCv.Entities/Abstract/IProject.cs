using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_MyCv.Entities.Abstract
{
    public interface IProject
    {
        Guid ProjectID { get; set; }
        string Name { get; set; }
        string? Description { get; set; }
        DateTime ProjectDate { get; set; }
        string ProjectPicture { get; set; }
    }
}
