using System;

namespace MAD.API.Salesforce.Domain
{
    public class Survey : ISalesforceEntity
    {
        // Survey ID
        public string Id { get; set; }

        // Owner ID
        public string OwnerId { get; set; }

        // Deleted
        public bool IsDeleted { get; set; }

        // Name
        public string Name { get; set; }

        // Currency ISO Code
        public string CurrencyIsoCode { get; set; }

        // Created Date
        public DateTime CreatedDate { get; set; }

        // Created By ID
        public string CreatedById { get; set; }

        // Last Modified Date
        public DateTime LastModifiedDate { get; set; }

        // Last Modified By ID
        public string LastModifiedById { get; set; }

        // System Modstamp
        public DateTime SystemModstamp { get; set; }

        // Last Viewed Date
        public DateTime LastViewedDate { get; set; }

        // Last Referenced Date
        public DateTime LastReferencedDate { get; set; }

        // Number of Versions
        public int TotalVersionsCount { get; set; }

        // Developer Name
        public string DeveloperName { get; set; }

        // Description
        public string Description { get; set; }

        // Survey Version ID
        public string ActiveVersionId { get; set; }

        // Type
        public string SurveyType { get; set; }

        // Survey Version ID
        public string LatestVersionId { get; set; }

        // Namespace Prefix
        public string NamespacePrefix { get; set; }
    }
}
