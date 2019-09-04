using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class LookupMeasureUnits
    {
        public LookupMeasureUnits()
        {
            Materials = new HashSet<Materials>();
            ProjectEquipments = new HashSet<ProjectEquipments>();
            ProjectMaterials = new HashSet<ProjectMaterials>();
            StudyBoqitems = new HashSet<StudyBoqitems>();
            WorkTypeItems = new HashSet<WorkTypeItems>();
        }

        public int Id { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string MeasureUnitType { get; set; }
        public bool IsRemovable { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<Materials> Materials { get; set; }
        public virtual ICollection<ProjectEquipments> ProjectEquipments { get; set; }
        public virtual ICollection<ProjectMaterials> ProjectMaterials { get; set; }
        public virtual ICollection<StudyBoqitems> StudyBoqitems { get; set; }
        public virtual ICollection<WorkTypeItems> WorkTypeItems { get; set; }
    }
}
