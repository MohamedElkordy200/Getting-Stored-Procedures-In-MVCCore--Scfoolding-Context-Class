using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class MaterialTypes
    {
        public MaterialTypes()
        {
            Materials = new HashSet<Materials>();
            ProjectMaterials = new HashSet<ProjectMaterials>();
        }

        public int Id { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<Materials> Materials { get; set; }
        public virtual ICollection<ProjectMaterials> ProjectMaterials { get; set; }
    }
}
