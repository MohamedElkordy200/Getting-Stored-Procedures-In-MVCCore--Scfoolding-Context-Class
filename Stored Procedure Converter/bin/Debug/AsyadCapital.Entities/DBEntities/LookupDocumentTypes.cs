using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class LookupDocumentTypes
    {
        public LookupDocumentTypes()
        {
            ContractorDocuments = new HashSet<ContractorDocuments>();
            ProjectDocuments = new HashSet<ProjectDocuments>();
        }

        public int Id { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public bool? IsActive { get; set; }
        public bool CanDelete { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public string Code { get; set; }
        public bool? IsContractor { get; set; }
        public int? PersonnelTypeId { get; set; }
        public int? LookupDocumentCategoryId { get; set; }
        public decimal? Percentage { get; set; }

        public virtual LookupDocumentCategories LookupDocumentCategory { get; set; }
        public virtual PersonnelTypes PersonnelType { get; set; }
        public virtual ICollection<ContractorDocuments> ContractorDocuments { get; set; }
        public virtual ICollection<ProjectDocuments> ProjectDocuments { get; set; }
    }
}
