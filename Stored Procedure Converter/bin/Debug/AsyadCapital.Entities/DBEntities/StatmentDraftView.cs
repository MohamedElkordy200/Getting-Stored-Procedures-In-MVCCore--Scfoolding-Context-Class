using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatmentDraftView
    {
        public int Id { get; set; }
        public int StatmentId { get; set; }
        public DateTime DraftViewDate { get; set; }
        public string DraftViewReasons { get; set; }

        public virtual Statements Statment { get; set; }
    }
}
