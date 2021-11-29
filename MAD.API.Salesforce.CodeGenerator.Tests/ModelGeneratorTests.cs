using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MAD.API.Salesforce.CodeGenerator.Tests
{
    [TestClass()]
    public class ModelGeneratorTests
    {
        [DataTestMethod()]
        [DataRow("Survey")]
        [DataRow("SurveyResponse")]
        [DataRow("SurveyQuestion")]
        [DataRow("SurveyQuestionChoice")]
        [DataRow("SurveyQuestionScore")]
        [DataRow("SurveyQuestionResponse")]
        public async Task Generate_AndWriteToFileSystem(string entityName)
        {
            var sp = this.GetServiceProvider();
            var modelGenerator = sp.GetRequiredService<ModelGenerator>();

            var code = await modelGenerator.Generate(entityName, "MAD.API.Salesforce.Domain");
            var filePath = Path.Combine(@"..\..\..\..\", @"MAD.API.Salesforce\Domain", $"{entityName}.cs");

            await File.WriteAllTextAsync(filePath, code);
        }

        private IServiceProvider GetServiceProvider()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("testsettings.Local.json", true)
                .Build();

            var services = new ServiceCollection();
            services.AddCodeGenerator(cfg =>
            {
                configuration.Bind(cfg);
            });

            return services.BuildServiceProvider();
        }
    }
}