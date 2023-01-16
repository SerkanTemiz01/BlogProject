
using ASP.Net_MyCv.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae.DataAccess.EntityFramework.Mapping
{
    public class ProjectMapping : BaseEntityTypeConfig<Post>
    {
        public override void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.PostID);
            builder.Property(x => x.Name).HasMaxLength(25);
            builder.Property(x => x.Description).HasMaxLength(25);
            builder.Property(x => x.ProjectPicture).IsRequired(false);
            builder.Property(x => x.Description).IsRequired(false);


            base.Configure(builder);
        }
    }
}
