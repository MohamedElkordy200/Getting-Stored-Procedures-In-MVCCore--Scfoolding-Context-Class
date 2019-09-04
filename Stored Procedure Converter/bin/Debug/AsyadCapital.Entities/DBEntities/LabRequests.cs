using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class LabRequests
    {
        public LabRequests()
        {
            LabRequestMaterials = new HashSet<LabRequestMaterials>();
            LabRequestWorkItems = new HashSet<LabRequestWorkItems>();
        }

        public int Id { get; set; }
        public string ActivityCode { get; set; }
        public int ProjectPersonnelId { get; set; }
        public int ProjectId { get; set; }
        public DateTime Date { get; set; }
        public string Code { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual Projects Project { get; set; }
        public virtual ProjectPersonnels ProjectPersonnel { get; set; }
        public virtual ICollection<LabRequestMaterials> LabRequestMaterials { get; set; }
        public virtual ICollection<LabRequestWorkItems> LabRequestWorkItems { get; set; }
    }
}
