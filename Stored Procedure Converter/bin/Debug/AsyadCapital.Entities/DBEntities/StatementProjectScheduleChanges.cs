using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementProjectScheduleChanges
    {
        public StatementProjectScheduleChanges()
        {
            StatementProjectScheduleChangeTasks = new HashSet<StatementProjectScheduleChangeTasks>();
        }

        public int Id { get; set; }
        public int StatementId { get; set; }

        public virtual Statements Statement { get; set; }
        public virtual ICollection<StatementProjectScheduleChangeTasks> StatementProjectScheduleChangeTasks { get; set; }
    }
}
