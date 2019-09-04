using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementViolations
    {
        public int Id { get; set; }
        public int StatementId { get; set; }
        public string PenaltiesDesc { get; set; }
        public decimal PenaltiesValue { get; set; }
        public string Decision { get; set; }
        public int? PaymentRequestId { get; set; }

        public virtual PaymentRequests PaymentRequest { get; set; }
        public virtual Statements Statement { get; set; }
    }
}
