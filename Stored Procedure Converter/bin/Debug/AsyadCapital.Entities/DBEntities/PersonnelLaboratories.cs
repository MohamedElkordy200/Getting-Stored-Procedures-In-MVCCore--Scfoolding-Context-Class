using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class PersonnelLaboratories
    {
        public int Id { get; set; }
        public int LaboratoryId { get; set; }
        public int PersonnelId { get; set; }

        public virtual Laboratories Laboratory { get; set; }
        public virtual Personnels Personnel { get; set; }
    }
}
