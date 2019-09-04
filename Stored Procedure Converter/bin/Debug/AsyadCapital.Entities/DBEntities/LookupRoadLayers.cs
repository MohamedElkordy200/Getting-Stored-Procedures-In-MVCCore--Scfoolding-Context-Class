using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class LookupRoadLayers
    {
        public LookupRoadLayers()
        {
            StudyBoqcomponents = new HashSet<StudyBoqcomponents>();
        }

        public int Id { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string Color { get; set; }
        public int? Height { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<StudyBoqcomponents> StudyBoqcomponents { get; set; }
    }
}
