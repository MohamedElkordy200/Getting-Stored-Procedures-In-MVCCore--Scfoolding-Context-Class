using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectCategories
    {
        public int Id { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public int? DepartmentId { get; set; }
        public int? GroupedProjectId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
