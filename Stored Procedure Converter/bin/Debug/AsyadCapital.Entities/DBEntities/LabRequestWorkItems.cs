using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class LabRequestWorkItems
    {
        public LabRequestWorkItems()
        {
            LabRequestWorkItemSamples = new HashSet<LabRequestWorkItemSamples>();
        }

        public int Id { get; set; }
        public int LabRequestId { get; set; }
        public int LaboratoryId { get; set; }
        public int RequestWorkItemsDeliveryId { get; set; }
        public int? VisitId { get; set; }
        public DateTime? TakeSampleDate { get; set; }
        public string LaboratoryRepresental { get; set; }
        public int DegreeOfImportance { get; set; }
        public bool? IsApproved { get; set; }
        public int? StatementId { get; set; }

        public virtual LabRequests LabRequest { get; set; }
        public virtual Laboratories Laboratory { get; set; }
        public virtual RequestWorkItemsDeliveries RequestWorkItemsDelivery { get; set; }
        public virtual Visits Visit { get; set; }
        public virtual ICollection<LabRequestWorkItemSamples> LabRequestWorkItemSamples { get; set; }
    }
}
