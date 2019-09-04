using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementProjectScheduleChangeTasks
    {
        public int Id { get; set; }
        public int StatementProjectScheduleChangeId { get; set; }
        public int ProjectScheduleId { get; set; }
        public DateTime FromDateBefore { get; set; }
        public DateTime ToDateBefore { get; set; }
        public decimal QuantityBefore { get; set; }
        public decimal QuantityAfter { get; set; }
        public DateTime FromDateAfter { get; set; }
        public DateTime ToDateAfter { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual StatementProjectScheduleChanges StatementProjectScheduleChange { get; set; }
    }
}
