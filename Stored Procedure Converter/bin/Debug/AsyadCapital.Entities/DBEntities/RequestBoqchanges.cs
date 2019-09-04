using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class RequestBoqchanges
    {
        public RequestBoqchanges()
        {
            RequestBoqchangeItems = new HashSet<RequestBoqchangeItems>();
        }

        public int Id { get; set; }
        public int RequestId { get; set; }
        public bool IsBudgetEffect { get; set; }
        public bool? IsScheduleEffect { get; set; }
        public decimal BudgetChangeValue { get; set; }
        public decimal BudgetChangeRatio { get; set; }
        public int BudgetChangeType { get; set; }
        public decimal TotalBudgetChangeValue { get; set; }
        public decimal UpdatedProjectCost { get; set; }
        public int UpdatedProjectDurationDays { get; set; }
        public decimal? IncreasedValue { get; set; }
        public decimal? DecreasedValue { get; set; }
        public decimal? ProjectCostBeforUpdate { get; set; }
        public int? DurationDaysBeforUpdate { get; set; }

        public virtual Requests Request { get; set; }
        public virtual ICollection<RequestBoqchangeItems> RequestBoqchangeItems { get; set; }
    }
}
