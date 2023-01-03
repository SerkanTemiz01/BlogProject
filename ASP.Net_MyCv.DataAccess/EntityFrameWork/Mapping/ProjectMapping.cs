
using ASP.Net_MyCv.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae.DataAccess.EntityFramework.Mapping
{
    public class ProjectMapping : BaseEntityTypeConfig<Project>
    {
        public override void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(x => x.ProjectID);
            builder.Property(x => x.Name).HasMaxLength(25);
            builder.Property(x => x.Description).HasMaxLength(25);
            builder.Property(x => x.ProjectPicture).IsRequired(false);
            builder.Property(x => x.Description).IsRequired(false);


            base.Configure(builder);
        }
    }
}
