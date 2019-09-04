using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StudyBoqitems
    {
        public StudyBoqitems()
        {
            InverseItem = new HashSet<StudyBoqitems>();
            PaymentRequestWorkItems = new HashSet<PaymentRequestWorkItems>();
            RequestApprovals = new HashSet<RequestApprovals>();
            RequestBoqchangeItems = new HashSet<RequestBoqchangeItems>();
            RequestWorkItems = new HashSet<RequestWorkItems>();
            ScheduleTasks = new HashSet<ScheduleTasks>();
            StatementInspectionWorkItems = new HashSet<StatementInspectionWorkItems>();
            TenderBidBoqitems = new HashSet<TenderBidBoqitems>();
            VisitInspectionWorkItems = new HashSet<VisitInspectionWorkItems>();
        }

        public int Id { get; set; }
        public int WorkTypeId { get; set; }
        public int ComponentId { get; set; }
        public int? ItemId { get; set; }
        public int LookupMeasureUnitId { get; set; }
        public string Code { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public decimal? ConsultantPrice { get; set; }
        public decimal? ContractorPrice { get; set; }
        public decimal? OriginalQuantity { get; set; }
        public decimal Quantity { get; set; }
        public decimal? DeliveredQuantity { get; set; }
        public bool IsHasTest { get; set; }
        public bool IsSpecial { get; set; }
        public int Order { get; set; }
        public bool IsNew { get; set; }
        public bool? IsActive { get; set; }
        public decimal? PaidQuantity { get; set; }
        public decimal? Weight { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? FirstActivityDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual StudyBoqcomponents Component { get; set; }
        public virtual StudyBoqitems Item { get; set; }
        public virtual LookupMeasureUnits LookupMeasureUnit { get; set; }
        public virtual Projects Project { get; set; }
        public virtual WorkTypes WorkType { get; set; }
        public virtual ICollection<StudyBoqitems> InverseItem { get; set; }
        public virtual ICollection<PaymentRequestWorkItems> PaymentRequestWorkItems { get; set; }
        public virtual ICollection<RequestApprovals> RequestApprovals { get; set; }
        public virtual ICollection<RequestBoqchangeItems> RequestBoqchangeItems { get; set; }
        public virtual ICollection<RequestWorkItems> RequestWorkItems { get; set; }
        public virtual ICollection<ScheduleTasks> ScheduleTasks { get; set; }
        public virtual ICollection<StatementInspectionWorkItems> StatementInspectionWorkItems { get; set; }
        public virtual ICollection<TenderBidBoqitems> TenderBidBoqitems { get; set; }
        public virtual ICollection<VisitInspectionWorkItems> VisitInspectionWorkItems { get; set; }
    }
}
