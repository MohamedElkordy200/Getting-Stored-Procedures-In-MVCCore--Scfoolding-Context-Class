using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class CommitteeMembers
    {
        public CommitteeMembers()
        {
            StatementCommitteeMembers = new HashSet<StatementCommitteeMembers>();
            VisitCommitteeMembers = new HashSet<VisitCommitteeMembers>();
        }

        public int Id { get; set; }
        public int CommitteeId { get; set; }
        public int CommitteeRoleId { get; set; }
        public int ProjectPersonnelId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual Committees Committee { get; set; }
        public virtual CommitteeRoles CommitteeRole { get; set; }
        public virtual ProjectPersonnels ProjectPersonnel { get; set; }
        public virtual ICollection<StatementCommitteeMembers> StatementCommitteeMembers { get; set; }
        public virtual ICollection<VisitCommitteeMembers> VisitCommitteeMembers { get; set; }
    }
}
