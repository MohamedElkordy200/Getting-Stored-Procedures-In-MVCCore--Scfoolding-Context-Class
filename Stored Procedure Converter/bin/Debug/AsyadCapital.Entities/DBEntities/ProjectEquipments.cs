using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectEquipments
    {
        public ProjectEquipments()
        {
            StatementReportOfEquipments = new HashSet<StatementReportOfEquipments>();
            VisitReportOfEquipments = new HashSet<VisitReportOfEquipments>();
        }

        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int EquipmentId { get; set; }
        public int StatusId { get; set; }
        public int? LookupMeasureUnitId { get; set; }
        public bool IsContractorEquipment { get; set; }
        public string Model { get; set; }
        public double? Capacity { get; set; }
        public int? EquipmentCount { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual Equipments Equipment { get; set; }
        public virtual LookupMeasureUnits LookupMeasureUnit { get; set; }
        public virtual Projects Project { get; set; }
        public virtual EquipmentStatus Status { get; set; }
        public virtual ICollection<StatementReportOfEquipments> StatementReportOfEquipments { get; set; }
        public virtual ICollection<VisitReportOfEquipments> VisitReportOfEquipments { get; set; }
    }
}
