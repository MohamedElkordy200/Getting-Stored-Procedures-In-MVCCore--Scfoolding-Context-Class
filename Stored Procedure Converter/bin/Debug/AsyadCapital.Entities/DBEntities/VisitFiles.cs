using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitFiles
    {
        public VisitFiles()
        {
            CommentFiles = new HashSet<CommentFiles>();
        }

        public int Id { get; set; }
        public int VisitId { get; set; }
        public string FileName { get; set; }
        public double? Size { get; set; }
        public int? TypeId { get; set; }
        public int? VisitInspectionWorkItemId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public int? Order { get; set; }
        public bool? IsVisible { get; set; }
        public string ImageName { get; set; }
        public bool? IsDefault { get; set; }

        public virtual Visits Visit { get; set; }
        public virtual VisitInspectionWorkItems VisitInspectionWorkItem { get; set; }
        public virtual ICollection<CommentFiles> CommentFiles { get; set; }
    }
}
