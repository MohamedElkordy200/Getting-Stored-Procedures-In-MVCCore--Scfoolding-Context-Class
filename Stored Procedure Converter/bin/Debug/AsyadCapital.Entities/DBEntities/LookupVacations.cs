using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class LookupVacations
    {
        public int Id { get; set; }
        public DateTime? VacationDate { get; set; }
        public int? Year { get; set; }
        public string Description { get; set; }
        public bool? IsWeekly { get; set; }
    }
}
