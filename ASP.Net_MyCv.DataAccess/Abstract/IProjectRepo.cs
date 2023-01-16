using ASP.Net_MyCv.Core.DataAccess.Abstract;
using ASP.Net_MyCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_MyCv.DataAccess.Abstract
{
    public interface IProjectRepo :IBaseRepo<Post>
    {
    }
}
