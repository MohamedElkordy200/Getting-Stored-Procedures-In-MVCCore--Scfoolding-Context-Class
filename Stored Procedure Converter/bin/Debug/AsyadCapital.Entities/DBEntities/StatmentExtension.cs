using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatmentExtension
    {
        public int Id { get; set; }
        public int? StatmentId { get; set; }
        public DateTime? Date { get; set; }
        public int? DurationOfExtension { get; set; }
        public string ReasonsForExtension { get; set; }

        public virtual Statements Statment { get; set; }
    }
}
