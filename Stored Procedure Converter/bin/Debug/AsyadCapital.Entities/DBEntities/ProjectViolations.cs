using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectViolations
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int ViolationTypeId { get; set; }
        public string Code { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public decimal ViolationAmount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Projects Project { get; set; }
        public virtual ViolationTypes ViolationType { get; set; }
    }
}
