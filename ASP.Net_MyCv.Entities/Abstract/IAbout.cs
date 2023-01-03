using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_MyCv.Entities.Abstract
{
    public interface IAbout
    {
         Guid ID { get; set; }
         string Header { get; set; }
         string? Description { get; set; }
         DateTime PostDate { get; set; }
         string? Picture { get; set; }
    }
}
