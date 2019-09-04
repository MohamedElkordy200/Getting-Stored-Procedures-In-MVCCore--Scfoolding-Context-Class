using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StudyBoqcomponents
    {
        public StudyBoqcomponents()
        {
            InverseParent = new HashSet<StudyBoqcomponents>();
            StudyBoqcomponentPoints = new HashSet<StudyBoqcomponentPoints>();
            StudyBoqitems = new HashSet<StudyBoqitems>();
        }

        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int? ParentId { get; set; }
        public int? RoadLayerId { get; set; }
        public string Code { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public bool? IsRoad { get; set; }
        public bool HasChild { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public decimal? Area { get; set; }
        public int? FloorCount { get; set; }
        public int? ModelCount { get; set; }

        public virtual StudyBoqcomponents Parent { get; set; }
        public virtual Projects Project { get; set; }
        public virtual LookupRoadLayers RoadLayer { get; set; }
        public virtual ICollection<StudyBoqcomponents> InverseParent { get; set; }
        public virtual ICollection<StudyBoqcomponentPoints> StudyBoqcomponentPoints { get; set; }
        public virtual ICollection<StudyBoqitems> StudyBoqitems { get; set; }
    }
}
