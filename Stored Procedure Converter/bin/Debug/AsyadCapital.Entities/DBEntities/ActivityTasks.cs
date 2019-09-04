using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ActivityTasks
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public bool IsFinished { get; set; }
        public int ActivityId { get; set; }
        public int JobId { get; set; }
        public int? DecisionId { get; set; }
        public int? ProjectPersonnelId { get; set; }
        public string Status { get; set; }
        public int? ReferenceId { get; set; }
        public string ReferenceType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? ReferenceDate { get; set; }
        public int? ReferenceAttachFileId { get; set; }
        public string ReferenceAttachFilePath { get; set; }
        public string SkipReasons { get; set; }
        public bool? IsDelete { get; set; }

        public virtual Activities Activity { get; set; }
        public virtual ActivityDecisions Decision { get; set; }
        public virtual Jobs Job { get; set; }
        public virtual ProjectPersonnels ProjectPersonnel { get; set; }
    }
}
