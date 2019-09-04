using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ScheduleTaskProcesses
    {
        public int Id { get; set; }
        public int? ScheduleTaskId { get; set; }
        public int? ReferenceId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Duration { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public decimal? UpdatedCost { get; set; }
        public string ReferenceType { get; set; }

        public virtual ScheduleTasks ScheduleTask { get; set; }
    }
}
