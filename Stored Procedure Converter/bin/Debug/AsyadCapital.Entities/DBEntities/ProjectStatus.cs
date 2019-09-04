using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectStatus
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string Color { get; set; }
        public int? StatusOrderIndex { get; set; }
        public string IconFileName { get; set; }
        public int? PhaseCode { get; set; }
    }
}
