using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class RequestApprovals
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int StudyBoqitemId { get; set; }
        public int RequestApprovalTypeId { get; set; }
        public int RequestApprovalRequiredId { get; set; }

        public virtual Requests Request { get; set; }
        public virtual RequestApprovalRequireds RequestApprovalRequired { get; set; }
        public virtual RequestApprovalTypes RequestApprovalType { get; set; }
        public virtual StudyBoqitems StudyBoqitem { get; set; }
    }
}
