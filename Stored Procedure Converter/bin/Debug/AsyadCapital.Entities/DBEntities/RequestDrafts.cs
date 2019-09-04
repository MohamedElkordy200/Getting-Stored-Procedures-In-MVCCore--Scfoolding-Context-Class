using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class RequestDrafts
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public DateTime DraftDate { get; set; }
        public string DraftReasons { get; set; }

        public virtual Requests Request { get; set; }
    }
}
