using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class LookupDocumentCategories
    {
        public LookupDocumentCategories()
        {
            LookupDocumentTypes = new HashSet<LookupDocumentTypes>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public int? PersonnelTypeId { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual PersonnelTypes PersonnelType { get; set; }
        public virtual ICollection<LookupDocumentTypes> LookupDocumentTypes { get; set; }
    }
}
