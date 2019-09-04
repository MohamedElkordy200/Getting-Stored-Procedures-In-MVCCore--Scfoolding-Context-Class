using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitReportOfMaterials
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public int ProjectMaterialId { get; set; }
        public int MaterialQuantity { get; set; }

        public virtual ProjectMaterials ProjectMaterial { get; set; }
        public virtual Visits Visit { get; set; }
    }
}
