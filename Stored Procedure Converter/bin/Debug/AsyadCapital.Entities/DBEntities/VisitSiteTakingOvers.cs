using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitSiteTakingOvers
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public bool HasObstacles { get; set; }
        public string ObstaclesDescription { get; set; }
        public string Report { get; set; }

        public virtual Visits Visit { get; set; }
    }
}
