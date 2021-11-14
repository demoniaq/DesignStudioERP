using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DesignStudioErp.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistance(this IServiceCollection services,
                                                    IConfiguration configuration,
                                                    string setting)
    {
        var connectionString = configuration[setting];

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        services.AddScoped<IApplicationDbContext>(provider =>
        {
            var context = provider.GetService<ApplicationDbContext>() ?? throw new NullReferenceException(nameof(ApplicationDbContext));
            return context;
        });

        return services;
    }
}
