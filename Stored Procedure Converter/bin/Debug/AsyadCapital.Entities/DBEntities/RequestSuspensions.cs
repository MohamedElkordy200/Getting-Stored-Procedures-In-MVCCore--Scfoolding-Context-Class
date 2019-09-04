using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class RequestSuspensions
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public DateTime SuspensionDate { get; set; }
        public int SuspensionDuration { get; set; }
        public string Reasons { get; set; }
        public DateTime? ResumptionDate { get; set; }

        public virtual Requests Request { get; set; }
    }
}
