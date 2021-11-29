using System;

namespace MAD.API.Salesforce.Domain
{
    public class SurveySubject : ISalesforceEntity
    {
        // Object Relationship ID
        public string Id { get; set; }

        // Deleted
        public bool IsDeleted { get; set; }

        // Record Name
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

        // Parent ID
        public string ParentId { get; set; }

        // Subject ID
        public string SubjectId { get; set; }

        // Survey ID
        public string SurveyId { get; set; }

        // Related Object
        public string SubjectEntityType { get; set; }

        // Survey Response ID
        public string SurveyResponseId { get; set; }

        // Survey Invitation ID
        public string SurveyInvitationId { get; set; }
    }
}
