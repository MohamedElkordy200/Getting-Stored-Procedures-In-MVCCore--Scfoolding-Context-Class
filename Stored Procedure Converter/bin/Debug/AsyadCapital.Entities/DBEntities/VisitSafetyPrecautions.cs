using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitSafetyPrecautions
    {
        public VisitSafetyPrecautions()
        {
            VisitSafetyPrecautionCheckLists = new HashSet<VisitSafetyPrecautionCheckLists>();
        }

        public int Id { get; set; }
        public int VisitId { get; set; }

        public virtual Visits Visit { get; set; }
        public virtual ICollection<VisitSafetyPrecautionCheckLists> VisitSafetyPrecautionCheckLists { get; set; }
    }
}
