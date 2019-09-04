using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementSiteTakingOvers
    {
        public int Id { get; set; }
        public int StatementId { get; set; }
        public DateTime? TakingOverDate { get; set; }
        public string Decision { get; set; }
        public int? RemoveObstructionsDuration { get; set; }

        public virtual Statements Statement { get; set; }
    }
}
