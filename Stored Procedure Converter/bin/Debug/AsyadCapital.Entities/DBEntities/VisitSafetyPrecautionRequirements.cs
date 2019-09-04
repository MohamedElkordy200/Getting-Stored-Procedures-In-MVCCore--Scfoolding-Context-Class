﻿using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class VisitSafetyPrecautionRequirements
    {
        public VisitSafetyPrecautionRequirements()
        {
            VisitSafetyPrecautionCheckLists = new HashSet<VisitSafetyPrecautionCheckLists>();
        }

        public int Id { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public bool IsPrecaution { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<VisitSafetyPrecautionCheckLists> VisitSafetyPrecautionCheckLists { get; set; }
    }
}
