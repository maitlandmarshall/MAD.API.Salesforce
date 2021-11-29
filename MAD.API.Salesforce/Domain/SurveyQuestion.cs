using System;

namespace MAD.API.Salesforce.Domain
{
    public class SurveyQuestion : ISalesforceEntity
    {
        // Survey Question ID
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

        // Survey Version ID
        public string SurveyVersionId { get; set; }

        // Survey Page ID
        public string SurveyPageId { get; set; }

        // Question Type
        public string QuestionType { get; set; }

        // Developer Name
        public string DeveloperName { get; set; }

        // Is Deprecated
        public bool IsDeprecated { get; set; }

        // Question Name
        public string QuestionName { get; set; }
    }
}
