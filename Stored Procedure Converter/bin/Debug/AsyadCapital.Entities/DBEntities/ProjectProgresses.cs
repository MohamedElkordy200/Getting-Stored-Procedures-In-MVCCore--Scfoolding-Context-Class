using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectProgresses
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int? JobId { get; set; }
        public int StatusCode { get; set; }
        public decimal DurationProgress { get; set; }
        public decimal ActualProgress { get; set; }
        public decimal FinancialProgress { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public decimal? WeightProgress { get; set; }

        public virtual Projects Project { get; set; }
    }
}
