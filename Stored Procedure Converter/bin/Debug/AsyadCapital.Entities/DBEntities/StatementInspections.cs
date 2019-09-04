using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementInspections
    {
        public StatementInspections()
        {
            StatementInspectionWorkItems = new HashSet<StatementInspectionWorkItems>();
        }

        public int Id { get; set; }
        public int StatementId { get; set; }
        public int RequestWorkItemsDeliveryId { get; set; }
        public bool IsLocationReady { get; set; }
        public bool IsHasOfficialSchemas { get; set; }
        public bool IsHasFencing { get; set; }
        public bool IsMaterialsValid { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual RequestWorkItemsDeliveries RequestWorkItemsDelivery { get; set; }
        public virtual Statements Statement { get; set; }
        public virtual ICollection<StatementInspectionWorkItems> StatementInspectionWorkItems { get; set; }
    }
}
