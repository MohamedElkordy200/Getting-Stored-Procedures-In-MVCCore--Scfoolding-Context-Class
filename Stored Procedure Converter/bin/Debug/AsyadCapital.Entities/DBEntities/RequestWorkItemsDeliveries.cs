using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class RequestWorkItemsDeliveries
    {
        public RequestWorkItemsDeliveries()
        {
            LabRequestWorkItems = new HashSet<LabRequestWorkItems>();
            RequestWorkItems = new HashSet<RequestWorkItems>();
            StatementInspections = new HashSet<StatementInspections>();
            VisitInspections = new HashSet<VisitInspections>();
        }

        public int Id { get; set; }
        public int RequestId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool IsHasTest { get; set; }
        public int IsSpecial { get; set; }
        public int? IsRequestHasTest { get; set; }

        public virtual Requests Request { get; set; }
        public virtual ICollection<LabRequestWorkItems> LabRequestWorkItems { get; set; }
        public virtual ICollection<RequestWorkItems> RequestWorkItems { get; set; }
        public virtual ICollection<StatementInspections> StatementInspections { get; set; }
        public virtual ICollection<VisitInspections> VisitInspections { get; set; }
    }
}
