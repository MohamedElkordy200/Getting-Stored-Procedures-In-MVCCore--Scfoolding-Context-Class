using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitInspections
    {
        public VisitInspections()
        {
            VisitInspectionWorkItems = new HashSet<VisitInspectionWorkItems>();
        }

        public int Id { get; set; }
        public int VisitId { get; set; }
        public int RequestWorkItemsDeliveryId { get; set; }
        public bool IsLocationReady { get; set; }
        public bool IsHasOfficialSchemas { get; set; }
        public bool IsHasFencing { get; set; }
        public bool IsMaterialsValid { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual RequestWorkItemsDeliveries RequestWorkItemsDelivery { get; set; }
        public virtual Visits Visit { get; set; }
        public virtual ICollection<VisitInspectionWorkItems> VisitInspectionWorkItems { get; set; }
    }
}
