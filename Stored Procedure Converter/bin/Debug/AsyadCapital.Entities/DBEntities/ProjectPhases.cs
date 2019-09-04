using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectPhases
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string Color { get; set; }
        public string IconFileName { get; set; }
    }
}
