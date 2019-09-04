using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Consultants
    {
        public Consultants()
        {
            PersonnelConsultants = new HashSet<PersonnelConsultants>();
            Projects = new HashSet<Projects>();
        }

        public int Id { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string MobilePrimary { get; set; }
        public string MobileSecondary { get; set; }
        public string TelephonePrimary { get; set; }
        public string TelephoneSecondary { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string LogoFileName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public int? FieldId { get; set; }

        public virtual ContractorFields Field { get; set; }
        public virtual ICollection<PersonnelConsultants> PersonnelConsultants { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
    }
}
