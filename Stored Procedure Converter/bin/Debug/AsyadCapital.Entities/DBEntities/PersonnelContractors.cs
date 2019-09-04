using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class PersonnelContractors
    {
        public int Id { get; set; }
        public int PersonnelId { get; set; }
        public int ContractorId { get; set; }
        public int PersonnelSpecialtyId { get; set; }
        public int PersonnelProficiencylevelId { get; set; }
        public int PersonnelQualificationId { get; set; }

        public virtual Contractors Contractor { get; set; }
        public virtual Personnels Personnel { get; set; }
        public virtual PersonnelProficiencylevels PersonnelProficiencylevel { get; set; }
        public virtual PersonnelQualifications PersonnelQualification { get; set; }
        public virtual PersonnelSpecialties PersonnelSpecialty { get; set; }
    }
}
