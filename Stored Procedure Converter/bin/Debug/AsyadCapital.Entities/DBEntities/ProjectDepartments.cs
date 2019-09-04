using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectDepartments
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int DepartmentId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual LookupDepartments Department { get; set; }
        public virtual Projects Project { get; set; }
    }
}
