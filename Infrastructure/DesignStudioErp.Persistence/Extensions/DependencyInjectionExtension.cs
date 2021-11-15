using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DesignStudioErp.Persistence.Extensions;

/// <summary>
/// Class with extensions for DI
/// </summary>
public static class DependencyInjectionExtension
{
    /// <summary>
    /// Extension method for DI persistance level
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <param name="setting"></param>
    /// <returns></returns>
    /// <exception cref="NullReferenceException"></exception>
    public static IServiceCollection AddPersistance(this IServiceCollection services,
                                                    IConfiguration configuration,
                                                    string setting)
    {
        var connectionString = configuration[setting];

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        services.AddScoped<IApplicationContext>(provider =>
        {
            var context = provider.GetService<ApplicationDbContext>() ?? throw new NullReferenceException(nameof(ApplicationDbContext));
            return context;
        });

        return services;
    }
}
