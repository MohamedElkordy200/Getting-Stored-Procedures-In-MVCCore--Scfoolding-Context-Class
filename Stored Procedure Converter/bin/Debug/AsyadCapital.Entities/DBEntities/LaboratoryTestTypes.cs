using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class LaboratoryTestTypes
    {
        public LaboratoryTestTypes()
        {
            LaboratoryTests = new HashSet<LaboratoryTests>();
        }

        public int Id { get; set; }
        public int LaboratoryId { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Laboratories Laboratory { get; set; }
        public virtual ICollection<LaboratoryTests> LaboratoryTests { get; set; }
    }
}
