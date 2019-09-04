using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitMonthelyReport
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string WorksCompleted { get; set; }
        public string WorkUnderWay { get; set; }
        public bool? IsEmploymentAvailable { get; set; }
        public bool? IsEquipmentAvailable { get; set; }
        public int? QualityOfWork { get; set; }
        public string QualityOfWorkNotes { get; set; }
        public bool? IsSafety { get; set; }
        public bool? EfficiencyOfTechnicalStaff { get; set; }
        public int? CommittedToThePlan { get; set; }
        public string CommittedToThePlanNotes { get; set; }
        public int? Obstacles { get; set; }
        public string ObstaclesNotes { get; set; }

        public virtual Visits Visit { get; set; }
    }
}
