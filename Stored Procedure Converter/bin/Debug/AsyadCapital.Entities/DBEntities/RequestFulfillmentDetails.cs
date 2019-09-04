using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class RequestFulfillmentDetails
    {
        public int Id { get; set; }
        public int RequestFulfillmentId { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public bool IsCompleted { get; set; }
        public string Notes { get; set; }

        public virtual RequestFulfillments RequestFulfillment { get; set; }
    }
}
