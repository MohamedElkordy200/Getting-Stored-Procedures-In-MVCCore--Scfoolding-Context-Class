using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitFinialAcceptances
    {
        public int Id { get; set; }
        public int VisitId { get; set; }

        public virtual Visits Visit { get; set; }
    }
}
