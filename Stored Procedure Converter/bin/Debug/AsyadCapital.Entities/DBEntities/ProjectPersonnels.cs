using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectPersonnels
    {
        public ProjectPersonnels()
        {
            ActivityTasks = new HashSet<ActivityTasks>();
            Approvals = new HashSet<Approvals>();
            CommitteeMembers = new HashSet<CommitteeMembers>();
            InverseChangedByNavigation = new HashSet<ProjectPersonnels>();
            LabRequests = new HashSet<LabRequests>();
            ProjectPersonnelsAudit = new HashSet<ProjectPersonnelsAudit>();
            Requests = new HashSet<Requests>();
            ScheduleTaskResources = new HashSet<ScheduleTaskResources>();
            Statements = new HashSet<Statements>();
            Visits = new HashSet<Visits>();
        }

        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int PersonnelId { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsChanged { get; set; }
        public string ChangeDate { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsFavourite { get; set; }
        public string FavouriteCatCode { get; set; }

        public virtual ProjectPersonnels ChangedByNavigation { get; set; }
        public virtual Personnels Personnel { get; set; }
        public virtual Projects Project { get; set; }
        public virtual ICollection<ActivityTasks> ActivityTasks { get; set; }
        public virtual ICollection<Approvals> Approvals { get; set; }
        public virtual ICollection<CommitteeMembers> CommitteeMembers { get; set; }
        public virtual ICollection<ProjectPersonnels> InverseChangedByNavigation { get; set; }
        public virtual ICollection<LabRequests> LabRequests { get; set; }
        public virtual ICollection<ProjectPersonnelsAudit> ProjectPersonnelsAudit { get; set; }
        public virtual ICollection<Requests> Requests { get; set; }
        public virtual ICollection<ScheduleTaskResources> ScheduleTaskResources { get; set; }
        public virtual ICollection<Statements> Statements { get; set; }
        public virtual ICollection<Visits> Visits { get; set; }
    }
}
