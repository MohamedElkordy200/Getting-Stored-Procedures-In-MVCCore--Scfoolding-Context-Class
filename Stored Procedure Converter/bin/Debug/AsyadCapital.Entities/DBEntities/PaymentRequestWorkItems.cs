using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class PaymentRequestWorkItems
    {
        public int Id { get; set; }
        public int PaymentRequestId { get; set; }
        public int StudyBoqitemId { get; set; }
        public decimal? PaidQuantity { get; set; }

        public virtual PaymentRequests PaymentRequest { get; set; }
        public virtual StudyBoqitems StudyBoqitem { get; set; }
    }
}
