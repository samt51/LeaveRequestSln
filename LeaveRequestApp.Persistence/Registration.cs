using LeaveRequestApp.Appilication.Interfaces.AutoMapper;
using LeaveRequestApp.Appilication.Interfaces.Repositories;
using LeaveRequestApp.Appilication.Interfaces.UnitOfWorks;
using LeaveRequestApp.Persistence.Context;
using LeaveRequestApp.Persistence.Repositories;
using LeaveRequestApp.Persistence.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LeaveRequestApp.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services,IConfiguration configuration) 
        {
            services.AddDbContext<AppDbContext>(opt => 
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

            services.AddSingleton<IMapper, AutoMapper.Mapper>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}