using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FFriend.Infra.InversionOfControl
{
    public class DependencyInjection
    {
        public static void Inject(IServiceCollection service, ConfigurationManager config)
        {
            //service.AddScoped<IFriendService, FriendService>();
            //service.AddScoped<IFriendRepository, FriendRepository>();
            service.AddDbContext<FFDbContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("FriendDB"),
                    b => b.MigrationsAssembly("FFriend.Infra"));
            });
        }
    }
}