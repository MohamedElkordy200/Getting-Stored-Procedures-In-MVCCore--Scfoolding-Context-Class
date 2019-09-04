using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatmentCancelDraft
    {
        public int Id { get; set; }
        public int StatmentId { get; set; }
        public DateTime Date { get; set; }
        public string ReasonsForCancelDraft { get; set; }

        public virtual Statements Statment { get; set; }
    }
}
