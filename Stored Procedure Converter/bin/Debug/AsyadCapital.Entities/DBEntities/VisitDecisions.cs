using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitDecisions
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string ActivityCode { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
    }
}
