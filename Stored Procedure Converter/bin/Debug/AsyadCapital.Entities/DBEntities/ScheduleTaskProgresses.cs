using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ScheduleTaskProgresses
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public decimal Progress { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual ScheduleTasks Task { get; set; }
    }
}
