using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Committees
    {
        public Committees()
        {
            CommitteeMembers = new HashSet<CommitteeMembers>();
            InverseCopyFrom = new HashSet<Committees>();
        }

        public int Id { get; set; }
        public string ActivityCode { get; set; }
        public int ProjectId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public int? CopyFromId { get; set; }
        public DateTime? CommitteeDate { get; set; }
        public bool? IsDelete { get; set; }

        public virtual Committees CopyFrom { get; set; }
        public virtual Projects Project { get; set; }
        public virtual ICollection<CommitteeMembers> CommitteeMembers { get; set; }
        public virtual ICollection<Committees> InverseCopyFrom { get; set; }
    }
}
