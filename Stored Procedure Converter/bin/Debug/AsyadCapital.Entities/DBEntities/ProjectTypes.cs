using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectTypes
    {
        public ProjectTypes()
        {
            ProjectSubTypes = new HashSet<ProjectSubTypes>();
            Projects = new HashSet<Projects>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string IconFileName { get; set; }
        public string Color { get; set; }
        public int? OrderIndex { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<ProjectSubTypes> ProjectSubTypes { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
    }
}
