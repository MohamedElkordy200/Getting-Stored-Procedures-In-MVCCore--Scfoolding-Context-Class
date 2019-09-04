using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementReportOfMaterials
    {
        public int Id { get; set; }
        public int StatementId { get; set; }
        public int ProjectMaterialId { get; set; }
        public int MaterialQuantity { get; set; }

        public virtual ProjectMaterials ProjectMaterial { get; set; }
        public virtual Statements Statement { get; set; }
    }
}
