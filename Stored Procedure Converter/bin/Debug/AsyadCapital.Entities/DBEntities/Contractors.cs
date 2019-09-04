using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Contractors
    {
        public Contractors()
        {
            ContractorDocuments = new HashSet<ContractorDocuments>();
            PersonnelContractors = new HashSet<PersonnelContractors>();
            Projects = new HashSet<Projects>();
            TenderBids = new HashSet<TenderBids>();
        }

        public int Id { get; set; }
        public int ClassId { get; set; }
        public int FieldId { get; set; }
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
        public string Code { get; set; }
        public string MandopName { get; set; }
        public string OwnerName { get; set; }
        public string ApprovedCode { get; set; }
        public DateTime? ApprovedDate { get; set; }

        public virtual ContractorClasses Class { get; set; }
        public virtual ContractorFields Field { get; set; }
        public virtual ICollection<ContractorDocuments> ContractorDocuments { get; set; }
        public virtual ICollection<PersonnelContractors> PersonnelContractors { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<TenderBids> TenderBids { get; set; }
    }
}
