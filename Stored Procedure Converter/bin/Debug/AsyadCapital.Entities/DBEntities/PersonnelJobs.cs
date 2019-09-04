using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class PersonnelJobs
    {
        public PersonnelJobs()
        {
            Personnels = new HashSet<Personnels>();
            StatementReportOfTechnicalTeams = new HashSet<StatementReportOfTechnicalTeams>();
            VisitReportOfTechnicalTeams = new HashSet<VisitReportOfTechnicalTeams>();
        }

        public int Id { get; set; }
        public int PersonnelTypeId { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public bool IsSiteWorkers { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual PersonnelTypes PersonnelType { get; set; }
        public virtual ICollection<Personnels> Personnels { get; set; }
        public virtual ICollection<StatementReportOfTechnicalTeams> StatementReportOfTechnicalTeams { get; set; }
        public virtual ICollection<VisitReportOfTechnicalTeams> VisitReportOfTechnicalTeams { get; set; }
    }
}
