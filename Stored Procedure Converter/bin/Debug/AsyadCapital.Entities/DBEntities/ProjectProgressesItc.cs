using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectProgressesItc
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public DateTime ProgressDate { get; set; }
        public int PhaseCode { get; set; }
        public int StatusCode { get; set; }
        public decimal ActualProgress { get; set; }
        public decimal FinancialProgress { get; set; }
        public decimal? FinancialProgressPaid { get; set; }
        public bool? IsAutoInsert { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual Projects Project { get; set; }
    }
}
