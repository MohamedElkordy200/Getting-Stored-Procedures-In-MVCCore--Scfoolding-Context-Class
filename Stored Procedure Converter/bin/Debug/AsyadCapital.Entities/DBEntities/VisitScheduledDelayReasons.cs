using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitScheduledDelayReasons
    {
        public int Id { get; set; }
        public int VisitScheduledId { get; set; }
        public int LookupDelayReasonId { get; set; }

        public virtual LookupDelayReasons LookupDelayReason { get; set; }
        public virtual VisitScheduleds VisitScheduled { get; set; }
    }
}
