using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ActivityDecisions
    {
        public ActivityDecisions()
        {
            ActivityTasks = new HashSet<ActivityTasks>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Decision { get; set; }
        public int ActivityId { get; set; }
        public int? NextActivityId { get; set; }
        public int SystemConfigurationId { get; set; }
        public string Description { get; set; }
        public string ProcessStatus { get; set; }
        public int? ProjectPhase { get; set; }
        public int? ProjectStatus { get; set; }

        public virtual Activities Activity { get; set; }
        public virtual Activities NextActivity { get; set; }
        public virtual SystemConfigurations SystemConfiguration { get; set; }
        public virtual ICollection<ActivityTasks> ActivityTasks { get; set; }
    }
}
