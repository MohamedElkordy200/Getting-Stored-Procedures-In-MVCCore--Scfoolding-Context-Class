using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitSafetyPrecautionCheckLists
    {
        public int Id { get; set; }
        public int VisitSafetyPrecautionId { get; set; }
        public int VisitSafetyPrecautionRequirementId { get; set; }
        public string Details { get; set; }
        public bool? IsAvailable { get; set; }

        public virtual VisitSafetyPrecautions VisitSafetyPrecaution { get; set; }
        public virtual VisitSafetyPrecautionRequirements VisitSafetyPrecautionRequirement { get; set; }
    }
}
