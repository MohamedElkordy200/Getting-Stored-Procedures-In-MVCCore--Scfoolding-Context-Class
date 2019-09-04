using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementMonthelyReport
    {
        public int Id { get; set; }
        public int StatementId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string WorksCompleted { get; set; }
        public string WorkUnderWay { get; set; }
        public int? IsEmploymentAvailable { get; set; }
        public int? IsEquipmentAvailable { get; set; }
        public int? QualityOfWork { get; set; }
        public string QualityOfWorkNotes { get; set; }
        public int? IsSafety { get; set; }
        public int? EfficiencyOfTechnicalStaff { get; set; }
        public int? CommittedToThePlan { get; set; }
        public string CommittedToThePlanNotes { get; set; }
        public int? Obstacles { get; set; }
        public string ObstaclesNotes { get; set; }
        public string EmploymentNotes { get; set; }
        public int? IsTechnicalTeamAvailable { get; set; }
        public string TechnicalTeamNotes { get; set; }
        public string EquipmentNotes { get; set; }
        public string SafetyNotes { get; set; }
        public string EfficiencyOfTechnicalStaffNotes { get; set; }
        public string ImagePath1 { get; set; }
        public string ImagePath2 { get; set; }
        public decimal? ActualProgressItc { get; set; }
        public decimal? FinancialProgressItc { get; set; }
        public int? CurrentStatusItc { get; set; }
        public int? CurrentPhaseItc { get; set; }
        public decimal? DurationProgressItc { get; set; }

        public virtual Statements Statement { get; set; }
    }
}
