using LeaveRequestApp.Appilication.EventHandler.CumulativeLeaveRequestEventListener;
using LeaveRequestApp.Appilication.Interfaces.AutoMapper;
using LeaveRequestApp.Appilication.Interfaces.Repositories;
using LeaveRequestApp.Domain.Events;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace LeaveRequestApp.Appilication
{
    public static class Registration
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));
            services.AddSingleton<EventDispatcher>();
            services.AddScoped<CumulativeLeaveRequestCreatedEventListener>();

          

      


        }
    }
}
