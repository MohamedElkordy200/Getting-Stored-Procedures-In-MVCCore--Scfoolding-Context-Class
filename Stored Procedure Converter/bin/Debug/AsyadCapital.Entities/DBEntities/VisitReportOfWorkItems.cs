using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitReportOfWorkItems
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public bool IsDone { get; set; }
        public decimal? CompletePercentage { get; set; }
        public int QualityId { get; set; }
        public int WorkTypeId { get; set; }

        public virtual WorkTypeQualities Quality { get; set; }
        public virtual Visits Visit { get; set; }
        public virtual WorkTypes WorkType { get; set; }
    }
}
