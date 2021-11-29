using System;

namespace MAD.API.Salesforce.Domain
{
    public class SurveyQuestionScore : ISalesforceEntity
    {
        // Question Score ID
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

        // Survey ID
        public string SurveyId { get; set; }

        // Survey Version ID
        public string SurveyVersionId { get; set; }

        // Survey Invitation ID
        public string SurveyInvitationId { get; set; }

        // Survey Question ID
        public string QuestionId { get; set; }

        // Survey Question Choice ID
        public string QuestionChoiceId { get; set; }

        // Question Name
        public string QuestionName { get; set; }

        // Response Value
        public double ResponseValue { get; set; }

        // Score
        public double Score { get; set; }

        // Response Count
        public int ResponseCount { get; set; }

        // Question Score Type
        public string ScoreType { get; set; }

        // Question Skipped Count
        public int QuestionSkippedCount { get; set; }

        // Date Response
        public DateTime DateResponse { get; set; }

        // Question Developer Name
        public string QuestionDeveloperName { get; set; }

        // Cumulative Score
        public double CumulativeScore { get; set; }
    }
}
