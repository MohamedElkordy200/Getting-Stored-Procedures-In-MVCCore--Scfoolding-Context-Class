using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Owners
    {
        public Owners()
        {
            OwnerBudgets = new HashSet<OwnerBudgets>();
            PersonnelOwners = new HashSet<PersonnelOwners>();
            Projects = new HashSet<Projects>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
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
        public bool IsPrimary { get; set; }
        public string Color { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<OwnerBudgets> OwnerBudgets { get; set; }
        public virtual ICollection<PersonnelOwners> PersonnelOwners { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
    }
}
