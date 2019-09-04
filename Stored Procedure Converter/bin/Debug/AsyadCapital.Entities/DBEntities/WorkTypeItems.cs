using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class WorkTypeItems
    {
        public int Id { get; set; }
        public int WorkTypeId { get; set; }
        public int LookupMeasureUnitId { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public bool IsHasTest { get; set; }
        public bool IsSpecial { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public string Code { get; set; }

        public virtual LookupMeasureUnits LookupMeasureUnit { get; set; }
        public virtual WorkTypes WorkType { get; set; }
    }
}
