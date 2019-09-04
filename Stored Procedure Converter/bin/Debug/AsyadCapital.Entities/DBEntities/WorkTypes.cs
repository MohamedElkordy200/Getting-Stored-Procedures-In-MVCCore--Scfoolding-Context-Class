using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class WorkTypes
    {
        public WorkTypes()
        {
            LaboratoryTests = new HashSet<LaboratoryTests>();
            StatementReportOfWorkItems = new HashSet<StatementReportOfWorkItems>();
            StudyBoqitems = new HashSet<StudyBoqitems>();
            VisitReportOfWorkItems = new HashSet<VisitReportOfWorkItems>();
            WorkTypeItemPhases = new HashSet<WorkTypeItemPhases>();
            WorkTypeItems = new HashSet<WorkTypeItems>();
        }

        public int Id { get; set; }
        public int ProjectSubTypeId { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ProjectSubTypes ProjectSubType { get; set; }
        public virtual ICollection<LaboratoryTests> LaboratoryTests { get; set; }
        public virtual ICollection<StatementReportOfWorkItems> StatementReportOfWorkItems { get; set; }
        public virtual ICollection<StudyBoqitems> StudyBoqitems { get; set; }
        public virtual ICollection<VisitReportOfWorkItems> VisitReportOfWorkItems { get; set; }
        public virtual ICollection<WorkTypeItemPhases> WorkTypeItemPhases { get; set; }
        public virtual ICollection<WorkTypeItems> WorkTypeItems { get; set; }
    }
}
