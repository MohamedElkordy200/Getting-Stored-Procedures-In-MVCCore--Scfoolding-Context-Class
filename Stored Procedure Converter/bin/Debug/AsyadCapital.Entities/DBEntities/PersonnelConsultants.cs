using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class PersonnelConsultants
    {
        public int Id { get; set; }
        public int ConsultantId { get; set; }
        public int PersonnelId { get; set; }

        public virtual Consultants Consultant { get; set; }
        public virtual Personnels Personnel { get; set; }
    }
}
