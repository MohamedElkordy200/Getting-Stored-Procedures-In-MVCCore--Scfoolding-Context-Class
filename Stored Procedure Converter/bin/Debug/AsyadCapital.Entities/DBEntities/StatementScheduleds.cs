using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementScheduleds
    {
        public StatementScheduleds()
        {
            StatementScheduledDelayReasons = new HashSet<StatementScheduledDelayReasons>();
        }

        public int Id { get; set; }
        public int StatementId { get; set; }
        public decimal? ProgressPercentagTimeplan { get; set; }
        public decimal? ProgressPercentagWorkItems { get; set; }
        public decimal? ProgressPercentagDuration { get; set; }
        public bool IsSamplePassed { get; set; }
        public string DelaySuggestion { get; set; }
        public string DelayReasons { get; set; }

        public virtual Statements Statement { get; set; }
        public virtual ICollection<StatementScheduledDelayReasons> StatementScheduledDelayReasons { get; set; }
    }
}
