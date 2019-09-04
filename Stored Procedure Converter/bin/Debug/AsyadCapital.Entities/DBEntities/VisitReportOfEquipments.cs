using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitReportOfEquipments
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public int ProjectEquipmentId { get; set; }
        public int EquipmentCount { get; set; }

        public virtual ProjectEquipments ProjectEquipment { get; set; }
        public virtual Visits Visit { get; set; }
    }
}
