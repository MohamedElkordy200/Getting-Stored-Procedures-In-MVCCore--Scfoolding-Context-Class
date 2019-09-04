using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementPeriodicals
    {
        public int Id { get; set; }
        public int StatementId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal? ProgressPercentagPayments { get; set; }
        public decimal? ProgressPercentagWorkItems { get; set; }
        public decimal? ProgressPercentagDuration { get; set; }
        public string Obstacles { get; set; }

        public virtual Statements Statement { get; set; }
    }
}
