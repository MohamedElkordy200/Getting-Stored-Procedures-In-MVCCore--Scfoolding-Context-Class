using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ScheduleTaskResources
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int ProjectPersonnelId { get; set; }

        public virtual ProjectPersonnels ProjectPersonnel { get; set; }
        public virtual ScheduleTasks Task { get; set; }
    }
}
