using Salesforce.Common;
using Salesforce.Force;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MAD.API.Salesforce
{
    public class SalesforceApiClientFactory
    {
        public class SalesforceApiOptions
        {
            public string ConsumerKey { get; set; }
            public string ConsumerSecret { get; set; }
            public string InstanceEndpoint { get; set; }
            public string AuthEndpoint { get; set; }
        }

        public SalesforceApiClient GetApiClientWithAccessToken(SalesforceApiOptions options, string accessToken)
        {
            using AuthenticationClient auth = this.CreateAuthenticationClient(options.InstanceEndpoint);
            auth.AccessToken = accessToken;
            
            return this.CreateSalesforceClient(auth);
        }

        public async Task<SalesforceApiClient> GetApiClientWithRefreshToken(SalesforceApiOptions options, string refreshToken)
        {
            using AuthenticationClient auth = this.CreateAuthenticationClient(options.InstanceEndpoint);

            if (!string.IsNullOrEmpty(options.AuthEndpoint))
            {
                await auth.TokenRefreshAsync(options.ConsumerKey, refreshToken, options.ConsumerSecret, options.AuthEndpoint);
            }
            else
            {
                await auth.TokenRefreshAsync(options.ConsumerKey, refreshToken, options.ConsumerSecret);
            }

            return this.CreateSalesforceClient(auth);
        }

        public async Task<SalesforceApiClient> CreateApiClient(SalesforceApiOptions options, string username, string password)
        {
            using var auth = this.CreateAuthenticationClient(options.InstanceEndpoint);

            if (!string.IsNullOrEmpty(options.AuthEndpoint))
            {
                await auth.UsernamePasswordAsync(options.ConsumerKey, options.ConsumerSecret, username, password, options.AuthEndpoint);
            }
            else
            {
                await auth.UsernamePasswordAsync(options.ConsumerKey, options.ConsumerSecret, username, password);
            }

            // await auth.WebServerAsync(consumerKey, consumerSecret, "http://localhost:666/api/SalesforceOAuth/callback", "aPrx8euw8KQvhFGQXnYE6WJkKcZ.KVAtN6oBCpiZ3K3wmsqJ9jCbum47uHRsHETmVGM5OjDMAg==", "https://test.salesforce.com/services/oauth2/token");
            
            return this.CreateSalesforceClient(auth);            
        }

        public AuthenticationClient CreateAuthenticationClient(string instanceUrl = null)
        {
            return new AuthenticationClient(apiVersion: "v50.0")
            {
                InstanceUrl = instanceUrl
            };
        }

        private ForceClient CreateApiClient(AuthenticationClient auth)
        {
            var client = new ForceClient(auth.InstanceUrl, auth.AccessToken, auth.ApiVersion);
            var httpClient = client.GetHttpClient();
            var handler = typeof(HttpMessageInvoker).GetField("_handler", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(httpClient) as HttpClientHandler;

            handler.AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate | System.Net.DecompressionMethods.None;

            return client;
        }

        private SalesforceApiClient CreateSalesforceClient(AuthenticationClient authClient)
        {           
            return new SalesforceApiClient
            {
                Api = this.CreateApiClient(authClient),
                AccessToken = authClient.AccessToken,
                ApiVersion = authClient.ApiVersion,
                Id = authClient.Id,
                InstanceUrl = authClient.InstanceUrl,
                RefreshToken = authClient.RefreshToken
            };
        }
    }
}
