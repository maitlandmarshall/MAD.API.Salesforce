using Salesforce.Force;

namespace MAD.API.Salesforce
{
    public class SalesforceApiClient
    {
        public string InstanceUrl { get; set; }

        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }

        public string Id { get; set; }

        public string ApiVersion { get; set; }

        public ForceClient Api { get; set; }
    }
}
