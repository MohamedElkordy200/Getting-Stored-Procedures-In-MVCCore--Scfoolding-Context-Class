using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Laboratories
    {
        public Laboratories()
        {
            LabRequestMaterials = new HashSet<LabRequestMaterials>();
            LabRequestWorkItems = new HashSet<LabRequestWorkItems>();
            LaboratoryTestTypes = new HashSet<LaboratoryTestTypes>();
            PersonnelLaboratories = new HashSet<PersonnelLaboratories>();
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

        public virtual ICollection<LabRequestMaterials> LabRequestMaterials { get; set; }
        public virtual ICollection<LabRequestWorkItems> LabRequestWorkItems { get; set; }
        public virtual ICollection<LaboratoryTestTypes> LaboratoryTestTypes { get; set; }
        public virtual ICollection<PersonnelLaboratories> PersonnelLaboratories { get; set; }
    }
}
