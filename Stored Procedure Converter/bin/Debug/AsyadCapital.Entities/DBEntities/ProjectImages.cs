using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectImages
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public int ProjectId { get; set; }
        public bool? IsDefault { get; set; }
        public string ImageName { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public int? Order { get; set; }
        public bool? IsVisible { get; set; }

        public virtual Projects Project { get; set; }
    }
}
