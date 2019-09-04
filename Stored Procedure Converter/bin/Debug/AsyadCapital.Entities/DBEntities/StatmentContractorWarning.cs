using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatmentContractorWarning
    {
        public int Id { get; set; }
        public int StatmentId { get; set; }
        public DateTime Date { get; set; }
        public string ReasonsForWarning { get; set; }

        public virtual Statements Statment { get; set; }
    }
}
