using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ScheduleTaskRelations
    {
        public ScheduleTaskRelations()
        {
            ScheduleTaskDependencies = new HashSet<ScheduleTaskDependencies>();
        }

        public int Id { get; set; }
        public string NameSl { get; set; }
        public string NameFl { get; set; }

        public virtual ICollection<ScheduleTaskDependencies> ScheduleTaskDependencies { get; set; }
    }
}
