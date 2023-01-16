using ASP.Net_MyCv.Business.Models.AutoMapper;
using ASP.Net_MyCv.Business.Services.LoginServices;
using ASP.Net_MyCv.DataAccess.Abstract;
using ASP.Net_MyCv.DataAccess.EntityFrameWork.Concrete;
using Autofac;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_MyCv.Business.Models.IoC
{
	public class DependencyResolver: Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			//builder.RegisterType<BaseRepo>().As<IBaseRepo>().InsatancePerLifeTimeScope();

			builder.Register(context => new MapperConfiguration(cfg =>
			{
				//Register Mapper Profile
				//Mapping dosyamızıda buraya ekliyoruz gidip startup'ta eklemek zorunda kalmayalım zaten burasının görevi oraya sağlamak olacak.
				cfg.AddProfile<Mapping>();
			}
			)).AsSelf().SingleInstance();


			builder.RegisterType<LoginService>().As<ILoginService>().InstancePerLifetimeScope();
			builder.RegisterType<AdminRepo>().As<IAdminRepo>().InstancePerLifetimeScope();
			builder.RegisterType<UserRepo>().As<IUserRepo>().InstancePerLifetimeScope();


			builder.Register(c =>
			{
				//This resolves a new context that can be used later.
				var context = c.Resolve<IComponentContext>();
				var config = context.Resolve<MapperConfiguration>();
				return config.CreateMapper(context.Resolve);
			})
			.As<IMapper>()
			.InstancePerLifetimeScope();

			base.Load(builder);
		}
	}
}
