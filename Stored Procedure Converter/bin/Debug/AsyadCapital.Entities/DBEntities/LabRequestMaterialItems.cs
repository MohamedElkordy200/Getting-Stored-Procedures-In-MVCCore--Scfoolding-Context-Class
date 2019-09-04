using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class LabRequestMaterialItems
    {
        public LabRequestMaterialItems()
        {
            LabRequestMaterialItemSamples = new HashSet<LabRequestMaterialItemSamples>();
        }

        public int Id { get; set; }
        public int LabRequestMaterialId { get; set; }
        public int ProjectMaterialId { get; set; }
        public double Quantity { get; set; }
        public string Notes { get; set; }

        public virtual LabRequestMaterials LabRequestMaterial { get; set; }
        public virtual ProjectMaterials ProjectMaterial { get; set; }
        public virtual ICollection<LabRequestMaterialItemSamples> LabRequestMaterialItemSamples { get; set; }
    }
}
