using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectDocuments
    {
        public int Id { get; set; }
        public string DescriptionFl { get; set; }
        public string DescriptionSl { get; set; }
        public int? DocumentTypeId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? Date { get; set; }
        public string Path { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public bool? IsVisible { get; set; }

        public virtual LookupDocumentTypes DocumentType { get; set; }
        public virtual Projects Project { get; set; }
    }
}
