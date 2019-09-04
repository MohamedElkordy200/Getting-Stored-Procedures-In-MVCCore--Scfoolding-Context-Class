using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ContractorDocuments
    {
        public int Id { get; set; }
        public int? DocumentTypeId { get; set; }
        public int? ContractorId { get; set; }
        public string Code { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Notes { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public string DescriptionFl { get; set; }
        public string DescriptionSl { get; set; }

        public virtual Contractors Contractor { get; set; }
        public virtual LookupDocumentTypes DocumentType { get; set; }
    }
}
