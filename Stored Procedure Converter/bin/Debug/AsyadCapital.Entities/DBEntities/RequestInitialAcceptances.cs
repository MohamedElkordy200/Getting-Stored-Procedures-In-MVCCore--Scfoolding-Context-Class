using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class RequestInitialAcceptances
    {
        public int Id { get; set; }
        public int RequestId { get; set; }

        public virtual Requests Request { get; set; }
    }
}
