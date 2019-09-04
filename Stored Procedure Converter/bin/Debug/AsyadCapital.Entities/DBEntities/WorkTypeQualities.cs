using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class WorkTypeQualities
    {
        public WorkTypeQualities()
        {
            StatementReportOfWorkItems = new HashSet<StatementReportOfWorkItems>();
            VisitReportOfWorkItems = new HashSet<VisitReportOfWorkItems>();
        }

        public int Id { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string Color { get; set; }
        public string IconFileName { get; set; }

        public virtual ICollection<StatementReportOfWorkItems> StatementReportOfWorkItems { get; set; }
        public virtual ICollection<VisitReportOfWorkItems> VisitReportOfWorkItems { get; set; }
    }
}
