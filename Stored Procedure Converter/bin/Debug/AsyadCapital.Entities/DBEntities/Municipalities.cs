using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Municipalities
    {
        public Municipalities()
        {
            MunicipalityBoundaries = new HashSet<MunicipalityBoundaries>();
            Projects = new HashSet<Projects>();
        }

        public int Id { get; set; }
        public int ProvinceId { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string SymbologyColor { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public int? OwnerId { get; set; }
        public double? LocationLat { get; set; }
        public double? LocationLong { get; set; }

        public virtual Provinces Province { get; set; }
        public virtual ICollection<MunicipalityBoundaries> MunicipalityBoundaries { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
    }
}
