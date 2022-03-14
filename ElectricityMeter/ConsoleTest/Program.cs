using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using System;

namespace ConsoleTest
{
	class Program
	{
		static ICompanyService service = InstanceFactory.GetInstance<ICompanyService>();
		static void Main(string[] args)
		{
			service.GetAll();
		}
	}
}
