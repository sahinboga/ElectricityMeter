using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Ninject
{
	public class BusinessModule:NinjectModule
	{
		public override void Load()
		{
			Bind<ICompanyService>().To<CompanyManager>().InSingletonScope();
			Bind<ICompanyDal>().To<EfCompanyDal>().InSingletonScope();

			Bind<IMeterService>().To<MeterManager>().InSingletonScope();
			Bind<IMeterDal>().To<EfMeterDal>().InSingletonScope();

			Bind<IMeterDetailService>().To<MeterDetailManager>().InSingletonScope();
			Bind<IMeterDetailDal>().To<EfMeterDetailDal>().InSingletonScope();

			Bind<ICityService>().To<CityManager>().InSingletonScope();
			Bind<ICityDal>().To<EfCityDal>().InSingletonScope();

			Bind<IDistrictService>().To<DistrictManager>().InSingletonScope();
			Bind<IDistrictDal>().To<EfDistrictDal>().InSingletonScope();
		}
	}
}
