using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class LookupDepartments
    {
        public LookupDepartments()
        {
            ProjectDepartments = new HashSet<ProjectDepartments>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public bool? IsActive { get; set; }
        public string Color { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public int? ParentId { get; set; }
        public bool? IsVisible { get; set; }

        public virtual ICollection<ProjectDepartments> ProjectDepartments { get; set; }
    }
}
