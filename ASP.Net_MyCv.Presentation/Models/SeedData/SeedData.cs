using ASP.Net_MyCv.Core.Enums;
using ASP.Net_MyCv.Entities.Concrete;
using CurriculumVitae.DataAccess.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ASP.Net_MyCv.Presentation.Models.SeedData
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope=app.ApplicationServices.CreateScope();
            var dbContext = scope.ServiceProvider.GetService<CvDbContext>();
            dbContext.Database.Migrate();


            if (dbContext.Users.Where(x=>x.Roles==Roles.Admin).Count() == 0)
            {
                dbContext.Users.Add(new User()
                {
                    UserId = Guid.NewGuid(),
                    UserName = "SerkanTe",
                    Password = "1234Admin",
                    CreatedDate = DateTime.Now,
                    Roles=Roles.Admin
                }) ;

            }
            if (dbContext.Users.Where(x=>x.Roles==Roles.User).Count() == 0)
            {
                dbContext.Users.Add(new User()
                {
                    UserId = Guid.NewGuid(),
                    UserName = "Jonny",
                    Password = "1234",
                    CreatedDate = DateTime.Now,
                    Roles=Roles.User
                });

            }
            dbContext.SaveChanges();
        }
    }
}
