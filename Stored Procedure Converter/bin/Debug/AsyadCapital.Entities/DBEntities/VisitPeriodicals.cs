using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitPeriodicals
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal? ProgressPercentagPayments { get; set; }
        public decimal? ProgressPercentagWorkItems { get; set; }
        public decimal? ProgressPercentagDuration { get; set; }
        public string Obstacles { get; set; }

        public virtual Visits Visit { get; set; }
    }
}
