using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class PersonnelOwners
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public int PersonnelId { get; set; }

        public virtual Owners Owner { get; set; }
        public virtual Personnels Personnel { get; set; }
    }
}
