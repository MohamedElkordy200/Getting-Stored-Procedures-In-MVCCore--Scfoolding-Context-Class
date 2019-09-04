using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ScheduleTasks
    {
        public ScheduleTasks()
        {
            InverseOriginalTask = new HashSet<ScheduleTasks>();
            InverseParent = new HashSet<ScheduleTasks>();
            ScheduleTaskDependenciesBaseTask = new HashSet<ScheduleTaskDependencies>();
            ScheduleTaskDependenciesDependedOnTask = new HashSet<ScheduleTaskDependencies>();
            ScheduleTaskProcesses = new HashSet<ScheduleTaskProcesses>();
            ScheduleTaskProgresses = new HashSet<ScheduleTaskProgresses>();
            ScheduleTaskResources = new HashSet<ScheduleTaskResources>();
        }

        public int Id { get; set; }
        public int? OriginalTaskId { get; set; }
        public int? ParentId { get; set; }
        public int ProjectId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsCurrent { get; set; }
        public int ExternalId { get; set; }
        public string IntegrationProjectType { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public DateTime? BaseLineStartDate { get; set; }
        public DateTime? BaseLineEndDate { get; set; }
        public DateTime? TargetStartDate { get; set; }
        public DateTime? TargetEndDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal OriginalDuration { get; set; }
        public decimal? ActualDuration { get; set; }
        public int TotalFloat { get; set; }
        public bool IsCritical { get; set; }
        public int Level { get; set; }
        public bool HasChild { get; set; }
        public decimal? ActivityProgress { get; set; }
        public decimal? DurationProgress { get; set; }
        public int? ActualDelayDays { get; set; }
        public string ActualDelayReason { get; set; }
        public DateTime? StatusDate { get; set; }
        public string Status { get; set; }
        public string Descreption { get; set; }
        public int OrderIndex { get; set; }
        public string Predessors { get; set; }
        public string Relations { get; set; }
        public decimal? ActualMaterialCost { get; set; }
        public string Wbscode { get; set; }
        public string Wbsname { get; set; }
        public string StartStatusName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public bool? StartIsMilestone { get; set; }
        public int? StudyBoqitemId { get; set; }
        public decimal? ItemQuantity { get; set; }
        public bool? IsManualChangeCriticalPath { get; set; }
        public bool IsDelete { get; set; }

        public virtual ScheduleTasks OriginalTask { get; set; }
        public virtual ScheduleTasks Parent { get; set; }
        public virtual Projects Project { get; set; }
        public virtual StudyBoqitems StudyBoqitem { get; set; }
        public virtual ICollection<ScheduleTasks> InverseOriginalTask { get; set; }
        public virtual ICollection<ScheduleTasks> InverseParent { get; set; }
        public virtual ICollection<ScheduleTaskDependencies> ScheduleTaskDependenciesBaseTask { get; set; }
        public virtual ICollection<ScheduleTaskDependencies> ScheduleTaskDependenciesDependedOnTask { get; set; }
        public virtual ICollection<ScheduleTaskProcesses> ScheduleTaskProcesses { get; set; }
        public virtual ICollection<ScheduleTaskProgresses> ScheduleTaskProgresses { get; set; }
        public virtual ICollection<ScheduleTaskResources> ScheduleTaskResources { get; set; }
    }
}
