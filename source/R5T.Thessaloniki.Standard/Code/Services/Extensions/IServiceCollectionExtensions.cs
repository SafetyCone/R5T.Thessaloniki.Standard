using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Thessaloniki.Default;


namespace R5T.Thessaloniki.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddCTempTemporaryDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddSingleton<ITemporaryDirectoryPathProvider, CTempTemporaryDirectoryPathProvider>();

            return services;
        }
    }
}
