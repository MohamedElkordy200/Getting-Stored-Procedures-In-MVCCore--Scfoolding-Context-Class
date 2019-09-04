using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class RequestFulfillments
    {
        public RequestFulfillments()
        {
            RequestFulfillmentDetails = new HashSet<RequestFulfillmentDetails>();
        }

        public int Id { get; set; }
        public int RequestId { get; set; }
        public string HandReview { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewerPhone { get; set; }
        public string Directive { get; set; }

        public virtual Requests Request { get; set; }
        public virtual ICollection<RequestFulfillmentDetails> RequestFulfillmentDetails { get; set; }
    }
}
