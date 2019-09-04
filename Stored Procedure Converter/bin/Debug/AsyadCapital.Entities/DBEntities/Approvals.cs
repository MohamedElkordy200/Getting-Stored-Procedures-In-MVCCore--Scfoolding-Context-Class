using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Approvals
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int ProjectPersonnelId { get; set; }
        public string ActivityCode { get; set; }
        public DateTime Date { get; set; }
        public string ApprovalStatus { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Projects Project { get; set; }
        public virtual ProjectPersonnels ProjectPersonnel { get; set; }
    }
}
