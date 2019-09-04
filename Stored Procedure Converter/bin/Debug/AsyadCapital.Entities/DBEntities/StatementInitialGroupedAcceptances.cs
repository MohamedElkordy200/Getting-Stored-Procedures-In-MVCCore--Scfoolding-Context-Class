using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementInitialGroupedAcceptances
    {
        public int Id { get; set; }
        public int StatementId { get; set; }
        public DateTime? InitialAcceptanceDate { get; set; }
        public int? NoticeDuration { get; set; }
        public string Decision { get; set; }

        public virtual Statements Statement { get; set; }
    }
}
