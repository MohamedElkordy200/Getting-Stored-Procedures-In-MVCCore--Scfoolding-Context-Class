using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Personnels
    {
        public Personnels()
        {
            AuditTrial = new HashSet<AuditTrial>();
            PersonnelConsultants = new HashSet<PersonnelConsultants>();
            PersonnelContractors = new HashSet<PersonnelContractors>();
            PersonnelExecutiveConsultants = new HashSet<PersonnelExecutiveConsultants>();
            PersonnelLaboratories = new HashSet<PersonnelLaboratories>();
            PersonnelOwners = new HashSet<PersonnelOwners>();
            ProjectPersonnels = new HashSet<ProjectPersonnels>();
        }

        public int Id { get; set; }
        public int PersonnelJobId { get; set; }
        public int PersonnelTypeId { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string UserName { get; set; }
        public bool IsAddByDefaultToProject { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual PersonnelJobs PersonnelJob { get; set; }
        public virtual PersonnelTypes PersonnelType { get; set; }
        public virtual ICollection<AuditTrial> AuditTrial { get; set; }
        public virtual ICollection<PersonnelConsultants> PersonnelConsultants { get; set; }
        public virtual ICollection<PersonnelContractors> PersonnelContractors { get; set; }
        public virtual ICollection<PersonnelExecutiveConsultants> PersonnelExecutiveConsultants { get; set; }
        public virtual ICollection<PersonnelLaboratories> PersonnelLaboratories { get; set; }
        public virtual ICollection<PersonnelOwners> PersonnelOwners { get; set; }
        public virtual ICollection<ProjectPersonnels> ProjectPersonnels { get; set; }
    }
}
