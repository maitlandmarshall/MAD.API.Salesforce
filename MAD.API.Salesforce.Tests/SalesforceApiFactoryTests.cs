using MaitlandsInterfaceFramework.Core.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Salesforce.Force;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MAD.API.Salesforce.Tests
{
    [TestClass]
    public class SalesforceApiFactoryTests
    {
        public class TestConfig
        {
            public string SalesforceConsumerKey { get; set; }
            public string SalesforceConsumerSecret { get; set; }
            public string SalesforceAccessToken { get; set; }
            public string SalesforceRefreshToken { get; set; }
        }

        public class Account
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }

        ForceClient client;

        [TestInitialize]
        public async Task Initialize()
        {
            TestConfig config = JsonConvert.DeserializeObject<TestConfig>(File.ReadAllText("ApiKey.txt"));

            if (string.IsNullOrEmpty(config.SalesforceRefreshToken))
            {
                client = await new SalesforceApiFactory().GetApiClientWithRefreshToken(config.SalesforceConsumerKey, config.SalesforceConsumerSecret, config.SalesforceRefreshToken);
            }
            else
            {
                client = await new SalesforceApiFactory().GetApiClientWithAccessToken(config.SalesforceConsumerKey, config.SalesforceConsumerSecret, config.SalesforceAccessToken);
            }
            
        }

        [TestMethod]
        public async Task GetApiClientIsAlreadyAuthenticated()
        {
            SalesforceApiFactory factory = new SalesforceApiFactory();

            var accountResult = await this.client.QueryAsync<Account>("SELECT Id, Name, Description FROM Account");

            Assert.IsTrue(accountResult.Records.Any());
        }
    }
}
