using System;

namespace MAD.API.Salesforce.Domain
{
    public class SurveyVersion : ISalesforceEntity
    {
        // Survey Version ID
        public string Id { get; set; }

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

        // Survey ID
        public string SurveyId { get; set; }

        // Version Number
        public int VersionNumber { get; set; }

        // Survey Status
        public string SurveyStatus { get; set; }

        // Branding Set ID
        public string BrandingSetId { get; set; }

        // Description
        public string Description { get; set; }

        // Template
        public bool IsTemplate { get; set; }
    }
}
