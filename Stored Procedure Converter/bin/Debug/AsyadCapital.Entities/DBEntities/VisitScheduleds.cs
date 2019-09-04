using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitScheduleds
    {
        public VisitScheduleds()
        {
            VisitScheduledDelayReasons = new HashSet<VisitScheduledDelayReasons>();
        }

        public int Id { get; set; }
        public int VisitId { get; set; }
        public decimal? ProgressPercentagTimeplan { get; set; }
        public decimal? ProgressPercentagWorkItems { get; set; }
        public decimal? ProgressPercentagDuration { get; set; }
        public bool IsSamplePassed { get; set; }
        public string DelaySuggestion { get; set; }
        public string DelayReasons { get; set; }

        public virtual Visits Visit { get; set; }
        public virtual ICollection<VisitScheduledDelayReasons> VisitScheduledDelayReasons { get; set; }
    }
}
