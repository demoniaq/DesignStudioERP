using DesignStudioErp.Application.Interfaces.Context;
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
