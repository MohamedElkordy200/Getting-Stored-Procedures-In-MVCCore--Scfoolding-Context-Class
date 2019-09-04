using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class SystemConfigurations
    {
        public SystemConfigurations()
        {
            ActivityDecisions = new HashSet<ActivityDecisions>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
        public string ScenarioNo { get; set; }

        public virtual ICollection<ActivityDecisions> ActivityDecisions { get; set; }
    }
}
