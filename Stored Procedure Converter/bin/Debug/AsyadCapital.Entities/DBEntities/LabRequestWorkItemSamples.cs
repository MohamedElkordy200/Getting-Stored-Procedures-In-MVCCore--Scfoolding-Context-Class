using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class LabRequestWorkItemSamples
    {
        public LabRequestWorkItemSamples()
        {
            LabRequestWorkItemTests = new HashSet<LabRequestWorkItemTests>();
        }

        public int Id { get; set; }
        public int LabRequestWorkItemId { get; set; }
        public int? VisitInspectionWorkItemId { get; set; }
        public string Barcode { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public int? StatementInspectionWorkItemId { get; set; }

        public virtual LabRequestWorkItems LabRequestWorkItem { get; set; }
        public virtual VisitInspectionWorkItems VisitInspectionWorkItem { get; set; }
        public virtual ICollection<LabRequestWorkItemTests> LabRequestWorkItemTests { get; set; }
    }
}
