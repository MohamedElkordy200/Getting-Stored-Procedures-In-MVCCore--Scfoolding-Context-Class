using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ContractorFields
    {
        public ContractorFields()
        {
            Consultants = new HashSet<Consultants>();
            Contractors = new HashSet<Contractors>();
            ExecutiveConsultants = new HashSet<ExecutiveConsultants>();
        }

        public int Id { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<Consultants> Consultants { get; set; }
        public virtual ICollection<Contractors> Contractors { get; set; }
        public virtual ICollection<ExecutiveConsultants> ExecutiveConsultants { get; set; }
    }
}
