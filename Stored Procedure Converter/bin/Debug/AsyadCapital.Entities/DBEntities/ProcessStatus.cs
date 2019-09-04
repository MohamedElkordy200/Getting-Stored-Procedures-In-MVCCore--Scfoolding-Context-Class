using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProcessStatus
    {
        public int Id { get; set; }
        public string ProcessCode { get; set; }
        public string Code { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string Color { get; set; }
    }
}
