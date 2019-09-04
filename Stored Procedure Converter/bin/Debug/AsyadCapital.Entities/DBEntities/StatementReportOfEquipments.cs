using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementReportOfEquipments
    {
        public int Id { get; set; }
        public int StatementId { get; set; }
        public int ProjectEquipmentId { get; set; }
        public int EquipmentCount { get; set; }

        public virtual ProjectEquipments ProjectEquipment { get; set; }
        public virtual Statements Statement { get; set; }
    }
}
