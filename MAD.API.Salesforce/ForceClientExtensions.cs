using Salesforce.Common;
using Salesforce.Force;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MAD.API.Salesforce
{
    public static class ForceClientExtensions
    {
        public static HttpClient GetHttpClient(this ForceClient forceClient)
        {
            var jsonHttpClientField = forceClient.GetType().GetField("_jsonHttpClient", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            var jsonHttpClient = jsonHttpClientField.GetValue(forceClient) as JsonHttpClient;
            var httpClientField = jsonHttpClient.GetType().GetField("HttpClient", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            var httpClient = httpClientField.GetValue(jsonHttpClient) as HttpClient;

            return httpClient;
        }
    }
}
