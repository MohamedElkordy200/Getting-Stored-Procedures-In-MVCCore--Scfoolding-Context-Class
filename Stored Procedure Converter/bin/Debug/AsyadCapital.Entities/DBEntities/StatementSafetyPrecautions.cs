using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementSafetyPrecautions
    {
        public StatementSafetyPrecautions()
        {
            StatementSafetyPrecautionCheckLists = new HashSet<StatementSafetyPrecautionCheckLists>();
        }

        public int Id { get; set; }
        public int StatementId { get; set; }

        public virtual Statements Statement { get; set; }
        public virtual ICollection<StatementSafetyPrecautionCheckLists> StatementSafetyPrecautionCheckLists { get; set; }
    }
}
