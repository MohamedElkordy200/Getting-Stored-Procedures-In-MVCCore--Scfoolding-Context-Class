using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Statements
    {
        public Statements()
        {
            StatementCommitteeMembers = new HashSet<StatementCommitteeMembers>();
            StatementDailies = new HashSet<StatementDailies>();
            StatementDelays = new HashSet<StatementDelays>();
            StatementEndPeriodInspections = new HashSet<StatementEndPeriodInspections>();
            StatementEndWorkInspections = new HashSet<StatementEndWorkInspections>();
            StatementFinialAcceptances = new HashSet<StatementFinialAcceptances>();
            StatementInitialAcceptances = new HashSet<StatementInitialAcceptances>();
            StatementInitialGroupedAcceptances = new HashSet<StatementInitialGroupedAcceptances>();
            StatementInspections = new HashSet<StatementInspections>();
            StatementItemsInventories = new HashSet<StatementItemsInventories>();
            StatementMeetings = new HashSet<StatementMeetings>();
            StatementMonthelyReport = new HashSet<StatementMonthelyReport>();
            StatementPeriodicals = new HashSet<StatementPeriodicals>();
            StatementProjectScheduleChanges = new HashSet<StatementProjectScheduleChanges>();
            StatementRemovals = new HashSet<StatementRemovals>();
            StatementReportOfEquipments = new HashSet<StatementReportOfEquipments>();
            StatementReportOfMaterials = new HashSet<StatementReportOfMaterials>();
            StatementReportOfTechnicalTeams = new HashSet<StatementReportOfTechnicalTeams>();
            StatementReportOfWorkItems = new HashSet<StatementReportOfWorkItems>();
            StatementResumptions = new HashSet<StatementResumptions>();
            StatementSafetyPrecautions = new HashSet<StatementSafetyPrecautions>();
            StatementScheduleds = new HashSet<StatementScheduleds>();
            StatementSiteTakingOvers = new HashSet<StatementSiteTakingOvers>();
            StatementSuspensions = new HashSet<StatementSuspensions>();
            StatementTenderAwardings = new HashSet<StatementTenderAwardings>();
            StatementTenderBidsClosings = new HashSet<StatementTenderBidsClosings>();
            StatementTenderBidsEvaluations = new HashSet<StatementTenderBidsEvaluations>();
            StatementTenderBidsSigningContracts = new HashSet<StatementTenderBidsSigningContracts>();
            StatementTenderBidsSubmittings = new HashSet<StatementTenderBidsSubmittings>();
            StatementTenderBidsTransmittals = new HashSet<StatementTenderBidsTransmittals>();
            StatementTenderLinkRequests = new HashSet<StatementTenderLinkRequests>();
            StatementTenderSupplement = new HashSet<StatementTenderSupplement>();
            StatementUnplanneds = new HashSet<StatementUnplanneds>();
            StatementViolations = new HashSet<StatementViolations>();
            StatmentCancelDraft = new HashSet<StatmentCancelDraft>();
            StatmentCancelOwnerBudget = new HashSet<StatmentCancelOwnerBudget>();
            StatmentCancelTender = new HashSet<StatmentCancelTender>();
            StatmentContractorWarning = new HashSet<StatmentContractorWarning>();
            StatmentDraft = new HashSet<StatmentDraft>();
            StatmentDraftView = new HashSet<StatmentDraftView>();
            StatmentExtension = new HashSet<StatmentExtension>();
            StatmentFinalDrawWarning = new HashSet<StatmentFinalDrawWarning>();
        }

        public int Id { get; set; }
        public string ActivityCode { get; set; }
        public int ProjectPersonnelId { get; set; }
        public int ProjectId { get; set; }
        public DateTime Date { get; set; }
        public string Code { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Projects Project { get; set; }
        public virtual ProjectPersonnels ProjectPersonnel { get; set; }
        public virtual ICollection<StatementCommitteeMembers> StatementCommitteeMembers { get; set; }
        public virtual ICollection<StatementDailies> StatementDailies { get; set; }
        public virtual ICollection<StatementDelays> StatementDelays { get; set; }
        public virtual ICollection<StatementEndPeriodInspections> StatementEndPeriodInspections { get; set; }
        public virtual ICollection<StatementEndWorkInspections> StatementEndWorkInspections { get; set; }
        public virtual ICollection<StatementFinialAcceptances> StatementFinialAcceptances { get; set; }
        public virtual ICollection<StatementInitialAcceptances> StatementInitialAcceptances { get; set; }
        public virtual ICollection<StatementInitialGroupedAcceptances> StatementInitialGroupedAcceptances { get; set; }
        public virtual ICollection<StatementInspections> StatementInspections { get; set; }
        public virtual ICollection<StatementItemsInventories> StatementItemsInventories { get; set; }
        public virtual ICollection<StatementMeetings> StatementMeetings { get; set; }
        public virtual ICollection<StatementMonthelyReport> StatementMonthelyReport { get; set; }
        public virtual ICollection<StatementPeriodicals> StatementPeriodicals { get; set; }
        public virtual ICollection<StatementProjectScheduleChanges> StatementProjectScheduleChanges { get; set; }
        public virtual ICollection<StatementRemovals> StatementRemovals { get; set; }
        public virtual ICollection<StatementReportOfEquipments> StatementReportOfEquipments { get; set; }
        public virtual ICollection<StatementReportOfMaterials> StatementReportOfMaterials { get; set; }
        public virtual ICollection<StatementReportOfTechnicalTeams> StatementReportOfTechnicalTeams { get; set; }
        public virtual ICollection<StatementReportOfWorkItems> StatementReportOfWorkItems { get; set; }
        public virtual ICollection<StatementResumptions> StatementResumptions { get; set; }
        public virtual ICollection<StatementSafetyPrecautions> StatementSafetyPrecautions { get; set; }
        public virtual ICollection<StatementScheduleds> StatementScheduleds { get; set; }
        public virtual ICollection<StatementSiteTakingOvers> StatementSiteTakingOvers { get; set; }
        public virtual ICollection<StatementSuspensions> StatementSuspensions { get; set; }
        public virtual ICollection<StatementTenderAwardings> StatementTenderAwardings { get; set; }
        public virtual ICollection<StatementTenderBidsClosings> StatementTenderBidsClosings { get; set; }
        public virtual ICollection<StatementTenderBidsEvaluations> StatementTenderBidsEvaluations { get; set; }
        public virtual ICollection<StatementTenderBidsSigningContracts> StatementTenderBidsSigningContracts { get; set; }
        public virtual ICollection<StatementTenderBidsSubmittings> StatementTenderBidsSubmittings { get; set; }
        public virtual ICollection<StatementTenderBidsTransmittals> StatementTenderBidsTransmittals { get; set; }
        public virtual ICollection<StatementTenderLinkRequests> StatementTenderLinkRequests { get; set; }
        public virtual ICollection<StatementTenderSupplement> StatementTenderSupplement { get; set; }
        public virtual ICollection<StatementUnplanneds> StatementUnplanneds { get; set; }
        public virtual ICollection<StatementViolations> StatementViolations { get; set; }
        public virtual ICollection<StatmentCancelDraft> StatmentCancelDraft { get; set; }
        public virtual ICollection<StatmentCancelOwnerBudget> StatmentCancelOwnerBudget { get; set; }
        public virtual ICollection<StatmentCancelTender> StatmentCancelTender { get; set; }
        public virtual ICollection<StatmentContractorWarning> StatmentContractorWarning { get; set; }
        public virtual ICollection<StatmentDraft> StatmentDraft { get; set; }
        public virtual ICollection<StatmentDraftView> StatmentDraftView { get; set; }
        public virtual ICollection<StatmentExtension> StatmentExtension { get; set; }
        public virtual ICollection<StatmentFinalDrawWarning> StatmentFinalDrawWarning { get; set; }
    }
}
