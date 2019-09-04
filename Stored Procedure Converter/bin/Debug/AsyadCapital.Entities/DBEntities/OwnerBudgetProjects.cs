using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class OwnerBudgetProjects
    {
        public int Id { get; set; }
        public int OwnerBudgetItemsId { get; set; }
        public int ProjectId { get; set; }
        public decimal? OutgoingUntilEndOfYearBeforeLast { get; set; }
        public decimal? ActualOutgoingInPastYear { get; set; }
        public decimal? YearApprovedBudget { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual OwnerBudgetItems OwnerBudgetItems { get; set; }
        public virtual Projects Project { get; set; }
    }
}
