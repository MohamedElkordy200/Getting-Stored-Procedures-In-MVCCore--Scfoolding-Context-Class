using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementSafetyPrecautionCheckLists
    {
        public int Id { get; set; }
        public int StatementSafetyPrecautionId { get; set; }
        public int StatementSafetyPrecautionRequirementId { get; set; }
        public string Details { get; set; }
        public bool? IsAvailable { get; set; }

        public virtual StatementSafetyPrecautions StatementSafetyPrecaution { get; set; }
        public virtual StatementSafetyPrecautionRequirements StatementSafetyPrecautionRequirement { get; set; }
    }
}
