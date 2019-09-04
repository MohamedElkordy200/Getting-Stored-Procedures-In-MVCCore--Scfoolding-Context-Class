using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementSuspensions
    {
        public int Id { get; set; }
        public int StatementId { get; set; }

        public virtual Statements Statement { get; set; }
    }
}
