using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectPersonnelsAudit
    {
        public int Id { get; set; }
        public int ProjectPersonnelsId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? AvailableAt { get; set; }
        public string AvailableBy { get; set; }

        public virtual ProjectPersonnels ProjectPersonnels { get; set; }
    }
}
