using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementResumptions
    {
        public int Id { get; set; }
        public int StatementId { get; set; }
        public DateTime ResumptionDate { get; set; }
        public int? RealSuspensionDuration { get; set; }
        public int? RequestSuspensionId { get; set; }

        public virtual Statements Statement { get; set; }
    }
}
