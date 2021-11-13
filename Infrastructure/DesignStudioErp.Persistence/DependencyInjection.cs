using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using DesignStudioErp.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using DesignStudioErp.Application.Interfaces;

namespace DesignStudioErp.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration, string settingPath)
    {
        var connectionString = configuration[settingPath];
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        services.AddScoped<IApplicationDbContext>(provider =>
            provider.GetService<ApplicationDbContext>());

        return services;
    }
}
