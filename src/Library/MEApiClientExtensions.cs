using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ME.Sdk.Library
{

    public static class MEApiClientExtensions
{
    /// <summary>
    /// Adds ME APIs Client to the specified <see cref="IServiceCollection" />.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> for adding services.</param>
    /// <param name="configuration">Represents a set of key/value application configuration properties.</param>
    public static IServiceCollection AddMEApiClient(this IServiceCollection services, IConfiguration configuration)
    {
        if (services == null) throw new ArgumentNullException(nameof(services));
        if (configuration == null) throw new ArgumentNullException(nameof(configuration));

        var settings = configuration.GetSection(nameof(MEApiSettings)).Get<MEApiSettings>() ?? new MEApiSettings();
        services.AddSingleton<IMEApiClient>(_ => new MEApiClient(settings));
        return services;
    }
}
}
