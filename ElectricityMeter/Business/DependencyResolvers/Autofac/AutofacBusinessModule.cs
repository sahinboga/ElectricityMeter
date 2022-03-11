using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
	public class AutofacBusinessModule:Module
	{
		protected override void Load(ContainerBuilder builder)
		{

			builder.RegisterType<CompanyManager>().As<ICompanyService>().SingleInstance();
			builder.RegisterType<EfCompanyDal>().As<ICompanyDal>().SingleInstance();

			builder.RegisterType<MeterManager>().As<IMeterService>().SingleInstance();
			builder.RegisterType<EfMeterDal>().As<IMeterDal>().SingleInstance();

			builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();
			builder.RegisterType<EfCityDal>().As<ICityDal>().SingleInstance();

			builder.RegisterType<DistrictManager>().As<IDistrictService>().SingleInstance();
			builder.RegisterType<EfDistrictDal>().As<IDistrictDal>().SingleInstance();

			/*var assembly = System.Reflection.Assembly.GetExecutingAssembly();

			builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
				.EnableInterfaceInterceptors(new Castle.DynamicProxy.ProxyGenerationOptions()
				{
					Selector = new AspectInterceptorSelector()
				}).SingleInstance();*/
		}
	}
}
