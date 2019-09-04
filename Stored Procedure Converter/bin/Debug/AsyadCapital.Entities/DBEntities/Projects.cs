using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Projects
    {
        public Projects()
        {
            Approvals = new HashSet<Approvals>();
            AuditTrial = new HashSet<AuditTrial>();
            Comments = new HashSet<Comments>();
            Committees = new HashSet<Committees>();
            Jobs = new HashSet<Jobs>();
            LabRequests = new HashSet<LabRequests>();
            OwnerBudgetProjects = new HashSet<OwnerBudgetProjects>();
            ProjectDepartments = new HashSet<ProjectDepartments>();
            ProjectDocuments = new HashSet<ProjectDocuments>();
            ProjectEquipments = new HashSet<ProjectEquipments>();
            ProjectImages = new HashSet<ProjectImages>();
            ProjectMaterials = new HashSet<ProjectMaterials>();
            ProjectPersonnels = new HashSet<ProjectPersonnels>();
            ProjectProgresses = new HashSet<ProjectProgresses>();
            ProjectProgressesItc = new HashSet<ProjectProgressesItc>();
            ProjectViolations = new HashSet<ProjectViolations>();
            Requests = new HashSet<Requests>();
            ScheduleTasks = new HashSet<ScheduleTasks>();
            Statements = new HashSet<Statements>();
            StudyBoqcomponents = new HashSet<StudyBoqcomponents>();
            StudyBoqitems = new HashSet<StudyBoqitems>();
            Tenders = new HashSet<Tenders>();
            Visits = new HashSet<Visits>();
        }

        public int Id { get; set; }
        public int ProjectTypeId { get; set; }
        public int? MunicipalityId { get; set; }
        public int OwnerId { get; set; }
        public int? ContractorId { get; set; }
        public int? ConsultantId { get; set; }
        public int? ExecutiveConsultantId { get; set; }
        public string Code { get; set; }
        public string CodeSecondary { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public decimal? EstimateProjectCost { get; set; }
        public decimal? ApprovedCost { get; set; }
        public decimal? StudyCost { get; set; }
        public decimal? ContractCost { get; set; }
        public decimal? UpdatedCost { get; set; }
        public decimal? CostAfterDiscount { get; set; }
        public decimal? Discount { get; set; }
        public string BudgetApprovingYear { get; set; }
        public int? BudgetYear { get; set; }
        public DateTime? BudgetApprovingDate { get; set; }
        public DateTime? StudyApprovingDate { get; set; }
        public DateTime? AwardDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ActualFinishDate { get; set; }
        public int? EstimatedStudyDurationDays { get; set; }
        public int? EstimatedDurationDays { get; set; }
        public int? DurationDays { get; set; }
        public string TenderNumber { get; set; }
        public int? StartPhase { get; set; }
        public int? CurrentPhase { get; set; }
        public int? StartStatus { get; set; }
        public int? CurrentStatus { get; set; }
        public decimal? ActualProgress { get; set; }
        public decimal? FinancialProgress { get; set; }
        public decimal? FinancialProgressPaid { get; set; }
        public decimal? DownPayment { get; set; }
        public string ProjectPurpose { get; set; }
        public string Justifications { get; set; }
        public string RelationshipWithProjects { get; set; }
        public string Notes { get; set; }
        public bool? HasPreliminaryStudy { get; set; }
        public bool? IsFiveYearPlan { get; set; }
        public bool IsArchived { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public decimal? DurationProgress { get; set; }
        public DateTime? FinialAcceptancesDate { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public bool? IsProjectGrouped { get; set; }
        public int? ProjectGroupId { get; set; }
        public int? OwnerBudgetItemId { get; set; }
        public bool? IsOwnerBudgetItem { get; set; }
        public string ContactNumber { get; set; }
        public DateTime? ContractDate { get; set; }
        public DateTime? TenderDate { get; set; }
        public string LastProcedure { get; set; }
        public DateTime? LastProcedureDate { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? LastSuspensionDate { get; set; }
        public int? SuspensionsDuration { get; set; }
        public decimal? ForeignCurrencyCost { get; set; }
        public decimal? ExchangeForeignCurrencyCost { get; set; }
        public bool? IsContract { get; set; }
        public bool? IsFinancialRelationship { get; set; }
        public decimal? FinancialRelationshipCost { get; set; }
        public decimal? ExchangePaymentAmount { get; set; }
        public int? LastProcedureId { get; set; }
        public int? BranchId { get; set; }
        public double? LocationLat { get; set; }
        public double? LocationLong { get; set; }
        public int? RegionId { get; set; }
        public int? Order { get; set; }
        public decimal? DiscountOffer { get; set; }
        public decimal? DiscountDownPayment { get; set; }
        public decimal? ProjectProgressWeight { get; set; }
        public int? WorkTypeId { get; set; }
        public int? ProjectSubTypeId { get; set; }
        public decimal? ActualProgressItc { get; set; }
        public decimal? FinancialProgressItc { get; set; }
        public decimal? FinancialProgressPaidItc { get; set; }
        public int? CurrentStatusItc { get; set; }
        public int? CurrentPhaseItc { get; set; }
        public DateTime? LastProgressDateItc { get; set; }
        public decimal? IncomingBudget { get; set; }
        public decimal? ActualDurationProgress { get; set; }
        public decimal? ContractsRatio { get; set; }
        public int? ContractsCount { get; set; }
        public decimal? SupplyOrdersCost { get; set; }
        public int? SupplyOrdersCount { get; set; }
        public bool? IsPortfolio { get; set; }
        public decimal? ValueAddedTaxPercentage { get; set; }
        public int? ProjectSectionCode { get; set; }
        public DateTime? LinkRequestDate { get; set; }
        public DateTime? LinkActualRequestDate { get; set; }
        public DateTime? TenderBidSubmittingDate { get; set; }
        public DateTime? TenderBidEvaluationDate { get; set; }
        public DateTime? TenderBidTransmittalDate { get; set; }

        public virtual Consultants Consultant { get; set; }
        public virtual Contractors Contractor { get; set; }
        public virtual ExecutiveConsultants ExecutiveConsultant { get; set; }
        public virtual Municipalities Municipality { get; set; }
        public virtual Owners Owner { get; set; }
        public virtual ProjectTypes ProjectType { get; set; }
        public virtual ICollection<Approvals> Approvals { get; set; }
        public virtual ICollection<AuditTrial> AuditTrial { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Committees> Committees { get; set; }
        public virtual ICollection<Jobs> Jobs { get; set; }
        public virtual ICollection<LabRequests> LabRequests { get; set; }
        public virtual ICollection<OwnerBudgetProjects> OwnerBudgetProjects { get; set; }
        public virtual ICollection<ProjectDepartments> ProjectDepartments { get; set; }
        public virtual ICollection<ProjectDocuments> ProjectDocuments { get; set; }
        public virtual ICollection<ProjectEquipments> ProjectEquipments { get; set; }
        public virtual ICollection<ProjectImages> ProjectImages { get; set; }
        public virtual ICollection<ProjectMaterials> ProjectMaterials { get; set; }
        public virtual ICollection<ProjectPersonnels> ProjectPersonnels { get; set; }
        public virtual ICollection<ProjectProgresses> ProjectProgresses { get; set; }
        public virtual ICollection<ProjectProgressesItc> ProjectProgressesItc { get; set; }
        public virtual ICollection<ProjectViolations> ProjectViolations { get; set; }
        public virtual ICollection<Requests> Requests { get; set; }
        public virtual ICollection<ScheduleTasks> ScheduleTasks { get; set; }
        public virtual ICollection<Statements> Statements { get; set; }
        public virtual ICollection<StudyBoqcomponents> StudyBoqcomponents { get; set; }
        public virtual ICollection<StudyBoqitems> StudyBoqitems { get; set; }
        public virtual ICollection<Tenders> Tenders { get; set; }
        public virtual ICollection<Visits> Visits { get; set; }
    }
}
