using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProvinceBoundaries
    {
        public int Id { get; set; }
        public int ProvinceId { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }

        public virtual Provinces Province { get; set; }
    }
}
