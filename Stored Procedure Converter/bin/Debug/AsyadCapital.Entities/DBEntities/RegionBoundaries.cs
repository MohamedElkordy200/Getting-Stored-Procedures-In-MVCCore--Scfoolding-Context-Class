using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class RegionBoundaries
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }

        public virtual Regions Region { get; set; }
    }
}
