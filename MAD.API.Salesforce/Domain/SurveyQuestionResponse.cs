using System;

namespace MAD.API.Salesforce.Domain
{
    public class SurveyQuestionResponse : ISalesforceEntity
    {
        // Survey Question Response ID
        public string Id { get; set; }

        // Deleted
        public bool IsDeleted { get; set; }

        // Name
        public string ResponseShortText { get; set; }

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

        // Survey Response ID
        public string ResponseId { get; set; }

        // Survey Question ID
        public string QuestionId { get; set; }

        // Survey Question Choice ID
        public string QuestionChoiceId { get; set; }

        // Survey Version ID
        public string SurveyVersionId { get; set; }

        // Survey Invitation ID
        public string InvitationId { get; set; }

        // Data Type
        public string Datatype { get; set; }

        // Rank
        public int Rank { get; set; }

        // Date Value
        public DateTime DateValue { get; set; }

        // Date Time Value
        public DateTime DateTimeValue { get; set; }

        // Choice Value
        public string ChoiceValue { get; set; }

        // Response Value
        public string ResponseValue { get; set; }

        // True or False
        public bool IsTrueOrFalse { get; set; }

        // Number Value
        public int NumberValue { get; set; }
    }
}
