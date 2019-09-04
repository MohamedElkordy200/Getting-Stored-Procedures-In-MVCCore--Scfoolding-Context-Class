using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitCommitteeMembers
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public int CommitteeMemberId { get; set; }

        public virtual CommitteeMembers CommitteeMember { get; set; }
        public virtual Visits Visit { get; set; }
    }
}
