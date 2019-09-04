using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class RequestWorkItemBoqinventories
    {
        public RequestWorkItemBoqinventories()
        {
            StatementInspectionWorkItems = new HashSet<StatementInspectionWorkItems>();
            VisitInspectionWorkItems = new HashSet<VisitInspectionWorkItems>();
        }

        public int Id { get; set; }
        public int RequestWorkItemId { get; set; }
        public decimal Quantity { get; set; }
        public decimal? InspectedQuantity { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public int? Count { get; set; }

        public virtual RequestWorkItems RequestWorkItem { get; set; }
        public virtual ICollection<StatementInspectionWorkItems> StatementInspectionWorkItems { get; set; }
        public virtual ICollection<VisitInspectionWorkItems> VisitInspectionWorkItems { get; set; }
    }
}
