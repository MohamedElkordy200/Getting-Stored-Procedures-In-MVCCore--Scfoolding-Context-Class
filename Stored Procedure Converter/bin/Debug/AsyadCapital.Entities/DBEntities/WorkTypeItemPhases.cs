using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class WorkTypeItemPhases
    {
        public int Id { get; set; }
        public int WorkTypeId { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public int Order { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual WorkTypes WorkType { get; set; }
    }
}
