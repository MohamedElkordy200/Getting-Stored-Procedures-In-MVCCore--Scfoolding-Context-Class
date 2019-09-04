using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ScheduleTaskDependencies
    {
        public int Id { get; set; }
        public int RelationId { get; set; }
        public int BaseTaskId { get; set; }
        public int DependedOnTaskId { get; set; }
        public int? Lag { get; set; }
        public int? Lead { get; set; }

        public virtual ScheduleTasks BaseTask { get; set; }
        public virtual ScheduleTasks DependedOnTask { get; set; }
        public virtual ScheduleTaskRelations Relation { get; set; }
    }
}
