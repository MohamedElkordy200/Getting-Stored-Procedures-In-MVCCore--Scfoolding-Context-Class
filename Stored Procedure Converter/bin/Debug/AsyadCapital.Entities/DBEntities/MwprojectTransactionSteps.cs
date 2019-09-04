using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class MwprojectTransactionSteps
    {
        public int Id { get; set; }
        public int? TransactionStepsId { get; set; }
        public int? Duration { get; set; }
        public DateTime? ExpectedStartDate { get; set; }
        public DateTime? ExpectedEndDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public int? DelayPeriod { get; set; }
        public string Notes { get; set; }
        public int? ProjectId { get; set; }
    }
}
