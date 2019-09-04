using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectSubTypes
    {
        public ProjectSubTypes()
        {
            WorkTypes = new HashSet<WorkTypes>();
        }

        public int Id { get; set; }
        public int ProjectTypeId { get; set; }
        public string Code { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public int? OrderIndex { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ProjectTypes ProjectType { get; set; }
        public virtual ICollection<WorkTypes> WorkTypes { get; set; }
    }
}
