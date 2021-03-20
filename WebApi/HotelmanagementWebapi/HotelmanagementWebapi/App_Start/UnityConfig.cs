using Hotelmanagement.BAL.Interface;
using Hotelmanagement.BAL;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace HotelmanagementWebapi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IHotel, Hotel>();
            container.RegisterType<IRoom, Room>();
            container.AddNewExtension<UnityHelper>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}