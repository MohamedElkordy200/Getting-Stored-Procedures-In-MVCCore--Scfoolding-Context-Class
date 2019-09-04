using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementDelays
    {
        public int Id { get; set; }
        public int StatementId { get; set; }
        public int DelayDuration { get; set; }
        public string Reasons { get; set; }

        public virtual Statements Statement { get; set; }
    }
}
