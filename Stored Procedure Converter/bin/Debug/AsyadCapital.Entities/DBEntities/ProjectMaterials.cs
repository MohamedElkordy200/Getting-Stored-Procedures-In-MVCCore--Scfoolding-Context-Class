using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectMaterials
    {
        public ProjectMaterials()
        {
            LabRequestMaterialItems = new HashSet<LabRequestMaterialItems>();
            StatementReportOfMaterials = new HashSet<StatementReportOfMaterials>();
            VisitReportOfMaterials = new HashSet<VisitReportOfMaterials>();
        }

        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int? MaterialId { get; set; }
        public int MaterialTypeId { get; set; }
        public int LookupMeasureUnitId { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public double Quantity { get; set; }
        public bool IsHasTest { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual LookupMeasureUnits LookupMeasureUnit { get; set; }
        public virtual Materials Material { get; set; }
        public virtual MaterialTypes MaterialType { get; set; }
        public virtual Projects Project { get; set; }
        public virtual ICollection<LabRequestMaterialItems> LabRequestMaterialItems { get; set; }
        public virtual ICollection<StatementReportOfMaterials> StatementReportOfMaterials { get; set; }
        public virtual ICollection<VisitReportOfMaterials> VisitReportOfMaterials { get; set; }
    }
}
