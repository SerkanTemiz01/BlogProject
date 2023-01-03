
using ASP.Net_MyCv.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae.DataAccess.EntityFramework.Mapping
{
    public class AboutMapping: BaseEntityTypeConfig<About>
    {
        public override void Configure(EntityTypeBuilder<About> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Header).HasMaxLength(50);
            builder.Property(x => x.Picture).HasMaxLength(255).IsRequired(false);
            builder.Property(x => x.Description).IsRequired(false);
           

            base.Configure(builder);
        }

    }
}
