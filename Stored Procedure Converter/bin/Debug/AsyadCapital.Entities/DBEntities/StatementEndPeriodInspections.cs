using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementEndPeriodInspections
    {
        public int Id { get; set; }
        public int StatementId { get; set; }
        public DateTime EndPeriodDate { get; set; }
        public int ProjectDuration { get; set; }
        public decimal ProjectActualProgress { get; set; }
        public decimal? ProjectWeightProgress { get; set; }
        public decimal? ProjectDurationProgress { get; set; }
        public string Notes { get; set; }

        public virtual Statements Statement { get; set; }
    }
}
