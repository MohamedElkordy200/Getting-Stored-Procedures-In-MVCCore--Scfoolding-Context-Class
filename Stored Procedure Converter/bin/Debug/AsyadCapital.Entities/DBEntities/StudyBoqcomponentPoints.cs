using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StudyBoqcomponentPoints
    {
        public int Id { get; set; }
        public int ComponentId { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public int? ShapeType { get; set; }
        public string Address { get; set; }
        public string KmlfileName { get; set; }
        public bool IsDefault { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual StudyBoqcomponents Component { get; set; }
    }
}
