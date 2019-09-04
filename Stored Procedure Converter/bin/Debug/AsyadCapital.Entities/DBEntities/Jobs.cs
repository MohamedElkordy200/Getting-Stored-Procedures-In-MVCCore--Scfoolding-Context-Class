using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Jobs
    {
        public Jobs()
        {
            ActivityTasks = new HashSet<ActivityTasks>();
        }

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public int ProcessId { get; set; }
        public int ProjectId { get; set; }
        public string Status { get; set; }
        public string ReferenceType { get; set; }
        public int? ProjectPhase { get; set; }
        public int? ProjectStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public bool? IsDelete { get; set; }

        public virtual Processes Process { get; set; }
        public virtual Projects Project { get; set; }
        public virtual ICollection<ActivityTasks> ActivityTasks { get; set; }
    }
}
