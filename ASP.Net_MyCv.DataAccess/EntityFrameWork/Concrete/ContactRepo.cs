using ASP.Net_MyCv.DataAccess.Abstract;
using ASP.Net_MyCv.Entities.Abstract;
using ASP.Net_MyCv.Entities.Concrete;
using CurriculumVitae.DataAccess.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_MyCv.DataAccess.EntityFrameWork.Concrete
{
    public class ContactRepo : BaseRepo<Contact>, IContactRepo
    {
        public ContactRepo(CvDbContext cvDbContext) : base(cvDbContext)
        {
        }
    }
}
