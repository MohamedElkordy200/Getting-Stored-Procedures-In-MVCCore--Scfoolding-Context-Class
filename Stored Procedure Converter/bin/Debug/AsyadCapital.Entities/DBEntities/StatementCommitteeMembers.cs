using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementCommitteeMembers
    {
        public int Id { get; set; }
        public int StatementId { get; set; }
        public int CommitteeMemberId { get; set; }

        public virtual CommitteeMembers CommitteeMember { get; set; }
        public virtual Statements Statement { get; set; }
    }
}
