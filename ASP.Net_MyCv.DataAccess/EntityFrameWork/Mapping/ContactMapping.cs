using ASP.Net_MyCv.Entities.Concrete;

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae.DataAccess.EntityFramework.Mapping
{
    public class ContactMapping : BaseEntityTypeConfig<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(x => x.ContactID);
            builder.Property(x => x.FirstName).HasMaxLength(25);
            builder.Property(x => x.LastName).HasMaxLength(25);
            builder.Property(x => x.Message).IsRequired(false);


            base.Configure(builder);
        }
    }
}
