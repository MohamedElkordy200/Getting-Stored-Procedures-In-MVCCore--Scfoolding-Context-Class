using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class PersonnelExecutiveConsultants
    {
        public int Id { get; set; }
        public int ExecutiveConsultantId { get; set; }
        public int PersonnelId { get; set; }

        public virtual ExecutiveConsultants ExecutiveConsultant { get; set; }
        public virtual Personnels Personnel { get; set; }
    }
}
