using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class RequestApprovalRequireds
    {
        public RequestApprovalRequireds()
        {
            RequestApprovals = new HashSet<RequestApprovals>();
        }

        public int Id { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<RequestApprovals> RequestApprovals { get; set; }
    }
}
