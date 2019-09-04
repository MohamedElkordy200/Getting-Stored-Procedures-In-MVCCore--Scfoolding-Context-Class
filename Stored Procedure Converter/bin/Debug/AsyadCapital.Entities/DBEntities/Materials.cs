using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Materials
    {
        public Materials()
        {
            ProjectMaterials = new HashSet<ProjectMaterials>();
        }

        public int Id { get; set; }
        public int MaterialTypeId { get; set; }
        public int LookupMeasureUnitId { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public bool IsHasTest { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual LookupMeasureUnits LookupMeasureUnit { get; set; }
        public virtual MaterialTypes MaterialType { get; set; }
        public virtual ICollection<ProjectMaterials> ProjectMaterials { get; set; }
    }
}
