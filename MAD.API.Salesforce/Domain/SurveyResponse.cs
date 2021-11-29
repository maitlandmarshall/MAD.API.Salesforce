using System;

namespace MAD.API.Salesforce.Domain
{
    public class SurveyResponse : ISalesforceEntity
    {
        // Survey Response ID
        public string Id { get; set; }

        // Deleted
        public bool IsDeleted { get; set; }

        // Response Name
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

        // Survey Invitation ID
        public string InvitationId { get; set; }

        // Interview ID
        public string InterviewId { get; set; }

        // Interview GUID
        public string InterviewGuid { get; set; }

        // Response Submitter ID
        public string SubmitterId { get; set; }

        // Response Status
        public string Status { get; set; }

        // Response Language
        public string Language { get; set; }

        // Response Completion Date and Time
        public DateTime CompletionDateTime { get; set; }

        // Response IP Address
        public string IpAddress { get; set; }

        // Response Latitude
        public double Latitude { get; set; }

        // Response Longitude
        public double Longitude { get; set; }

        // Response Location
        public string Location { get; set; }

        // Survey Version ID
        public string SurveyVersionId { get; set; }

        // Survey ID
        public string SurveyId { get; set; }
    }
}
