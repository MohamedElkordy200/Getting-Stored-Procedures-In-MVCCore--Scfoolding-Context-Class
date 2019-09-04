using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Visits
    {
        public Visits()
        {
            CommentVisits = new HashSet<CommentVisits>();
            LabRequestWorkItems = new HashSet<LabRequestWorkItems>();
            VisitCancellations = new HashSet<VisitCancellations>();
            VisitCommitteeMembers = new HashSet<VisitCommitteeMembers>();
            VisitDailies = new HashSet<VisitDailies>();
            VisitFiles = new HashSet<VisitFiles>();
            VisitFinialAcceptances = new HashSet<VisitFinialAcceptances>();
            VisitInitialAcceptances = new HashSet<VisitInitialAcceptances>();
            VisitInspections = new HashSet<VisitInspections>();
            VisitMonthelyReport = new HashSet<VisitMonthelyReport>();
            VisitPeriodicals = new HashSet<VisitPeriodicals>();
            VisitReportOfEquipments = new HashSet<VisitReportOfEquipments>();
            VisitReportOfMaterials = new HashSet<VisitReportOfMaterials>();
            VisitReportOfTechnicalTeams = new HashSet<VisitReportOfTechnicalTeams>();
            VisitReportOfWorkItems = new HashSet<VisitReportOfWorkItems>();
            VisitSafetyPrecautions = new HashSet<VisitSafetyPrecautions>();
            VisitScheduleds = new HashSet<VisitScheduleds>();
            VisitSiteTakingOvers = new HashSet<VisitSiteTakingOvers>();
            VisitSuspensions = new HashSet<VisitSuspensions>();
            VisitUnplanneds = new HashSet<VisitUnplanneds>();
        }

        public int Id { get; set; }
        public string ActivityCode { get; set; }
        public int ProjectId { get; set; }
        public int ProjectPersonnelId { get; set; }
        public DateTime Date { get; set; }
        public string Code { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public double? SatisfactionRate { get; set; }
        public string UserImage { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Projects Project { get; set; }
        public virtual ProjectPersonnels ProjectPersonnel { get; set; }
        public virtual ICollection<CommentVisits> CommentVisits { get; set; }
        public virtual ICollection<LabRequestWorkItems> LabRequestWorkItems { get; set; }
        public virtual ICollection<VisitCancellations> VisitCancellations { get; set; }
        public virtual ICollection<VisitCommitteeMembers> VisitCommitteeMembers { get; set; }
        public virtual ICollection<VisitDailies> VisitDailies { get; set; }
        public virtual ICollection<VisitFiles> VisitFiles { get; set; }
        public virtual ICollection<VisitFinialAcceptances> VisitFinialAcceptances { get; set; }
        public virtual ICollection<VisitInitialAcceptances> VisitInitialAcceptances { get; set; }
        public virtual ICollection<VisitInspections> VisitInspections { get; set; }
        public virtual ICollection<VisitMonthelyReport> VisitMonthelyReport { get; set; }
        public virtual ICollection<VisitPeriodicals> VisitPeriodicals { get; set; }
        public virtual ICollection<VisitReportOfEquipments> VisitReportOfEquipments { get; set; }
        public virtual ICollection<VisitReportOfMaterials> VisitReportOfMaterials { get; set; }
        public virtual ICollection<VisitReportOfTechnicalTeams> VisitReportOfTechnicalTeams { get; set; }
        public virtual ICollection<VisitReportOfWorkItems> VisitReportOfWorkItems { get; set; }
        public virtual ICollection<VisitSafetyPrecautions> VisitSafetyPrecautions { get; set; }
        public virtual ICollection<VisitScheduleds> VisitScheduleds { get; set; }
        public virtual ICollection<VisitSiteTakingOvers> VisitSiteTakingOvers { get; set; }
        public virtual ICollection<VisitSuspensions> VisitSuspensions { get; set; }
        public virtual ICollection<VisitUnplanneds> VisitUnplanneds { get; set; }
    }
}
