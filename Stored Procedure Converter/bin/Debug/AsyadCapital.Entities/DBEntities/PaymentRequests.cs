using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class PaymentRequests
    {
        public PaymentRequests()
        {
            PaymentRequestPostPay = new HashSet<PaymentRequestPostPay>();
            PaymentRequestWorkItems = new HashSet<PaymentRequestWorkItems>();
            StatementInspectionWorkItems = new HashSet<StatementInspectionWorkItems>();
            StatementViolations = new HashSet<StatementViolations>();
            VisitInspectionWorkItems = new HashSet<VisitInspectionWorkItems>();
        }

        public int Id { get; set; }
        public string ActivityCode { get; set; }
        public int ProjectPersonnelId { get; set; }
        public int ProjectId { get; set; }
        public DateTime Date { get; set; }
        public string Code { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public decimal? RequestedAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? OfferDiscountSubtraction { get; set; }
        public decimal? DelaySubtraction { get; set; }
        public decimal? SupervisionSubtraction { get; set; }
        public decimal? DownPaymentSubtraction { get; set; }
        public decimal? AbsenceSubtraction { get; set; }
        public decimal? OtherSubtractions { get; set; }
        public bool? IsInitialAcceptance { get; set; }
        public DateTime? DismissalNoticeDate { get; set; }
        public string DismissalNoticeNo { get; set; }
        public decimal? ViolationsSubtraction { get; set; }
        public bool? IsPayment { get; set; }
        public int? ApprovalLevelIndex { get; set; }
        public decimal? ValueAddedTaxAmount { get; set; }
        public decimal? DiscountValueAdded { get; set; }
        public decimal? AddingValueAdded { get; set; }
        public int? PaymentRequestTypeId { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public decimal? DelayedValue { get; set; }
        public decimal? PaymentAmountDue { get; set; }
        public decimal? AllPaymentRequestSubtraction { get; set; }
        public bool? IsDelete { get; set; }

        public virtual ICollection<PaymentRequestPostPay> PaymentRequestPostPay { get; set; }
        public virtual ICollection<PaymentRequestWorkItems> PaymentRequestWorkItems { get; set; }
        public virtual ICollection<StatementInspectionWorkItems> StatementInspectionWorkItems { get; set; }
        public virtual ICollection<StatementViolations> StatementViolations { get; set; }
        public virtual ICollection<VisitInspectionWorkItems> VisitInspectionWorkItems { get; set; }
    }
}
