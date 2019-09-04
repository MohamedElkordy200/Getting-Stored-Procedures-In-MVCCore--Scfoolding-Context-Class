using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Regions
    {
        public Regions()
        {
            Provinces = new HashSet<Provinces>();
            RegionBoundaries = new HashSet<RegionBoundaries>();
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
        public int? SectorId { get; set; }

        public virtual Sectors Sector { get; set; }
        public virtual ICollection<Provinces> Provinces { get; set; }
        public virtual ICollection<RegionBoundaries> RegionBoundaries { get; set; }
    }
}
