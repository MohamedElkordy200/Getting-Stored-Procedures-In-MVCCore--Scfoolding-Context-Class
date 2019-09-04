using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitReportOfTechnicalTeams
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public int PersonnelJobId { get; set; }
        public int PersonnelCount { get; set; }

        public virtual PersonnelJobs PersonnelJob { get; set; }
        public virtual Visits Visit { get; set; }
    }
}
