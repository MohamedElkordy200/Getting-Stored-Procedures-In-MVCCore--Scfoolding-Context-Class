using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class RequestWorkItems
    {
        public RequestWorkItems()
        {
            RequestWorkItemBoqinventories = new HashSet<RequestWorkItemBoqinventories>();
        }

        public int Id { get; set; }
        public int RequestWorkItemsDeliveryId { get; set; }
        public int StudyBoqitemId { get; set; }
        public decimal Quantity { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Notes { get; set; }

        public virtual RequestWorkItemsDeliveries RequestWorkItemsDelivery { get; set; }
        public virtual StudyBoqitems StudyBoqitem { get; set; }
        public virtual ICollection<RequestWorkItemBoqinventories> RequestWorkItemBoqinventories { get; set; }
    }
}
