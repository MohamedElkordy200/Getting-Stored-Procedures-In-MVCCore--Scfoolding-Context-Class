using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ActivityDocuments
    {
        public int Id { get; set; }
        public bool IsRequired { get; set; }
        public string DocName { get; set; }
        public string DocType { get; set; }
        public int ActivityId { get; set; }
    }
}
