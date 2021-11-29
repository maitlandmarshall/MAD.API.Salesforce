using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Salesforce.Force;
using System;

namespace MAD.API.Salesforce.CodeGenerator
{
    public static class CodeGeneratorServiceCollectionExtensions
    {
        public static IServiceCollection AddCodeGenerator(this IServiceCollection serviceDescriptors, Action<SalesforceConfig> configAction)
        {
            serviceDescriptors.Configure(configAction);
            serviceDescriptors.AddTransient<SalesforceConfig>(svc => svc.GetRequiredService<IOptions<SalesforceConfig>>().Value);

            serviceDescriptors.AddTransient<ModelGenerator>();
            serviceDescriptors.AddTransient<IForceClient>(svc =>
            {
                var options = svc.GetRequiredService<SalesforceConfig>();
                return new SalesforceApiFactory().CreateApiClient(new SalesforceApiFactory.SalesforceApiOptions
                {
                    ConsumerKey = options.ConsumerKey,
                    ConsumerSecret = options.ConsumerSecret
                }, options.Username, options.Password).Result;
            });

            return serviceDescriptors;

        }
    }
}
