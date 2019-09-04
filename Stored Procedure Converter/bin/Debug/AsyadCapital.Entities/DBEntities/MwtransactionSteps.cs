using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class MwtransactionSteps
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string Notes { get; set; }
        public bool? IsSite { get; set; }
        public bool? IsDate { get; set; }
    }
}
