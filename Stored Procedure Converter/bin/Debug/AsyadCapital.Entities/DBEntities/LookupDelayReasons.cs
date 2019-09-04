using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class LookupDelayReasons
    {
        public LookupDelayReasons()
        {
            StatementScheduledDelayReasons = new HashSet<StatementScheduledDelayReasons>();
            VisitScheduledDelayReasons = new HashSet<VisitScheduledDelayReasons>();
        }

        public int Id { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public bool IsRemovable { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<StatementScheduledDelayReasons> StatementScheduledDelayReasons { get; set; }
        public virtual ICollection<VisitScheduledDelayReasons> VisitScheduledDelayReasons { get; set; }
    }
}
