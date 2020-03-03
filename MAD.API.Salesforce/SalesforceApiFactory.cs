using Salesforce.Common;
using Salesforce.Force;
using System;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace MAD.API.Salesforce
{
    public class SalesforceApiFactory
    {
        public Task<ForceClient> GetApiClientWithAccessToken(string consumerKey, string consumerSecret, string accessToken)
        {
            if (string.IsNullOrEmpty(consumerKey))
                throw new ArgumentException("Must have a value.", nameof(consumerKey));

            if (string.IsNullOrEmpty(consumerSecret))
                throw new ArgumentException("Must have a value.", nameof(consumerSecret));

            if (string.IsNullOrEmpty(accessToken))
                throw new ArgumentException("Must have a value.", nameof(accessToken));

            return this.GetApiClient(consumerKey, consumerSecret, accessToken, null);
        }

        public Task<ForceClient> GetApiClientWithRefreshToken(string consumerKey, string consumerSecret, string refreshToken)
        {
            if (string.IsNullOrEmpty(consumerKey))
                throw new ArgumentException("Must have a value.", nameof(consumerKey));

            if (string.IsNullOrEmpty(consumerSecret))
                throw new ArgumentException("Must have a value.", nameof(consumerSecret));

            if (string.IsNullOrEmpty(refreshToken))
                throw new ArgumentException("Must have a value.", nameof(refreshToken));

            return this.GetApiClient(consumerKey, consumerSecret, null, refreshToken);
        }

        private async Task<ForceClient> GetApiClient (string consumerKey, string consumerSecret, string accessToken, string refreshToken)
        {
            using AuthenticationClient auth = new AuthenticationClient
            {
                InstanceUrl = "https://ap16.salesforce.com",
                AccessToken = accessToken
            };

            if (!String.IsNullOrEmpty(refreshToken))
                await auth.TokenRefreshAsync(consumerKey, refreshToken, consumerSecret);

            ForceClient client = new ForceClient(auth.InstanceUrl, auth.AccessToken, auth.ApiVersion);
            FieldInfo jsonHttpClientField = client.GetType().GetField("_jsonHttpClient", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

            JsonHttpClient jsonHttpClient = jsonHttpClientField.GetValue(client) as JsonHttpClient;

            FieldInfo httpClientField = jsonHttpClient.GetType().GetField("HttpClient", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

            HttpClient httpClient = httpClientField.GetValue(jsonHttpClient) as HttpClient;

            HttpClientHandler handler = typeof(HttpMessageInvoker).GetField("_handler", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(httpClient) as HttpClientHandler;
            handler.AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate | System.Net.DecompressionMethods.None;

            return client;
        }
    }
}
