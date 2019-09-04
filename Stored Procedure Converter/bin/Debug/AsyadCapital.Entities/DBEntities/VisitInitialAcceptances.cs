using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitInitialAcceptances
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public string DecisionCode { get; set; }

        public virtual Visits Visit { get; set; }
    }
}
