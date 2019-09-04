using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Activities
    {
        public Activities()
        {
            ActivityDecisionsActivity = new HashSet<ActivityDecisions>();
            ActivityDecisionsNextActivity = new HashSet<ActivityDecisions>();
            ActivityTasks = new HashSet<ActivityTasks>();
        }

        public int Id { get; set; }
        public string ProcessCode { get; set; }
        public string Code { get; set; }
        public bool IsStart { get; set; }
        public bool IsEnd { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string TypeCode { get; set; }
        public string TypeName { get; set; }
        public string Color { get; set; }
        public bool? IsVisible { get; set; }
        public bool IsActive { get; set; }
        public string IconFileName { get; set; }
        public string RouteUrl { get; set; }

        public virtual ICollection<ActivityDecisions> ActivityDecisionsActivity { get; set; }
        public virtual ICollection<ActivityDecisions> ActivityDecisionsNextActivity { get; set; }
        public virtual ICollection<ActivityTasks> ActivityTasks { get; set; }
    }
}
