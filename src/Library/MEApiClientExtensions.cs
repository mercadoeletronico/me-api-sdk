using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ME.Sdk.Library;

public static class MEApiClientExtensions
{
    /// <summary>
    /// Adds ME APIs Client to the specified <see cref="IServiceCollection" />.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> for adding services.</param>
    /// <param name="configuration">Represents a set of key/value application configuration properties.</param>
    public static IServiceCollection AddMEApiClient(this IServiceCollection services, IConfiguration configuration)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configuration);

        var settings = configuration.GetRequiredSection(nameof(MEApiSettings)).Get<MEApiSettings>()!;
        services.AddSingleton<IMEApiClient>(_ => new MEApiClient(settings));
        return services;
    }
}
