
using ASP.Net_MyCv.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae.DataAccess.EntityFramework.Mapping
{
    public class UserMapping: BaseEntityTypeConfig<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.UserId);
            builder.Property(x => x.UserName).HasMaxLength(25);
            builder.Property(x => x.Password).HasMaxLength(25);          


            base.Configure(builder);
        }
    }
}
