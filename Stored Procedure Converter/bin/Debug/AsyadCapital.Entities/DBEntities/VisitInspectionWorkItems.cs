using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitInspectionWorkItems
    {
        public VisitInspectionWorkItems()
        {
            LabRequestWorkItemSamples = new HashSet<LabRequestWorkItemSamples>();
            VisitFiles = new HashSet<VisitFiles>();
        }

        public int Id { get; set; }
        public int VisitInspectionId { get; set; }
        public int RequestWorkItemBoqinventoryId { get; set; }
        public int StudyBoqitemId { get; set; }
        public decimal Quantity { get; set; }
        public int DeliveryStatus { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsPaid { get; set; }
        public int? PaymentRequestId { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public int? QualityOfWork { get; set; }
        public int? Count { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }

        public virtual PaymentRequests PaymentRequest { get; set; }
        public virtual RequestWorkItemBoqinventories RequestWorkItemBoqinventory { get; set; }
        public virtual StudyBoqitems StudyBoqitem { get; set; }
        public virtual VisitInspections VisitInspection { get; set; }
        public virtual ICollection<LabRequestWorkItemSamples> LabRequestWorkItemSamples { get; set; }
        public virtual ICollection<VisitFiles> VisitFiles { get; set; }
    }
}
