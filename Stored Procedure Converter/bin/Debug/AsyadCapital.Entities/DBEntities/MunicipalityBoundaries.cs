using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class MunicipalityBoundaries
    {
        public int Id { get; set; }
        public int MunicipalityId { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }

        public virtual Municipalities Municipality { get; set; }
    }
}
