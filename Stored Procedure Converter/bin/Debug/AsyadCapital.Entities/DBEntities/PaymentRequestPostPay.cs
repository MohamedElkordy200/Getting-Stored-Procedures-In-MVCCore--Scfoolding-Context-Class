using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class PaymentRequestPostPay
    {
        public int Id { get; set; }
        public int? PaymentRequestId { get; set; }
        public decimal PaidAmount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DismisselNotesDate { get; set; }
        public string DismisselNotesNo { get; set; }

        public virtual PaymentRequests PaymentRequest { get; set; }
    }
}
