using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Provinces
    {
        public Provinces()
        {
            Municipalities = new HashSet<Municipalities>();
            ProvinceBoundaries = new HashSet<ProvinceBoundaries>();
        }

        public int Id { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string SymbologyColor { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public int? RegionId { get; set; }

        public virtual Regions Region { get; set; }
        public virtual ICollection<Municipalities> Municipalities { get; set; }
        public virtual ICollection<ProvinceBoundaries> ProvinceBoundaries { get; set; }
    }
}
