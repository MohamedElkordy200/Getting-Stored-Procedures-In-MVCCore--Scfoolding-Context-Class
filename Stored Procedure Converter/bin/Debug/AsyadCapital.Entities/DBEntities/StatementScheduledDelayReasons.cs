using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementScheduledDelayReasons
    {
        public int Id { get; set; }
        public int StatementScheduledId { get; set; }
        public int LookupDelayReasonId { get; set; }

        public virtual LookupDelayReasons LookupDelayReason { get; set; }
        public virtual StatementScheduleds StatementScheduled { get; set; }
    }
}
