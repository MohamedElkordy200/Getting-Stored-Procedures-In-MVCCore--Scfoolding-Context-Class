using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Processes
    {
        public Processes()
        {
            Jobs = new HashSet<Jobs>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public bool? IsActive { get; set; }
        public string Color { get; set; }
        public string IconFileName { get; set; }
        public bool? CanDelete { get; set; }

        public virtual ICollection<Jobs> Jobs { get; set; }
    }
}
