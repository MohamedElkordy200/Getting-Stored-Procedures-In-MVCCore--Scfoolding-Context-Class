using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class AuditTrialActions
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string Color { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
