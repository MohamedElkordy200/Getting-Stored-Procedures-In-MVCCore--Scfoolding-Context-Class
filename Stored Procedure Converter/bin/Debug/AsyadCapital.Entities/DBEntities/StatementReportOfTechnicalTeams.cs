using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementReportOfTechnicalTeams
    {
        public int Id { get; set; }
        public int StatementId { get; set; }
        public int PersonnelJobId { get; set; }
        public int PersonnelCount { get; set; }

        public virtual PersonnelJobs PersonnelJob { get; set; }
        public virtual Statements Statement { get; set; }
    }
}
