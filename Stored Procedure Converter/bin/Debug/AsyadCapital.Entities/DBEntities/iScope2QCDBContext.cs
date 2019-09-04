using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class iScope2QCDBContext : DbContext
    {
        public iScope2QCDBContext()
        {
        }

        public iScope2QCDBContext(DbContextOptions<iScope2QCDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbSet<ActivityDecisions> ActivityDecisions { get; set; }
        public virtual DbSet<ActivityDocuments> ActivityDocuments { get; set; }
        public virtual DbSet<ActivityRoles> ActivityRoles { get; set; }
        public virtual DbSet<ActivityStatus> ActivityStatus { get; set; }
        public virtual DbSet<ActivityTasks> ActivityTasks { get; set; }
        public virtual DbSet<ActivityTypes> ActivityTypes { get; set; }
        public virtual DbSet<Approvals> Approvals { get; set; }
        public virtual DbSet<AuditTrial> AuditTrial { get; set; }
        public virtual DbSet<AuditTrialActions> AuditTrialActions { get; set; }
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<CommentFiles> CommentFiles { get; set; }
        public virtual DbSet<CommentVisits> CommentVisits { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<CommitteeMembers> CommitteeMembers { get; set; }
        public virtual DbSet<CommitteeRoles> CommitteeRoles { get; set; }
        public virtual DbSet<Committees> Committees { get; set; }
        public virtual DbSet<Consultants> Consultants { get; set; }
        public virtual DbSet<ContractorClasses> ContractorClasses { get; set; }
        public virtual DbSet<ContractorDocuments> ContractorDocuments { get; set; }
        public virtual DbSet<ContractorFields> ContractorFields { get; set; }
        public virtual DbSet<Contractors> Contractors { get; set; }
        public virtual DbSet<EquipmentStatus> EquipmentStatus { get; set; }
        public virtual DbSet<EquipmentTypes> EquipmentTypes { get; set; }
        public virtual DbSet<Equipments> Equipments { get; set; }
        public virtual DbSet<ExecutiveConsultants> ExecutiveConsultants { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<LabRequestDegreeOfImportance> LabRequestDegreeOfImportance { get; set; }
        public virtual DbSet<LabRequestMaterialItemSamples> LabRequestMaterialItemSamples { get; set; }
        public virtual DbSet<LabRequestMaterialItemTests> LabRequestMaterialItemTests { get; set; }
        public virtual DbSet<LabRequestMaterialItems> LabRequestMaterialItems { get; set; }
        public virtual DbSet<LabRequestMaterials> LabRequestMaterials { get; set; }
        public virtual DbSet<LabRequestWorkItemSamples> LabRequestWorkItemSamples { get; set; }
        public virtual DbSet<LabRequestWorkItemTests> LabRequestWorkItemTests { get; set; }
        public virtual DbSet<LabRequestWorkItems> LabRequestWorkItems { get; set; }
        public virtual DbSet<LabRequests> LabRequests { get; set; }
        public virtual DbSet<Laboratories> Laboratories { get; set; }
        public virtual DbSet<LaboratoryTestTypes> LaboratoryTestTypes { get; set; }
        public virtual DbSet<LaboratoryTests> LaboratoryTests { get; set; }
        public virtual DbSet<LookupBanks> LookupBanks { get; set; }
        public virtual DbSet<LookupBranches> LookupBranches { get; set; }
        public virtual DbSet<LookupDelayReasons> LookupDelayReasons { get; set; }
        public virtual DbSet<LookupDepartments> LookupDepartments { get; set; }
        public virtual DbSet<LookupDocumentCategories> LookupDocumentCategories { get; set; }
        public virtual DbSet<LookupDocumentTypes> LookupDocumentTypes { get; set; }
        public virtual DbSet<LookupMeasureUnits> LookupMeasureUnits { get; set; }
        public virtual DbSet<LookupRoadLayers> LookupRoadLayers { get; set; }
        public virtual DbSet<LookupVacations> LookupVacations { get; set; }
        public virtual DbSet<MaterialTypes> MaterialTypes { get; set; }
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<MobilePushNotifications> MobilePushNotifications { get; set; }
        public virtual DbSet<Models> Models { get; set; }
        public virtual DbSet<Municipalities> Municipalities { get; set; }
        public virtual DbSet<MunicipalityBoundaries> MunicipalityBoundaries { get; set; }
        public virtual DbSet<MwprojectBorrow> MwprojectBorrow { get; set; }
        public virtual DbSet<MwprojectContractors> MwprojectContractors { get; set; }
        public virtual DbSet<MwprojectExecutiveConsultants> MwprojectExecutiveConsultants { get; set; }
        public virtual DbSet<MwprojectIronCement> MwprojectIronCement { get; set; }
        public virtual DbSet<MwprojectTransactionSteps> MwprojectTransactionSteps { get; set; }
        public virtual DbSet<MwtransactionSteps> MwtransactionSteps { get; set; }
        public virtual DbSet<OwnerBudgetItems> OwnerBudgetItems { get; set; }
        public virtual DbSet<OwnerBudgetProjects> OwnerBudgetProjects { get; set; }
        public virtual DbSet<OwnerBudgets> OwnerBudgets { get; set; }
        public virtual DbSet<Owners> Owners { get; set; }
        public virtual DbSet<PaymentProjectConfiguration> PaymentProjectConfiguration { get; set; }
        public virtual DbSet<PaymentRequestPostPay> PaymentRequestPostPay { get; set; }
        public virtual DbSet<PaymentRequestTypes> PaymentRequestTypes { get; set; }
        public virtual DbSet<PaymentRequestWorkItems> PaymentRequestWorkItems { get; set; }
        public virtual DbSet<PaymentRequests> PaymentRequests { get; set; }
        public virtual DbSet<PersonnelConsultants> PersonnelConsultants { get; set; }
        public virtual DbSet<PersonnelContractors> PersonnelContractors { get; set; }
        public virtual DbSet<PersonnelExecutiveConsultants> PersonnelExecutiveConsultants { get; set; }
        public virtual DbSet<PersonnelJobs> PersonnelJobs { get; set; }
        public virtual DbSet<PersonnelLaboratories> PersonnelLaboratories { get; set; }
        public virtual DbSet<PersonnelOwners> PersonnelOwners { get; set; }
        public virtual DbSet<PersonnelProficiencylevels> PersonnelProficiencylevels { get; set; }
        public virtual DbSet<PersonnelQualifications> PersonnelQualifications { get; set; }
        public virtual DbSet<PersonnelSpecialties> PersonnelSpecialties { get; set; }
        public virtual DbSet<PersonnelTypes> PersonnelTypes { get; set; }
        public virtual DbSet<Personnels> Personnels { get; set; }
        public virtual DbSet<ProcessStatus> ProcessStatus { get; set; }
        public virtual DbSet<Processes> Processes { get; set; }
        public virtual DbSet<ProjectCategories> ProjectCategories { get; set; }
        public virtual DbSet<ProjectChildCategories> ProjectChildCategories { get; set; }
        public virtual DbSet<ProjectDepartmentWorkTypes> ProjectDepartmentWorkTypes { get; set; }
        public virtual DbSet<ProjectDepartments> ProjectDepartments { get; set; }
        public virtual DbSet<ProjectDocuments> ProjectDocuments { get; set; }
        public virtual DbSet<ProjectEquipments> ProjectEquipments { get; set; }
        public virtual DbSet<ProjectFoldersCheckLists> ProjectFoldersCheckLists { get; set; }
        public virtual DbSet<ProjectGroups> ProjectGroups { get; set; }
        public virtual DbSet<ProjectImages> ProjectImages { get; set; }
        public virtual DbSet<ProjectMaterials> ProjectMaterials { get; set; }
        public virtual DbSet<ProjectPersonnels> ProjectPersonnels { get; set; }
        public virtual DbSet<ProjectPersonnelsAudit> ProjectPersonnelsAudit { get; set; }
        public virtual DbSet<ProjectPhases> ProjectPhases { get; set; }
        public virtual DbSet<ProjectProgresses> ProjectProgresses { get; set; }
        public virtual DbSet<ProjectProgressesItc> ProjectProgressesItc { get; set; }
        public virtual DbSet<ProjectRelations> ProjectRelations { get; set; }
        public virtual DbSet<ProjectSections> ProjectSections { get; set; }
        public virtual DbSet<ProjectStatus> ProjectStatus { get; set; }
        public virtual DbSet<ProjectStatusProposedActions> ProjectStatusProposedActions { get; set; }
        public virtual DbSet<ProjectSubTypes> ProjectSubTypes { get; set; }
        public virtual DbSet<ProjectTypes> ProjectTypes { get; set; }
        public virtual DbSet<ProjectViolations> ProjectViolations { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<ProvinceBoundaries> ProvinceBoundaries { get; set; }
        public virtual DbSet<Provinces> Provinces { get; set; }
        public virtual DbSet<RegionBoundaries> RegionBoundaries { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<RequestApprovalRequireds> RequestApprovalRequireds { get; set; }
        public virtual DbSet<RequestApprovalTypes> RequestApprovalTypes { get; set; }
        public virtual DbSet<RequestApprovals> RequestApprovals { get; set; }
        public virtual DbSet<RequestBoqchangeItems> RequestBoqchangeItems { get; set; }
        public virtual DbSet<RequestBoqchanges> RequestBoqchanges { get; set; }
        public virtual DbSet<RequestCancellation> RequestCancellation { get; set; }
        public virtual DbSet<RequestDrafts> RequestDrafts { get; set; }
        public virtual DbSet<RequestFinialAcceptances> RequestFinialAcceptances { get; set; }
        public virtual DbSet<RequestFulfillmentAuditDataLists> RequestFulfillmentAuditDataLists { get; set; }
        public virtual DbSet<RequestFulfillmentDetails> RequestFulfillmentDetails { get; set; }
        public virtual DbSet<RequestFulfillments> RequestFulfillments { get; set; }
        public virtual DbSet<RequestInitialAcceptances> RequestInitialAcceptances { get; set; }
        public virtual DbSet<RequestStudyApprovings> RequestStudyApprovings { get; set; }
        public virtual DbSet<RequestSuspensions> RequestSuspensions { get; set; }
        public virtual DbSet<RequestWorkItemBoqinventories> RequestWorkItemBoqinventories { get; set; }
        public virtual DbSet<RequestWorkItems> RequestWorkItems { get; set; }
        public virtual DbSet<RequestWorkItemsDeliveries> RequestWorkItemsDeliveries { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }
        public virtual DbSet<ScheduleTaskDependencies> ScheduleTaskDependencies { get; set; }
        public virtual DbSet<ScheduleTaskProcesses> ScheduleTaskProcesses { get; set; }
        public virtual DbSet<ScheduleTaskProgresses> ScheduleTaskProgresses { get; set; }
        public virtual DbSet<ScheduleTaskRelations> ScheduleTaskRelations { get; set; }
        public virtual DbSet<ScheduleTaskResources> ScheduleTaskResources { get; set; }
        public virtual DbSet<ScheduleTaskStatus> ScheduleTaskStatus { get; set; }
        public virtual DbSet<ScheduleTasks> ScheduleTasks { get; set; }
        public virtual DbSet<Sectors> Sectors { get; set; }
        public virtual DbSet<StatementCommitteeMembers> StatementCommitteeMembers { get; set; }
        public virtual DbSet<StatementDailies> StatementDailies { get; set; }
        public virtual DbSet<StatementDecisions> StatementDecisions { get; set; }
        public virtual DbSet<StatementDelays> StatementDelays { get; set; }
        public virtual DbSet<StatementEndPeriodInspections> StatementEndPeriodInspections { get; set; }
        public virtual DbSet<StatementEndWorkInspections> StatementEndWorkInspections { get; set; }
        public virtual DbSet<StatementFinialAcceptances> StatementFinialAcceptances { get; set; }
        public virtual DbSet<StatementInitialAcceptances> StatementInitialAcceptances { get; set; }
        public virtual DbSet<StatementInitialGroupedAcceptances> StatementInitialGroupedAcceptances { get; set; }
        public virtual DbSet<StatementInspectionWorkItems> StatementInspectionWorkItems { get; set; }
        public virtual DbSet<StatementInspections> StatementInspections { get; set; }
        public virtual DbSet<StatementItemsInventories> StatementItemsInventories { get; set; }
        public virtual DbSet<StatementMeetingAttendences> StatementMeetingAttendences { get; set; }
        public virtual DbSet<StatementMeetings> StatementMeetings { get; set; }
        public virtual DbSet<StatementMonthelyReport> StatementMonthelyReport { get; set; }
        public virtual DbSet<StatementPeriodicals> StatementPeriodicals { get; set; }
        public virtual DbSet<StatementProjectScheduleChangeTasks> StatementProjectScheduleChangeTasks { get; set; }
        public virtual DbSet<StatementProjectScheduleChanges> StatementProjectScheduleChanges { get; set; }
        public virtual DbSet<StatementRemovals> StatementRemovals { get; set; }
        public virtual DbSet<StatementReportOfEquipments> StatementReportOfEquipments { get; set; }
        public virtual DbSet<StatementReportOfMaterials> StatementReportOfMaterials { get; set; }
        public virtual DbSet<StatementReportOfTechnicalTeams> StatementReportOfTechnicalTeams { get; set; }
        public virtual DbSet<StatementReportOfWorkItems> StatementReportOfWorkItems { get; set; }
        public virtual DbSet<StatementResumptions> StatementResumptions { get; set; }
        public virtual DbSet<StatementSafetyPrecautionCheckLists> StatementSafetyPrecautionCheckLists { get; set; }
        public virtual DbSet<StatementSafetyPrecautionRequirements> StatementSafetyPrecautionRequirements { get; set; }
        public virtual DbSet<StatementSafetyPrecautions> StatementSafetyPrecautions { get; set; }
        public virtual DbSet<StatementScheduledDelayReasons> StatementScheduledDelayReasons { get; set; }
        public virtual DbSet<StatementScheduleds> StatementScheduleds { get; set; }
        public virtual DbSet<StatementSiteTakingOvers> StatementSiteTakingOvers { get; set; }
        public virtual DbSet<StatementSuspensions> StatementSuspensions { get; set; }
        public virtual DbSet<StatementTenderAwardings> StatementTenderAwardings { get; set; }
        public virtual DbSet<StatementTenderBidsClosings> StatementTenderBidsClosings { get; set; }
        public virtual DbSet<StatementTenderBidsEvaluations> StatementTenderBidsEvaluations { get; set; }
        public virtual DbSet<StatementTenderBidsSigningContracts> StatementTenderBidsSigningContracts { get; set; }
        public virtual DbSet<StatementTenderBidsSubmittings> StatementTenderBidsSubmittings { get; set; }
        public virtual DbSet<StatementTenderBidsTransmittals> StatementTenderBidsTransmittals { get; set; }
        public virtual DbSet<StatementTenderLinkRequests> StatementTenderLinkRequests { get; set; }
        public virtual DbSet<StatementTenderSupplement> StatementTenderSupplement { get; set; }
        public virtual DbSet<StatementUnplanneds> StatementUnplanneds { get; set; }
        public virtual DbSet<StatementViolations> StatementViolations { get; set; }
        public virtual DbSet<Statements> Statements { get; set; }
        public virtual DbSet<StatementsDecisions> StatementsDecisions { get; set; }
        public virtual DbSet<StatmentCancelDraft> StatmentCancelDraft { get; set; }
        public virtual DbSet<StatmentCancelOwnerBudget> StatmentCancelOwnerBudget { get; set; }
        public virtual DbSet<StatmentCancelTender> StatmentCancelTender { get; set; }
        public virtual DbSet<StatmentContractorWarning> StatmentContractorWarning { get; set; }
        public virtual DbSet<StatmentDraft> StatmentDraft { get; set; }
        public virtual DbSet<StatmentDraftView> StatmentDraftView { get; set; }
        public virtual DbSet<StatmentExtension> StatmentExtension { get; set; }
        public virtual DbSet<StatmentFinalDrawWarning> StatmentFinalDrawWarning { get; set; }
        public virtual DbSet<StudyBoqcomponentPoints> StudyBoqcomponentPoints { get; set; }
        public virtual DbSet<StudyBoqcomponents> StudyBoqcomponents { get; set; }
        public virtual DbSet<StudyBoqitems> StudyBoqitems { get; set; }
        public virtual DbSet<SystemConfigurations> SystemConfigurations { get; set; }
        public virtual DbSet<TenderBidBoqitems> TenderBidBoqitems { get; set; }
        public virtual DbSet<TenderBids> TenderBids { get; set; }
        public virtual DbSet<Tenders> Tenders { get; set; }
        public virtual DbSet<TendersAnnouncementPapers> TendersAnnouncementPapers { get; set; }
        public virtual DbSet<TendersAnnouncements> TendersAnnouncements { get; set; }
        public virtual DbSet<TendersPapers> TendersPapers { get; set; }
        public virtual DbSet<ViolationReasons> ViolationReasons { get; set; }
        public virtual DbSet<ViolationTypes> ViolationTypes { get; set; }
        public virtual DbSet<VisitCancellations> VisitCancellations { get; set; }
        public virtual DbSet<VisitCommitteeMembers> VisitCommitteeMembers { get; set; }
        public virtual DbSet<VisitDailies> VisitDailies { get; set; }
        public virtual DbSet<VisitDecisions> VisitDecisions { get; set; }
        public virtual DbSet<VisitFiles> VisitFiles { get; set; }
        public virtual DbSet<VisitFinialAcceptances> VisitFinialAcceptances { get; set; }
        public virtual DbSet<VisitInitialAcceptances> VisitInitialAcceptances { get; set; }
        public virtual DbSet<VisitInspectionWorkItems> VisitInspectionWorkItems { get; set; }
        public virtual DbSet<VisitInspections> VisitInspections { get; set; }
        public virtual DbSet<VisitMonthelyReport> VisitMonthelyReport { get; set; }
        public virtual DbSet<VisitPeriodicals> VisitPeriodicals { get; set; }
        public virtual DbSet<VisitReportOfEquipments> VisitReportOfEquipments { get; set; }
        public virtual DbSet<VisitReportOfMaterials> VisitReportOfMaterials { get; set; }
        public virtual DbSet<VisitReportOfTechnicalTeams> VisitReportOfTechnicalTeams { get; set; }
        public virtual DbSet<VisitReportOfWorkItems> VisitReportOfWorkItems { get; set; }
        public virtual DbSet<VisitSafetyPrecautionCheckLists> VisitSafetyPrecautionCheckLists { get; set; }
        public virtual DbSet<VisitSafetyPrecautionRequirements> VisitSafetyPrecautionRequirements { get; set; }
        public virtual DbSet<VisitSafetyPrecautions> VisitSafetyPrecautions { get; set; }
        public virtual DbSet<VisitScheduledDelayReasons> VisitScheduledDelayReasons { get; set; }
        public virtual DbSet<VisitScheduleds> VisitScheduleds { get; set; }
        public virtual DbSet<VisitSiteTakingOvers> VisitSiteTakingOvers { get; set; }
        public virtual DbSet<VisitSuspensions> VisitSuspensions { get; set; }
        public virtual DbSet<VisitUnplanneds> VisitUnplanneds { get; set; }
        public virtual DbSet<Visits> Visits { get; set; }
        public virtual DbSet<WorkTypeItemPhases> WorkTypeItemPhases { get; set; }
        public virtual DbSet<WorkTypeItems> WorkTypeItems { get; set; }
        public virtual DbSet<WorkTypeQualities> WorkTypeQualities { get; set; }
        public virtual DbSet<WorkTypes> WorkTypes { get; set; }

        // Unable to generate entity type for table 'dbo.ProjectProcedures'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-CF1UKT7;Database=iScope2QCDB;user id=iscope19;password=I$cope2$$;MultipleActiveResultSets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Activities>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.IconFileName).HasMaxLength(250);

                entity.Property(e => e.IsVisible)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RouteUrl).HasMaxLength(250);

                entity.Property(e => e.TypeName).HasMaxLength(150);
            });

            modelBuilder.Entity<ActivityDecisions>(entity =>
            {
                entity.HasIndex(e => e.ActivityId)
                    .HasName("IX_FK_ActivityActivityDecision");

                entity.HasIndex(e => e.NextActivityId)
                    .HasName("IX_FK_ActivityActivityDecisionRoute");

                entity.HasIndex(e => e.SystemConfigurationId)
                    .HasName("IX_FK_SystemConfigurationActivityDecision");

                entity.Property(e => e.Code)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Decision)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.ProcessStatus)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityDecisionsActivity)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActivityActivityDecision");

                entity.HasOne(d => d.NextActivity)
                    .WithMany(p => p.ActivityDecisionsNextActivity)
                    .HasForeignKey(d => d.NextActivityId)
                    .HasConstraintName("FK_ActivityActivityDecisionRoute");

                entity.HasOne(d => d.SystemConfiguration)
                    .WithMany(p => p.ActivityDecisions)
                    .HasForeignKey(d => d.SystemConfigurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemConfigurationActivityDecision");
            });

            modelBuilder.Entity<ActivityDocuments>(entity =>
            {
                entity.HasIndex(e => e.ActivityId)
                    .HasName("IX_FK_ActivityActivityDocument");

                entity.Property(e => e.DocName).IsRequired();

                entity.Property(e => e.DocType).IsRequired();
            });

            modelBuilder.Entity<ActivityRoles>(entity =>
            {
                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<ActivityStatus>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<ActivityTasks>(entity =>
            {
                entity.HasIndex(e => e.ActivityId)
                    .HasName("IX_FK_ActivityActivityTask");

                entity.HasIndex(e => e.DecisionId)
                    .HasName("IX_FK_ActivityDecisionActivityTask");

                entity.HasIndex(e => e.JobId)
                    .HasName("IX_FK_JobActivityTask");

                entity.HasIndex(e => e.ProjectPersonnelId)
                    .HasName("IX_FK_ProjectPersonnelActivityTask");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.ReferenceDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SkipReasons).HasMaxLength(500);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityTasks)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActivityActivityTask");

                entity.HasOne(d => d.Decision)
                    .WithMany(p => p.ActivityTasks)
                    .HasForeignKey(d => d.DecisionId)
                    .HasConstraintName("FK_ActivityDecisionActivityTask");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.ActivityTasks)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobActivityTask");

                entity.HasOne(d => d.ProjectPersonnel)
                    .WithMany(p => p.ActivityTasks)
                    .HasForeignKey(d => d.ProjectPersonnelId)
                    .HasConstraintName("FK_ProjectPersonnelActivityTask");
            });

            modelBuilder.Entity<ActivityTypes>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Approvals>(entity =>
            {
                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_ProjectApproval");

                entity.HasIndex(e => e.ProjectPersonnelId)
                    .HasName("IX_FK_ProjectPersonnelApproval");

                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Approvals)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectApproval");

                entity.HasOne(d => d.ProjectPersonnel)
                    .WithMany(p => p.Approvals)
                    .HasForeignKey(d => d.ProjectPersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectPersonnelApproval");
            });

            modelBuilder.Entity<AuditTrial>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress).HasColumnName("IPAddress");

                entity.HasOne(d => d.Personnel)
                    .WithMany(p => p.AuditTrial)
                    .HasForeignKey(d => d.PersonnelId)
                    .HasConstraintName("FK_AuditTrial_Personnels");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AuditTrial)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_AuditTrial_Projects");
            });

            modelBuilder.Entity<AuditTrialActions>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Color).HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(500);

                entity.Property(e => e.NameSl).HasMaxLength(500);
            });

            modelBuilder.Entity<Brands>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<CommentFiles>(entity =>
            {
                entity.HasIndex(e => e.CommentId)
                    .HasName("IX_FK_CommentCommentFile");

                entity.HasIndex(e => e.VisitFileId)
                    .HasName("IX_FK_VisitFileCommentFile");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.CommentFiles)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommentCommentFile");

                entity.HasOne(d => d.VisitFile)
                    .WithMany(p => p.CommentFiles)
                    .HasForeignKey(d => d.VisitFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitFileCommentFile");
            });

            modelBuilder.Entity<CommentVisits>(entity =>
            {
                entity.HasIndex(e => e.CommentId)
                    .HasName("IX_FK_CommentCommentVisit");

                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitCommentVisit");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.CommentVisits)
                    .HasForeignKey(d => d.CommentId)
                    .HasConstraintName("FK_CommentCommentVisit");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.CommentVisits)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitCommentVisit");
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_ProjectComment1");

                entity.Property(e => e.Code).HasMaxLength(150);

                entity.Property(e => e.CommentText).IsRequired();

                entity.Property(e => e.CommentType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommentProject");
            });

            modelBuilder.Entity<CommitteeMembers>(entity =>
            {
                entity.HasIndex(e => e.CommitteeId)
                    .HasName("IX_FK_CommitteeCommitteeMember");

                entity.HasIndex(e => e.CommitteeRoleId)
                    .HasName("IX_FK_CommitteeRoleCommitteeMember");

                entity.HasIndex(e => e.ProjectPersonnelId)
                    .HasName("IX_FK_ProjectPersonnelCommitteeMember");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.HasOne(d => d.Committee)
                    .WithMany(p => p.CommitteeMembers)
                    .HasForeignKey(d => d.CommitteeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommitteeCommitteeMember");

                entity.HasOne(d => d.CommitteeRole)
                    .WithMany(p => p.CommitteeMembers)
                    .HasForeignKey(d => d.CommitteeRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommitteeRoleCommitteeMember");

                entity.HasOne(d => d.ProjectPersonnel)
                    .WithMany(p => p.CommitteeMembers)
                    .HasForeignKey(d => d.ProjectPersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectPersonnelCommitteeMember");
            });

            modelBuilder.Entity<CommitteeRoles>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<Committees>(entity =>
            {
                entity.HasIndex(e => e.CopyFromId)
                    .HasName("IX_FK_CommitteeCommittee");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_ProjectCommittee");

                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CommitteeDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.HasOne(d => d.CopyFrom)
                    .WithMany(p => p.InverseCopyFrom)
                    .HasForeignKey(d => d.CopyFromId)
                    .HasConstraintName("FK_CommitteeCommittee");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Committees)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectCommittee");
            });

            modelBuilder.Entity<Consultants>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(14);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LogoFileName).HasMaxLength(250);

                entity.Property(e => e.MobilePrimary).HasMaxLength(14);

                entity.Property(e => e.MobileSecondary).HasMaxLength(14);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);

                entity.Property(e => e.TelephonePrimary).HasMaxLength(14);

                entity.Property(e => e.TelephoneSecondary).HasMaxLength(14);

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.Consultants)
                    .HasForeignKey(d => d.FieldId)
                    .HasConstraintName("FK_Consultants_ContractorFields");
            });

            modelBuilder.Entity<ContractorClasses>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<ContractorDocuments>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(150);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.DescriptionFl).HasMaxLength(100);

                entity.Property(e => e.DescriptionSl).HasMaxLength(100);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FileName).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.Path).HasMaxLength(150);

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.ContractorDocuments)
                    .HasForeignKey(d => d.ContractorId)
                    .HasConstraintName("FK_ContractorDocuments_Contractors");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.ContractorDocuments)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .HasConstraintName("FK_ContractorDocuments_LookupDocumentTypes");
            });

            modelBuilder.Entity<ContractorFields>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<Contractors>(entity =>
            {
                entity.HasIndex(e => e.ClassId)
                    .HasName("IX_FK_ContractorClassContractor");

                entity.HasIndex(e => e.FieldId)
                    .HasName("IX_FK_ContractorFieldContractor");

                entity.Property(e => e.ApprovedCode).HasMaxLength(255);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(14);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LogoFileName).HasMaxLength(250);

                entity.Property(e => e.MandopName).HasMaxLength(255);

                entity.Property(e => e.MobilePrimary).HasMaxLength(14);

                entity.Property(e => e.MobileSecondary).HasMaxLength(14);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);

                entity.Property(e => e.OwnerName).HasMaxLength(255);

                entity.Property(e => e.TelephonePrimary).HasMaxLength(14);

                entity.Property(e => e.TelephoneSecondary).HasMaxLength(14);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Contractors)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorClassContractor");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.Contractors)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorFieldContractor");
            });

            modelBuilder.Entity<EquipmentStatus>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<EquipmentTypes>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<Equipments>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_FK_BrandEquipment");

                entity.HasIndex(e => e.ModelId)
                    .HasName("IX_FK_ModelEquipment");

                entity.HasIndex(e => e.TypeId)
                    .HasName("IX_FK_EquipmentTypeEquipment");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Equipments)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BrandEquipment");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Equipments)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModelEquipment");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Equipments)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquipmentTypeEquipment");
            });

            modelBuilder.Entity<ExecutiveConsultants>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(14);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LogoFileName).HasMaxLength(250);

                entity.Property(e => e.MobilePrimary).HasMaxLength(14);

                entity.Property(e => e.MobileSecondary).HasMaxLength(14);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);

                entity.Property(e => e.TelephonePrimary).HasMaxLength(14);

                entity.Property(e => e.TelephoneSecondary).HasMaxLength(14);

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.ExecutiveConsultants)
                    .HasForeignKey(d => d.FieldId)
                    .HasConstraintName("FK_ExecutiveConsultants_ContractorFields");
            });

            modelBuilder.Entity<Jobs>(entity =>
            {
                entity.HasIndex(e => e.ProcessId)
                    .HasName("IX_FK_ProcessJob");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_ProjectJob");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.ReferenceType)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.ProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcessJob");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectJob");
            });

            modelBuilder.Entity<LabRequestDegreeOfImportance>(entity =>
            {
                entity.Property(e => e.NameFl)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.NameSl)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<LabRequestMaterialItemSamples>(entity =>
            {
                entity.HasIndex(e => e.LabRequestMaterialItemId)
                    .HasName("IX_FK_LabRequestMaterialItemLabRequestMaterialItemSample");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.HasOne(d => d.LabRequestMaterialItem)
                    .WithMany(p => p.LabRequestMaterialItemSamples)
                    .HasForeignKey(d => d.LabRequestMaterialItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LabRequestMaterialItemLabRequestMaterialItemSample");
            });

            modelBuilder.Entity<LabRequestMaterialItemTests>(entity =>
            {
                entity.HasIndex(e => e.LabRequestMaterialItemSampleId)
                    .HasName("IX_FK_LabRequestMaterialItemSampleLabRequestMaterialItemTest");

                entity.HasIndex(e => e.LaboratoryTestId)
                    .HasName("IX_FK_LaboratoryTestLabRequestMaterialItemTest");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.HasOne(d => d.LabRequestMaterialItemSample)
                    .WithMany(p => p.LabRequestMaterialItemTests)
                    .HasForeignKey(d => d.LabRequestMaterialItemSampleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LabRequestMaterialItemSampleLabRequestMaterialItemTest");

                entity.HasOne(d => d.LaboratoryTest)
                    .WithMany(p => p.LabRequestMaterialItemTests)
                    .HasForeignKey(d => d.LaboratoryTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LaboratoryTestLabRequestMaterialItemTest");
            });

            modelBuilder.Entity<LabRequestMaterialItems>(entity =>
            {
                entity.HasIndex(e => e.LabRequestMaterialId)
                    .HasName("IX_FK_LabRequestMaterialLabRequestMaterialItem");

                entity.HasIndex(e => e.ProjectMaterialId)
                    .HasName("IX_FK_ProjectMaterialLabRequestMaterialItem");

                entity.HasOne(d => d.LabRequestMaterial)
                    .WithMany(p => p.LabRequestMaterialItems)
                    .HasForeignKey(d => d.LabRequestMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LabRequestMaterialLabRequestMaterialItem");

                entity.HasOne(d => d.ProjectMaterial)
                    .WithMany(p => p.LabRequestMaterialItems)
                    .HasForeignKey(d => d.ProjectMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectMaterialLabRequestMaterialItem");
            });

            modelBuilder.Entity<LabRequestMaterials>(entity =>
            {
                entity.HasIndex(e => e.LabRequestId)
                    .HasName("IX_FK_LabRequestLabRequestMaterial");

                entity.HasIndex(e => e.LaboratoryId)
                    .HasName("IX_FK_LaboratoryLabRequestMaterial");

                entity.Property(e => e.Remarks).IsRequired();

                entity.Property(e => e.TakeSampleDate).HasColumnType("datetime");

                entity.HasOne(d => d.LabRequest)
                    .WithMany(p => p.LabRequestMaterials)
                    .HasForeignKey(d => d.LabRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LabRequestLabRequestMaterial");

                entity.HasOne(d => d.Laboratory)
                    .WithMany(p => p.LabRequestMaterials)
                    .HasForeignKey(d => d.LaboratoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LaboratoryLabRequestMaterial");
            });

            modelBuilder.Entity<LabRequestWorkItemSamples>(entity =>
            {
                entity.HasIndex(e => e.LabRequestWorkItemId)
                    .HasName("IX_FK_LabRequestWorkItemLabRequestWorkItemSample");

                entity.HasIndex(e => e.VisitInspectionWorkItemId)
                    .HasName("IX_FK_VisitInspectionWorkItemLabRequestWorkItemSample");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.HasOne(d => d.LabRequestWorkItem)
                    .WithMany(p => p.LabRequestWorkItemSamples)
                    .HasForeignKey(d => d.LabRequestWorkItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LabRequestWorkItemLabRequestWorkItemSample");

                entity.HasOne(d => d.VisitInspectionWorkItem)
                    .WithMany(p => p.LabRequestWorkItemSamples)
                    .HasForeignKey(d => d.VisitInspectionWorkItemId)
                    .HasConstraintName("FK_VisitInspectionWorkItemLabRequestWorkItemSample");
            });

            modelBuilder.Entity<LabRequestWorkItemTests>(entity =>
            {
                entity.HasIndex(e => e.LabRequestWorkItemSampleId)
                    .HasName("IX_FK_LabRequestWorkItemSampleLabRequestWorkItemTest");

                entity.HasIndex(e => e.LaboratoryTestId)
                    .HasName("IX_FK_LaboratoryTestLabRequestWorkItemTest");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.HasOne(d => d.LabRequestWorkItemSample)
                    .WithMany(p => p.LabRequestWorkItemTests)
                    .HasForeignKey(d => d.LabRequestWorkItemSampleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LabRequestWorkItemSampleLabRequestWorkItemTest");

                entity.HasOne(d => d.LaboratoryTest)
                    .WithMany(p => p.LabRequestWorkItemTests)
                    .HasForeignKey(d => d.LaboratoryTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LaboratoryTestLabRequestWorkItemTest");
            });

            modelBuilder.Entity<LabRequestWorkItems>(entity =>
            {
                entity.HasIndex(e => e.LabRequestId)
                    .HasName("IX_FK_LabRequestLabRequestWorkItem");

                entity.HasIndex(e => e.LaboratoryId)
                    .HasName("IX_FK_LaboratoryLabRequestWorkItem");

                entity.HasIndex(e => e.RequestWorkItemsDeliveryId)
                    .HasName("IX_FK_RequestWorkItemsDeliveryLabRequestWorkItem");

                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitInspectionReportLabRequestWorkItem");

                entity.Property(e => e.LaboratoryRepresental).HasMaxLength(150);

                entity.Property(e => e.TakeSampleDate).HasColumnType("datetime");

                entity.HasOne(d => d.LabRequest)
                    .WithMany(p => p.LabRequestWorkItems)
                    .HasForeignKey(d => d.LabRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LabRequestLabRequestWorkItem");

                entity.HasOne(d => d.Laboratory)
                    .WithMany(p => p.LabRequestWorkItems)
                    .HasForeignKey(d => d.LaboratoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LaboratoryLabRequestWorkItem");

                entity.HasOne(d => d.RequestWorkItemsDelivery)
                    .WithMany(p => p.LabRequestWorkItems)
                    .HasForeignKey(d => d.RequestWorkItemsDeliveryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestWorkItemsDeliveryLabRequestWorkItem");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.LabRequestWorkItems)
                    .HasForeignKey(d => d.VisitId)
                    .HasConstraintName("FK_LabRequestWorkItemVisit");
            });

            modelBuilder.Entity<LabRequests>(entity =>
            {
                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_ProjectLabRequest");

                entity.HasIndex(e => e.ProjectPersonnelId)
                    .HasName("IX_FK_ProjectPersonnelLabRequest");

                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Code).HasMaxLength(150);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.LabRequests)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectLabRequest");

                entity.HasOne(d => d.ProjectPersonnel)
                    .WithMany(p => p.LabRequests)
                    .HasForeignKey(d => d.ProjectPersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectPersonnelLabRequest");
            });

            modelBuilder.Entity<Laboratories>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(14);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LogoFileName).HasMaxLength(250);

                entity.Property(e => e.MobilePrimary).HasMaxLength(14);

                entity.Property(e => e.MobileSecondary).HasMaxLength(14);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);

                entity.Property(e => e.TelephonePrimary).HasMaxLength(14);

                entity.Property(e => e.TelephoneSecondary).HasMaxLength(14);
            });

            modelBuilder.Entity<LaboratoryTestTypes>(entity =>
            {
                entity.HasIndex(e => e.LaboratoryId)
                    .HasName("IX_FK_LaboratoryLaboratoryTestType");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.HasOne(d => d.Laboratory)
                    .WithMany(p => p.LaboratoryTestTypes)
                    .HasForeignKey(d => d.LaboratoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LaboratoryLaboratoryTestType");
            });

            modelBuilder.Entity<LaboratoryTests>(entity =>
            {
                entity.HasIndex(e => e.LaboratoryTestTypeId)
                    .HasName("IX_FK_LaboratoryTestTypeLaboratoryTest");

                entity.HasIndex(e => e.WorkTypeId)
                    .HasName("IX_FK_WorkTypeLaboratoryTest");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.ScientificName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.LaboratoryTestType)
                    .WithMany(p => p.LaboratoryTests)
                    .HasForeignKey(d => d.LaboratoryTestTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LaboratoryTestTypeLaboratoryTest");

                entity.HasOne(d => d.WorkType)
                    .WithMany(p => p.LaboratoryTests)
                    .HasForeignKey(d => d.WorkTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkTypeLaboratoryTest");
            });

            modelBuilder.Entity<LookupBanks>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LastModifiedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.NameSl)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<LookupBranches>(entity =>
            {
                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LastModifiedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.NameSl)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<LookupDelayReasons>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<LookupDepartments>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(150);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LastModifiedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.NameSl)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<LookupDocumentCategories>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(500);

                entity.Property(e => e.NameSl).HasMaxLength(500);

                entity.HasOne(d => d.PersonnelType)
                    .WithMany(p => p.LookupDocumentCategories)
                    .HasForeignKey(d => d.PersonnelTypeId)
                    .HasConstraintName("FK_LookupDocumentCategory_PersonnelTypes");
            });

            modelBuilder.Entity<LookupDocumentTypes>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(500);

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("(N'iScope')");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsContractor).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("smalldatetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(255);

                entity.Property(e => e.NameSl).HasMaxLength(255);

                entity.Property(e => e.Percentage).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.LookupDocumentCategory)
                    .WithMany(p => p.LookupDocumentTypes)
                    .HasForeignKey(d => d.LookupDocumentCategoryId)
                    .HasConstraintName("FK_LookupDocumentTypes_LookupDocumentCategory");

                entity.HasOne(d => d.PersonnelType)
                    .WithMany(p => p.LookupDocumentTypes)
                    .HasForeignKey(d => d.PersonnelTypeId)
                    .HasConstraintName("FK_LookupDocumentTypes_PersonnelTypes");
            });

            modelBuilder.Entity<LookupMeasureUnits>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.MeasureUnitType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<LookupRoadLayers>(entity =>
            {
                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.NameFl).HasMaxLength(250);

                entity.Property(e => e.NameSl).HasMaxLength(250);
            });

            modelBuilder.Entity<LookupVacations>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.VacationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MaterialTypes>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);
            });

            modelBuilder.Entity<Materials>(entity =>
            {
                entity.HasIndex(e => e.LookupMeasureUnitId)
                    .HasName("IX_FK_LookupMeasureUnitMaterial");

                entity.HasIndex(e => e.MaterialTypeId)
                    .HasName("IX_FK_MaterialTypeMaterial");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.HasOne(d => d.LookupMeasureUnit)
                    .WithMany(p => p.Materials)
                    .HasForeignKey(d => d.LookupMeasureUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LookupMeasureUnitMaterial");

                entity.HasOne(d => d.MaterialType)
                    .WithMany(p => p.Materials)
                    .HasForeignKey(d => d.MaterialTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialTypeMaterial");
            });

            modelBuilder.Entity<MobilePushNotifications>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.DeviceId).IsRequired();

                entity.Property(e => e.IsRegistered)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Models>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_FK_BrandModel");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Models)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BrandModel");
            });

            modelBuilder.Entity<Municipalities>(entity =>
            {
                entity.HasIndex(e => e.ProvinceId)
                    .HasName("IX_FK_ProvinceMunicipality");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);

                entity.Property(e => e.SymbologyColor)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Municipalities)
                    .HasForeignKey(d => d.ProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProvinceMunicipality");
            });

            modelBuilder.Entity<MunicipalityBoundaries>(entity =>
            {
                entity.HasIndex(e => e.MunicipalityId)
                    .HasName("IX_FK_MunicipalityMunicipalityBoundary");

                entity.HasOne(d => d.Municipality)
                    .WithMany(p => p.MunicipalityBoundaries)
                    .HasForeignKey(d => d.MunicipalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MunicipalityMunicipalityBoundary");
            });

            modelBuilder.Entity<MwprojectBorrow>(entity =>
            {
                entity.ToTable("MWProjectBorrow");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.BorrowPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Code).HasMaxLength(350);

                entity.Property(e => e.CompanyName).HasMaxLength(2500);

                entity.Property(e => e.ExchangeDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaidPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProjectCost).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<MwprojectContractors>(entity =>
            {
                entity.ToTable("MWProjectContractors");
            });

            modelBuilder.Entity<MwprojectExecutiveConsultants>(entity =>
            {
                entity.ToTable("MWProjectExecutiveConsultants");
            });

            modelBuilder.Entity<MwprojectIronCement>(entity =>
            {
                entity.ToTable("MWProjectIronCement");

                entity.Property(e => e.AppropriatedPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CementQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Code).HasMaxLength(350);

                entity.Property(e => e.CompanyName).HasMaxLength(2500);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExchangeDate).HasColumnType("datetime");

                entity.Property(e => e.IronQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.ProjectCost).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<MwprojectTransactionSteps>(entity =>
            {
                entity.ToTable("MWProjectTransactionSteps");

                entity.Property(e => e.ActualEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActualStartDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedEndDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedStartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MwtransactionSteps>(entity =>
            {
                entity.ToTable("MWTransactionSteps");

                entity.Property(e => e.Code).HasMaxLength(150);

                entity.Property(e => e.IsSite).HasDefaultValueSql("((0))");

                entity.Property(e => e.NameFl).HasMaxLength(500);

                entity.Property(e => e.NameSl).HasMaxLength(500);

                entity.Property(e => e.Notes).HasMaxLength(500);
            });

            modelBuilder.Entity<OwnerBudgetItems>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(150);

                entity.Property(e => e.ComapctCode).HasMaxLength(150);

                entity.Property(e => e.ComapctNameFl).HasMaxLength(150);

                entity.Property(e => e.ComapctNameSl).HasMaxLength(150);

                entity.Property(e => e.CompactContractCost).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.ContractCost).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);

                entity.HasOne(d => d.OwnerBudget)
                    .WithMany(p => p.OwnerBudgetItems)
                    .HasForeignKey(d => d.OwnerBudgetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OwnerBudgetItems_OwnerBudgets");
            });

            modelBuilder.Entity<OwnerBudgetProjects>(entity =>
            {
                entity.HasIndex(e => e.OwnerBudgetItemsId)
                    .HasName("IX_FK_OwnerBudgetOwnerBudgetProject");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_ProjectOwnerBudgetProject");

                entity.Property(e => e.ActualOutgoingInPastYear).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.OutgoingUntilEndOfYearBeforeLast).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.YearApprovedBudget).HasColumnType("decimal(28, 16)");

                entity.HasOne(d => d.OwnerBudgetItems)
                    .WithMany(p => p.OwnerBudgetProjects)
                    .HasForeignKey(d => d.OwnerBudgetItemsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OwnerBudgetOwnerBudgetProject");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.OwnerBudgetProjects)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectOwnerBudgetProject");
            });

            modelBuilder.Entity<OwnerBudgets>(entity =>
            {
                entity.HasIndex(e => e.OwnerId)
                    .HasName("IX_FK_OwnerOwnerBudget");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.FirstSectionValue).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.FourthSectionValue).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.SecondSectionValue).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.ThirdSectionDirectRevenues).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.ThirdSectionValue).HasColumnType("decimal(28, 16)");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.OwnerBudgets)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OwnerOwnerBudget");
            });

            modelBuilder.Entity<Owners>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(150);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(14);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LogoFileName).HasMaxLength(250);

                entity.Property(e => e.MobilePrimary).HasMaxLength(14);

                entity.Property(e => e.MobileSecondary).HasMaxLength(14);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);

                entity.Property(e => e.TelephonePrimary).HasMaxLength(14);

                entity.Property(e => e.TelephoneSecondary).HasMaxLength(14);
            });

            modelBuilder.Entity<PaymentProjectConfiguration>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.ParentRoleCode)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ParentRoleName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.RoleCode)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<PaymentRequestPostPay>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.DismisselNotesDate).HasColumnType("datetime");

                entity.Property(e => e.DismisselNotesNo)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(28, 4)");

                entity.HasOne(d => d.PaymentRequest)
                    .WithMany(p => p.PaymentRequestPostPay)
                    .HasForeignKey(d => d.PaymentRequestId)
                    .HasConstraintName("FK_PaymentRequestPostPay_PaymentRequests");
            });

            modelBuilder.Entity<PaymentRequestTypes>(entity =>
            {
                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<PaymentRequestWorkItems>(entity =>
            {
                entity.HasIndex(e => e.PaymentRequestId)
                    .HasName("IX_FK_PaymentRequestPaymentRequestWorkItem");

                entity.Property(e => e.PaidQuantity).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.StudyBoqitemId).HasColumnName("StudyBOQItemId");

                entity.HasOne(d => d.PaymentRequest)
                    .WithMany(p => p.PaymentRequestWorkItems)
                    .HasForeignKey(d => d.PaymentRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentRequestIdPaymentRequestWorkItem");

                entity.HasOne(d => d.StudyBoqitem)
                    .WithMany(p => p.PaymentRequestWorkItems)
                    .HasForeignKey(d => d.StudyBoqitemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentRequestPaymentRequestWorkItem");
            });

            modelBuilder.Entity<PaymentRequests>(entity =>
            {
                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_ProjectPaymentRequest");

                entity.HasIndex(e => e.ProjectPersonnelId)
                    .HasName("IX_FK_ProjectPersonnelPaymentRequest");

                entity.Property(e => e.AbsenceSubtraction).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AddingValueAdded).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.AllPaymentRequestSubtraction)
                    .HasColumnType("decimal(34, 4)")
                    .HasComputedColumnSql("((((((isnull([OfferDiscountSubtraction],(0))+isnull([DownPaymentSubtraction],(0)))+isnull([DelaySubtraction],(0)))+isnull([SupervisionSubtraction],(0)))+isnull([AbsenceSubtraction],(0)))+isnull([OtherSubtractions],(0)))+isnull([ViolationsSubtraction],(0)))");

                entity.Property(e => e.Code).HasMaxLength(150);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.DelaySubtraction).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.DelayedValue).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.DiscountValueAdded).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.DismissalNoticeDate).HasColumnType("datetime");

                entity.Property(e => e.DismissalNoticeNo).HasMaxLength(50);

                entity.Property(e => e.DownPaymentSubtraction).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.OfferDiscountSubtraction).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.OtherSubtractions).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.PaymentAmountDue)
                    .HasColumnType("decimal(37, 4)")
                    .HasComputedColumnSql("((isnull([RequestedAmount],(0))+(isnull([ValueAddedTaxAmount],(0))+isnull([AddingValueAdded],(0))))-((((((((isnull([DelayedValue],(0))+isnull([DiscountValueAdded],(0)))+isnull([OfferDiscountSubtraction],(0)))+isnull([DownPaymentSubtraction],(0)))+isnull([DelaySubtraction],(0)))+isnull([SupervisionSubtraction],(0)))+isnull([AbsenceSubtraction],(0)))+isnull([OtherSubtractions],(0)))+isnull([ViolationsSubtraction],(0))))");

                entity.Property(e => e.RequestedAmount).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.SupervisionSubtraction).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.ValueAddedTaxAmount).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.ViolationsSubtraction).HasColumnType("decimal(28, 4)");
            });

            modelBuilder.Entity<PersonnelConsultants>(entity =>
            {
                entity.HasIndex(e => e.ConsultantId)
                    .HasName("IX_FK_ConsultantPersonnelConsultant");

                entity.HasIndex(e => e.PersonnelId)
                    .HasName("IX_FK_PersonnelPersonnelConsultant");

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.PersonnelConsultants)
                    .HasForeignKey(d => d.ConsultantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsultantPersonnelConsultant");

                entity.HasOne(d => d.Personnel)
                    .WithMany(p => p.PersonnelConsultants)
                    .HasForeignKey(d => d.PersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonnelPersonnelConsultant");
            });

            modelBuilder.Entity<PersonnelContractors>(entity =>
            {
                entity.HasIndex(e => e.ContractorId)
                    .HasName("IX_FK_ContractorPersonnelContractor");

                entity.HasIndex(e => e.PersonnelId)
                    .HasName("IX_FK_PersonnelPersonnelContractor");

                entity.HasIndex(e => e.PersonnelProficiencylevelId)
                    .HasName("IX_FK_PersonnelProficiencylevelPersonnelContractor");

                entity.HasIndex(e => e.PersonnelQualificationId)
                    .HasName("IX_FK_PersonnelQualificationPersonnelContractor");

                entity.HasIndex(e => e.PersonnelSpecialtyId)
                    .HasName("IX_FK_PersonnelSpecialtyPersonnelContractor");

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.PersonnelContractors)
                    .HasForeignKey(d => d.ContractorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorPersonnelContractor");

                entity.HasOne(d => d.Personnel)
                    .WithMany(p => p.PersonnelContractors)
                    .HasForeignKey(d => d.PersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonnelPersonnelContractor");

                entity.HasOne(d => d.PersonnelProficiencylevel)
                    .WithMany(p => p.PersonnelContractors)
                    .HasForeignKey(d => d.PersonnelProficiencylevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonnelProficiencylevelPersonnelContractor");

                entity.HasOne(d => d.PersonnelQualification)
                    .WithMany(p => p.PersonnelContractors)
                    .HasForeignKey(d => d.PersonnelQualificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonnelQualificationPersonnelContractor");

                entity.HasOne(d => d.PersonnelSpecialty)
                    .WithMany(p => p.PersonnelContractors)
                    .HasForeignKey(d => d.PersonnelSpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonnelSpecialtyPersonnelContractor");
            });

            modelBuilder.Entity<PersonnelExecutiveConsultants>(entity =>
            {
                entity.HasIndex(e => e.ExecutiveConsultantId)
                    .HasName("IX_FK_ExecutiveConsultantPersonnelExecutiveConsultant");

                entity.HasIndex(e => e.PersonnelId)
                    .HasName("IX_FK_PersonnelPersonnelExecutiveConsultant");

                entity.HasOne(d => d.ExecutiveConsultant)
                    .WithMany(p => p.PersonnelExecutiveConsultants)
                    .HasForeignKey(d => d.ExecutiveConsultantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExecutiveConsultantPersonnelExecutiveConsultant");

                entity.HasOne(d => d.Personnel)
                    .WithMany(p => p.PersonnelExecutiveConsultants)
                    .HasForeignKey(d => d.PersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonnelPersonnelExecutiveConsultant");
            });

            modelBuilder.Entity<PersonnelJobs>(entity =>
            {
                entity.HasIndex(e => e.PersonnelTypeId)
                    .HasName("IX_FK_PersonnelTypePersonnelJob");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);

                entity.HasOne(d => d.PersonnelType)
                    .WithMany(p => p.PersonnelJobs)
                    .HasForeignKey(d => d.PersonnelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonnelTypePersonnelJob");
            });

            modelBuilder.Entity<PersonnelLaboratories>(entity =>
            {
                entity.HasIndex(e => e.LaboratoryId)
                    .HasName("IX_FK_LaboratoryPersonnelLaboratory");

                entity.HasIndex(e => e.PersonnelId)
                    .HasName("IX_FK_PersonnelPersonnelLaboratory");

                entity.HasOne(d => d.Laboratory)
                    .WithMany(p => p.PersonnelLaboratories)
                    .HasForeignKey(d => d.LaboratoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LaboratoryPersonnelLaboratory");

                entity.HasOne(d => d.Personnel)
                    .WithMany(p => p.PersonnelLaboratories)
                    .HasForeignKey(d => d.PersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonnelPersonnelLaboratory");
            });

            modelBuilder.Entity<PersonnelOwners>(entity =>
            {
                entity.HasIndex(e => e.OwnerId)
                    .HasName("IX_FK_OwnerPersonnelOwner");

                entity.HasIndex(e => e.PersonnelId)
                    .HasName("IX_FK_PersonnelPersonnelOwner");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.PersonnelOwners)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OwnerPersonnelOwner");

                entity.HasOne(d => d.Personnel)
                    .WithMany(p => p.PersonnelOwners)
                    .HasForeignKey(d => d.PersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonnelPersonnelOwner");
            });

            modelBuilder.Entity<PersonnelProficiencylevels>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<PersonnelQualifications>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<PersonnelSpecialties>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<PersonnelTypes>(entity =>
            {
                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.IconFileName).HasMaxLength(250);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<Personnels>(entity =>
            {
                entity.HasIndex(e => e.PersonnelJobId)
                    .HasName("IX_FK_PersonnelJobPersonnel");

                entity.HasIndex(e => e.PersonnelTypeId)
                    .HasName("IX_FK_PersonnelTypePersonnel");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.Mobile).HasMaxLength(14);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.PersonnelJob)
                    .WithMany(p => p.Personnels)
                    .HasForeignKey(d => d.PersonnelJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonnelJobPersonnel");

                entity.HasOne(d => d.PersonnelType)
                    .WithMany(p => p.Personnels)
                    .HasForeignKey(d => d.PersonnelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonnelTypePersonnel");
            });

            modelBuilder.Entity<ProcessStatus>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Processes>(entity =>
            {
                entity.Property(e => e.CanDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<ProjectCategories>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);
            });

            modelBuilder.Entity<ProjectChildCategories>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);
            });

            modelBuilder.Entity<ProjectDepartmentWorkTypes>(entity =>
            {
                entity.Property(e => e.ContractPercentage).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.FinancialProgress).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.FinancialRelationshipCost).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.ProjectsChildBudget).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.Remaining).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.StudyCost).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.TotalPaidAmount).HasColumnType("decimal(28, 2)");
            });

            modelBuilder.Entity<ProjectDepartments>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.ProjectDepartments)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentProject");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectDepartments)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectDepartments_Projects");
            });

            modelBuilder.Entity<ProjectDocuments>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.IsVisible).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.Path).HasMaxLength(900);

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.ProjectDocuments)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .HasConstraintName("FK_ProjectDocuments_LookupDocumentTypes");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectDocuments)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_ProjectDocuments_Projects");
            });

            modelBuilder.Entity<ProjectEquipments>(entity =>
            {
                entity.HasIndex(e => e.EquipmentId)
                    .HasName("IX_FK_ProjectEquipments_Equipments");

                entity.HasIndex(e => e.LookupMeasureUnitId)
                    .HasName("IX_FK_LookupMeasureUnitProjectEquipment");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_ProjectEquipments_Projects");

                entity.HasIndex(e => e.StatusId)
                    .HasName("IX_FK_ProjectEquipments_EquipmentStatus");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.ProjectEquipments)
                    .HasForeignKey(d => d.EquipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectEquipments_Equipments");

                entity.HasOne(d => d.LookupMeasureUnit)
                    .WithMany(p => p.ProjectEquipments)
                    .HasForeignKey(d => d.LookupMeasureUnitId)
                    .HasConstraintName("FK_LookupMeasureUnitProjectEquipment");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectEquipments)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectEquipments_Projects");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ProjectEquipments)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectEquipments_EquipmentStatus");
            });

            modelBuilder.Entity<ProjectFoldersCheckLists>(entity =>
            {
                entity.HasIndex(e => e.ParentId)
                    .HasName("IX_FK_ProjectFoldersCheckListProjectFoldersCheckList");

                entity.Property(e => e.NameFl).IsRequired();

                entity.Property(e => e.ReferenceId).IsRequired();

                entity.Property(e => e.ReferenceType).IsRequired();

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_ProjectFoldersCheckListProjectFoldersCheckList");
            });

            modelBuilder.Entity<ProjectGroups>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.IScopeProjectId).HasColumnName("iScopeProjectId");

                entity.Property(e => e.ProjectValue).HasColumnType("decimal(18, 16)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProjectImages>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.FileName).HasMaxLength(250);

                entity.Property(e => e.ImageName).HasMaxLength(250);

                entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsVisible).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectImages)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectImages_Projects");
            });

            modelBuilder.Entity<ProjectMaterials>(entity =>
            {
                entity.HasIndex(e => e.LookupMeasureUnitId)
                    .HasName("IX_FK_LookupMeasureUnitProjectMaterial");

                entity.HasIndex(e => e.MaterialId)
                    .HasName("IX_FK_MaterialProjectMaterial");

                entity.HasIndex(e => e.MaterialTypeId)
                    .HasName("IX_FK_MaterialTypeProjectMaterial");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_ProjectProjectMaterial");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.HasOne(d => d.LookupMeasureUnit)
                    .WithMany(p => p.ProjectMaterials)
                    .HasForeignKey(d => d.LookupMeasureUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LookupMeasureUnitProjectMaterial");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.ProjectMaterials)
                    .HasForeignKey(d => d.MaterialId)
                    .HasConstraintName("FK_MaterialProjectMaterial");

                entity.HasOne(d => d.MaterialType)
                    .WithMany(p => p.ProjectMaterials)
                    .HasForeignKey(d => d.MaterialTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialTypeProjectMaterial");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectMaterials)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectProjectMaterial");
            });

            modelBuilder.Entity<ProjectPersonnels>(entity =>
            {
                entity.HasIndex(e => e.ChangedBy)
                    .HasName("IX_FK_ProjectPersonnelProjectPersonnel");

                entity.HasIndex(e => e.PersonnelId)
                    .HasName("IX_FK_PersonnelProjectPersonnel");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_ProjectProjectPersonnel");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.FavouriteCatCode).HasMaxLength(50);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.InverseChangedByNavigation)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_ProjectPersonnelProjectPersonnel");

                entity.HasOne(d => d.Personnel)
                    .WithMany(p => p.ProjectPersonnels)
                    .HasForeignKey(d => d.PersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonnelProjectPersonnel");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectPersonnels)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectProjectPersonnel");
            });

            modelBuilder.Entity<ProjectPersonnelsAudit>(entity =>
            {
                entity.Property(e => e.AvailableAt).HasColumnType("datetime");

                entity.Property(e => e.AvailableBy).HasMaxLength(150);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.HasOne(d => d.ProjectPersonnels)
                    .WithMany(p => p.ProjectPersonnelsAudit)
                    .HasForeignKey(d => d.ProjectPersonnelsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectPersonnelsAudit_ProjectPersonnels");
            });

            modelBuilder.Entity<ProjectPhases>(entity =>
            {
                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<ProjectProgresses>(entity =>
            {
                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_ProjectProjectProgress");

                entity.Property(e => e.ActualProgress).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.DurationProgress).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.FinancialProgress).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.WeightProgress).HasColumnType("decimal(28, 16)");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectProgresses)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectProjectProgress");
            });

            modelBuilder.Entity<ProjectProgressesItc>(entity =>
            {
                entity.ToTable("ProjectProgressesITC");

                entity.Property(e => e.ActualProgress).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.FinancialProgress).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.FinancialProgressPaid).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsAutoInsert)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProgressDate).HasColumnType("datetime");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectProgressesItc)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectProjectProgressITC");
            });

            modelBuilder.Entity<ProjectSections>(entity =>
            {
                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<ProjectStatus>(entity =>
            {
                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<ProjectStatusProposedActions>(entity =>
            {
                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.ProposedActionLevel).HasMaxLength(150);
            });

            modelBuilder.Entity<ProjectSubTypes>(entity =>
            {
                entity.HasIndex(e => e.ProjectTypeId)
                    .HasName("IX_FK_ProjectTypeProjectSubType");

                entity.Property(e => e.Code).HasMaxLength(150);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);

                entity.HasOne(d => d.ProjectType)
                    .WithMany(p => p.ProjectSubTypes)
                    .HasForeignKey(d => d.ProjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectSubTypes_ProjectTypes");
            });

            modelBuilder.Entity<ProjectTypes>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(150);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.IconFileName).HasMaxLength(250);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<ProjectViolations>(entity =>
            {
                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_ProjectProjectViolation");

                entity.HasIndex(e => e.ViolationTypeId)
                    .HasName("IX_FK_ViolationTypeProjectViolation");

                entity.Property(e => e.Code).HasMaxLength(150);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.ViolationAmount).HasColumnType("decimal(28, 16)");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectViolations)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectProjectViolation");

                entity.HasOne(d => d.ViolationType)
                    .WithMany(p => p.ProjectViolations)
                    .HasForeignKey(d => d.ViolationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ViolationTypeProjectViolation");
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.HasIndex(e => e.ConsultantId)
                    .HasName("IX_FK_ConsultantProject");

                entity.HasIndex(e => e.ContractorId)
                    .HasName("IX_FK_ContractorProject");

                entity.HasIndex(e => e.ExecutiveConsultantId)
                    .HasName("IX_FK_ExecutiveConsultantProject");

                entity.HasIndex(e => e.MunicipalityId)
                    .HasName("IX_FK_MunicipalityProject");

                entity.HasIndex(e => e.OwnerId)
                    .HasName("IX_FK_OwnerProject");

                entity.HasIndex(e => e.ProjectTypeId)
                    .HasName("IX_FK_ProjectTypeProject");

                entity.Property(e => e.ActualDurationProgress)
                    .HasColumnType("decimal(28, 2)")
                    .HasComputedColumnSql("(CONVERT([decimal](28,2),round(CONVERT([decimal](28,4),case when [ActualFinishDate] IS NOT NULL then datediff(day,[StartDate],[ActualFinishDate])-isnull(CONVERT([decimal](28,4),[SuspensionsDuration],(0)),(1)) else (0) end/isnull(CONVERT([decimal](28,4),[DurationDays],(0)),(1)),(0))*(100),(2)),(0)))");

                entity.Property(e => e.ActualFinishDate).HasColumnType("datetime");

                entity.Property(e => e.ActualProgress).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.ActualProgressItc)
                    .HasColumnName("ActualProgressITC")
                    .HasColumnType("decimal(28, 2)");

                entity.Property(e => e.ApprovedCost).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.ArchivedDate).HasColumnType("datetime");

                entity.Property(e => e.AwardDate).HasColumnType("datetime");

                entity.Property(e => e.BudgetApprovingDate).HasColumnType("datetime");

                entity.Property(e => e.BudgetApprovingYear).HasMaxLength(20);

                entity.Property(e => e.Code).HasMaxLength(250);

                entity.Property(e => e.CodeSecondary).HasMaxLength(150);

                entity.Property(e => e.ContactNumber).HasMaxLength(250);

                entity.Property(e => e.ContractCost).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.ContractDate).HasColumnType("datetime");

                entity.Property(e => e.ContractsRatio).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.CostAfterDiscount)
                    .HasColumnType("decimal(38, 6)")
                    .HasComputedColumnSql("((isnull([UpdatedCost],(0))-(isnull([UpdatedCost],(0))*(isnull([Discount],(0))+isnull([DiscountOffer],(0))))/(100))+((isnull([UpdatedCost],(0))-(isnull([UpdatedCost],(0))*(isnull([Discount],(0))+isnull([DiscountOffer],(0))))/(100))*isnull([ValueAddedTaxPercentage],(0)))/(100))");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CurrentPhaseItc).HasColumnName("CurrentPhaseITC");

                entity.Property(e => e.CurrentStatusItc).HasColumnName("CurrentStatusITC");

                entity.Property(e => e.Discount).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.DiscountDownPayment).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.DiscountOffer).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.DownPayment).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.DurationProgress)
                    .HasColumnType("decimal(28, 2)")
                    .HasComputedColumnSql("(CONVERT([decimal](28,2),round(CONVERT([decimal](28,4),(datediff(day,[StartDate],getdate())-(case when [CurrentStatus]=(9) then isnull(datediff(day,[LastSuspensionDate],getdate()),(0)) else (0) end+isnull(CONVERT([decimal](28,4),[SuspensionsDuration],(0)),(1))))/isnull(CONVERT([decimal](28,4),[DurationDays],(0)),(1)),(0))*(100),(2)),(0)))");

                entity.Property(e => e.EstimateProjectCost).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.ExchangeForeignCurrencyCost).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.ExchangePaymentAmount).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.FinancialProgress).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.FinancialProgressItc)
                    .HasColumnName("FinancialProgressITC")
                    .HasColumnType("decimal(28, 2)");

                entity.Property(e => e.FinancialProgressPaid)
                    .HasColumnType("decimal(28, 16)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FinancialProgressPaidItc)
                    .HasColumnName("FinancialProgressPaidITC")
                    .HasColumnType("decimal(28, 2)");

                entity.Property(e => e.FinancialRelationshipCost).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.FinialAcceptancesDate).HasColumnType("datetime");

                entity.Property(e => e.ForeignCurrencyCost).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.IncomingBudget).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsFiveYearPlan).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOwnerBudgetItem).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPortfolio)
                    .IsRequired()
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.IsProjectGrouped).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LastProcedureDate).HasColumnType("datetime");

                entity.Property(e => e.LastProgressDateItc)
                    .HasColumnName("LastProgressDateITC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastSuspensionDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LinkActualRequestDate).HasColumnType("datetime");

                entity.Property(e => e.LinkRequestDate).HasColumnType("datetime");

                entity.Property(e => e.NameFl).HasMaxLength(500);

                entity.Property(e => e.NameSl).HasMaxLength(500);

                entity.Property(e => e.Order).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectProgressWeight).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.ProjectSectionCode).HasDefaultValueSql("((4))");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StudyApprovingDate).HasColumnType("datetime");

                entity.Property(e => e.StudyCost).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.SupplyOrdersCost).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.TenderBidEvaluationDate).HasColumnType("datetime");

                entity.Property(e => e.TenderBidSubmittingDate).HasColumnType("datetime");

                entity.Property(e => e.TenderBidTransmittalDate).HasColumnType("datetime");

                entity.Property(e => e.TenderDate).HasColumnType("datetime");

                entity.Property(e => e.TenderNumber).HasMaxLength(250);

                entity.Property(e => e.UpdatedCost).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.ValueAddedTaxPercentage).HasColumnType("decimal(28, 16)");

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ConsultantId)
                    .HasConstraintName("FK_ConsultantProject");

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ContractorId)
                    .HasConstraintName("FK_ContractorProject");

                entity.HasOne(d => d.ExecutiveConsultant)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ExecutiveConsultantId)
                    .HasConstraintName("FK_ExecutiveConsultantProject");

                entity.HasOne(d => d.Municipality)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.MunicipalityId)
                    .HasConstraintName("FK_MunicipalityProject");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OwnerProject");

                entity.HasOne(d => d.ProjectType)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ProjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projects_ProjectTypes");
            });

            modelBuilder.Entity<ProvinceBoundaries>(entity =>
            {
                entity.HasIndex(e => e.ProvinceId)
                    .HasName("IX_FK_ProvinceProvinceBoundary");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.ProvinceBoundaries)
                    .HasForeignKey(d => d.ProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProvinceProvinceBoundary");
            });

            modelBuilder.Entity<Provinces>(entity =>
            {
                entity.HasIndex(e => e.RegionId)
                    .HasName("IX_FK_RegionProvince");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);

                entity.Property(e => e.SymbologyColor).HasMaxLength(50);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Provinces)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_RegionProvince");
            });

            modelBuilder.Entity<RegionBoundaries>(entity =>
            {
                entity.HasIndex(e => e.RegionId)
                    .HasName("IX_FK_RegionRegionBoundary");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.RegionBoundaries)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegionRegionBoundary");
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.Regions)
                    .HasForeignKey(d => d.SectorId)
                    .HasConstraintName("FK_Regions_Sectors");
            });

            modelBuilder.Entity<RequestApprovalRequireds>(entity =>
            {
                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<RequestApprovalTypes>(entity =>
            {
                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<RequestApprovals>(entity =>
            {
                entity.HasIndex(e => e.RequestApprovalRequiredId)
                    .HasName("IX_FK_RequestApprovalRequiredRequestApproval");

                entity.HasIndex(e => e.RequestApprovalTypeId)
                    .HasName("IX_FK_RequestApprovalTypeRequestApproval");

                entity.HasIndex(e => e.RequestId)
                    .HasName("IX_FK_RequestRequestApproval");

                entity.HasIndex(e => e.StudyBoqitemId)
                    .HasName("IX_FK_StudyBOQItemRequestApproval");

                entity.Property(e => e.StudyBoqitemId).HasColumnName("StudyBOQItemId");

                entity.HasOne(d => d.RequestApprovalRequired)
                    .WithMany(p => p.RequestApprovals)
                    .HasForeignKey(d => d.RequestApprovalRequiredId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestApprovalRequiredRequestApproval");

                entity.HasOne(d => d.RequestApprovalType)
                    .WithMany(p => p.RequestApprovals)
                    .HasForeignKey(d => d.RequestApprovalTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestApprovalTypeRequestApproval");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestApprovals)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestRequestApproval");

                entity.HasOne(d => d.StudyBoqitem)
                    .WithMany(p => p.RequestApprovals)
                    .HasForeignKey(d => d.StudyBoqitemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyBOQItemRequestApproval");
            });

            modelBuilder.Entity<RequestBoqchangeItems>(entity =>
            {
                entity.ToTable("RequestBOQChangeItems");

                entity.HasIndex(e => e.RequestBoqchangeId)
                    .HasName("IX_FK_RequestBOQChangeRequestBOQChangeItem");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.PriceAfter).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.PriceBefore).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.QuantityAfter).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.QuantityBefore).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.RequestBoqchangeId).HasColumnName("RequestBOQChangeId");

                entity.Property(e => e.StudyBoqitemId).HasColumnName("StudyBOQItemId");

                entity.HasOne(d => d.RequestBoqchange)
                    .WithMany(p => p.RequestBoqchangeItems)
                    .HasForeignKey(d => d.RequestBoqchangeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestBOQChangeRequestBOQChangeItem");

                entity.HasOne(d => d.StudyBoqitem)
                    .WithMany(p => p.RequestBoqchangeItems)
                    .HasForeignKey(d => d.StudyBoqitemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestBOQChangeItems_StudyBOQItems");
            });

            modelBuilder.Entity<RequestBoqchanges>(entity =>
            {
                entity.ToTable("RequestBOQChanges");

                entity.HasIndex(e => e.RequestId)
                    .HasName("IX_FK_RequestRequestBOQChange");

                entity.Property(e => e.BudgetChangeRatio).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.BudgetChangeValue).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.DecreasedValue).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.IncreasedValue).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.ProjectCostBeforUpdate).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.TotalBudgetChangeValue).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.UpdatedProjectCost).HasColumnType("decimal(28, 2)");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestBoqchanges)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestRequestBOQChange");
            });

            modelBuilder.Entity<RequestCancellation>(entity =>
            {
                entity.HasIndex(e => e.RequestId)
                    .HasName("IX_FK_RequestRequestCancellation");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestCancellation)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestRequestCancellation");
            });

            modelBuilder.Entity<RequestDrafts>(entity =>
            {
                entity.Property(e => e.DraftDate).HasColumnType("datetime");

                entity.Property(e => e.DraftReasons).IsRequired();

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestDrafts)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestDrafts_Requests");
            });

            modelBuilder.Entity<RequestFinialAcceptances>(entity =>
            {
                entity.HasIndex(e => e.RequestId)
                    .HasName("IX_FK_RequestRequestFinialAcceptance");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestFinialAcceptances)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestRequestFinialAcceptance");
            });

            modelBuilder.Entity<RequestFulfillmentAuditDataLists>(entity =>
            {
                entity.Property(e => e.NameFl).IsRequired();

                entity.Property(e => e.NameSl).IsRequired();
            });

            modelBuilder.Entity<RequestFulfillmentDetails>(entity =>
            {
                entity.HasIndex(e => e.RequestFulfillmentId)
                    .HasName("IX_FK_RequestFulfillmentRequestFulfillmentAuditData");

                entity.Property(e => e.NameFl).IsRequired();

                entity.Property(e => e.NameSl).IsRequired();

                entity.HasOne(d => d.RequestFulfillment)
                    .WithMany(p => p.RequestFulfillmentDetails)
                    .HasForeignKey(d => d.RequestFulfillmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFulfillmentRequestFulfillmentDetail");
            });

            modelBuilder.Entity<RequestFulfillments>(entity =>
            {
                entity.HasIndex(e => e.RequestId)
                    .HasName("IX_FK_RequestRequestFulfillment");

                entity.Property(e => e.HandReview)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ReviewerName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ReviewerPhone)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestFulfillments)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestRequestFulfillment");
            });

            modelBuilder.Entity<RequestInitialAcceptances>(entity =>
            {
                entity.HasIndex(e => e.RequestId)
                    .HasName("IX_FK_RequestRequestInitialAcceptance");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestInitialAcceptances)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestRequestInitialAcceptance");
            });

            modelBuilder.Entity<RequestStudyApprovings>(entity =>
            {
                entity.HasIndex(e => e.RequestId)
                    .HasName("IX_FK_RequestRequestStudyApproving");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestStudyApprovings)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestRequestStudyApproving");
            });

            modelBuilder.Entity<RequestSuspensions>(entity =>
            {
                entity.HasIndex(e => e.RequestId)
                    .HasName("IX_FK_RequestRequestSuspension");

                entity.Property(e => e.Reasons).IsRequired();

                entity.Property(e => e.ResumptionDate).HasColumnType("datetime");

                entity.Property(e => e.SuspensionDate).HasColumnType("datetime");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestSuspensions)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestRequestSuspension");
            });

            modelBuilder.Entity<RequestWorkItemBoqinventories>(entity =>
            {
                entity.ToTable("RequestWorkItemBOQInventories");

                entity.HasIndex(e => e.RequestWorkItemId)
                    .HasName("IX_FK_RequestWorkItemRequestWorkItemBOQInventory");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Height).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.InspectedQuantity).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.Length).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.Width).HasColumnType("decimal(28, 4)");

                entity.HasOne(d => d.RequestWorkItem)
                    .WithMany(p => p.RequestWorkItemBoqinventories)
                    .HasForeignKey(d => d.RequestWorkItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestWorkItemRequestWorkItemBOQInventory");
            });

            modelBuilder.Entity<RequestWorkItems>(entity =>
            {
                entity.HasIndex(e => e.RequestWorkItemsDeliveryId)
                    .HasName("IX_FK_RequestWorkItemsDeliveryRequestWorkItem");

                entity.HasIndex(e => e.StudyBoqitemId)
                    .HasName("IX_FK_StudyBOQItemRequestWorkItem");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Quantity).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.StudyBoqitemId).HasColumnName("StudyBOQItemId");

                entity.HasOne(d => d.RequestWorkItemsDelivery)
                    .WithMany(p => p.RequestWorkItems)
                    .HasForeignKey(d => d.RequestWorkItemsDeliveryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestWorkItemsDeliveryRequestWorkItem");

                entity.HasOne(d => d.StudyBoqitem)
                    .WithMany(p => p.RequestWorkItems)
                    .HasForeignKey(d => d.StudyBoqitemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyBOQItemRequestWorkItem");
            });

            modelBuilder.Entity<RequestWorkItemsDeliveries>(entity =>
            {
                entity.HasIndex(e => e.RequestId)
                    .HasName("IX_FK_RequestRequestWorkItemsDelivery");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestWorkItemsDeliveries)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestRequestWorkItemsDelivery");
            });

            modelBuilder.Entity<Requests>(entity =>
            {
                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_ProjectRequest");

                entity.HasIndex(e => e.ProjectPersonnelId)
                    .HasName("IX_FK_ProjectPersonnelRequest");

                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Requests_Projects");

                entity.HasOne(d => d.ProjectPersonnel)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.ProjectPersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectPersonnelRequest");
            });

            modelBuilder.Entity<ScheduleTaskDependencies>(entity =>
            {
                entity.HasIndex(e => e.BaseTaskId)
                    .HasName("IX_FK_ScheduleTaskScheduleTaskDependency");

                entity.HasIndex(e => e.DependedOnTaskId)
                    .HasName("IX_FK_ScheduleTaskScheduleTaskDependency1");

                entity.HasIndex(e => e.RelationId)
                    .HasName("IX_FK_ScheduleTaskRelationScheduleTaskDependency");

                entity.HasOne(d => d.BaseTask)
                    .WithMany(p => p.ScheduleTaskDependenciesBaseTask)
                    .HasForeignKey(d => d.BaseTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScheduleTaskScheduleTaskDependency");

                entity.HasOne(d => d.DependedOnTask)
                    .WithMany(p => p.ScheduleTaskDependenciesDependedOnTask)
                    .HasForeignKey(d => d.DependedOnTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScheduleTaskScheduleTaskDependency1");

                entity.HasOne(d => d.Relation)
                    .WithMany(p => p.ScheduleTaskDependencies)
                    .HasForeignKey(d => d.RelationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScheduleTaskRelationScheduleTaskDependency");
            });

            modelBuilder.Entity<ScheduleTaskProcesses>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Duration).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceType).HasMaxLength(350);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedCost).HasColumnType("decimal(28, 4)");

                entity.HasOne(d => d.ScheduleTask)
                    .WithMany(p => p.ScheduleTaskProcesses)
                    .HasForeignKey(d => d.ScheduleTaskId)
                    .HasConstraintName("FK_ScheduleTaskProcesses_ScheduleTasks");
            });

            modelBuilder.Entity<ScheduleTaskProgresses>(entity =>
            {
                entity.HasIndex(e => e.TaskId)
                    .HasName("IX_FK_ScheduleTaskScheduleTaskProgress");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Progress).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.ScheduleTaskProgresses)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScheduleTaskScheduleTaskProgress");
            });

            modelBuilder.Entity<ScheduleTaskRelations>(entity =>
            {
                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<ScheduleTaskResources>(entity =>
            {
                entity.HasIndex(e => e.ProjectPersonnelId)
                    .HasName("IX_FK_ProjectPersonnelScheduleTaskResource");

                entity.HasIndex(e => e.TaskId)
                    .HasName("IX_FK_ScheduleTaskScheduleTaskResource");

                entity.HasOne(d => d.ProjectPersonnel)
                    .WithMany(p => p.ScheduleTaskResources)
                    .HasForeignKey(d => d.ProjectPersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectPersonnelScheduleTaskResource");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.ScheduleTaskResources)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScheduleTaskScheduleTaskResource");
            });

            modelBuilder.Entity<ScheduleTaskStatus>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<ScheduleTasks>(entity =>
            {
                entity.Property(e => e.ActivityProgress).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.ActualDuration).HasColumnType("decimal(28, 5)");

                entity.Property(e => e.ActualEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActualMaterialCost).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.ActualStartDate).HasColumnType("datetime");

                entity.Property(e => e.BaseLineEndDate).HasColumnType("datetime");

                entity.Property(e => e.BaseLineStartDate).HasColumnType("datetime");

                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.DurationProgress).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ItemQuantity).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.OriginalDuration).HasColumnType("decimal(28, 5)");

                entity.Property(e => e.Predessors).HasMaxLength(200);

                entity.Property(e => e.Relations).HasMaxLength(200);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartIsMilestone).HasColumnName("startIsMilestone");

                entity.Property(e => e.StartStatusName).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.StudyBoqitemId).HasColumnName("StudyBOQItemId");

                entity.Property(e => e.TargetEndDate).HasColumnType("datetime");

                entity.Property(e => e.TargetStartDate).HasColumnType("datetime");

                entity.Property(e => e.Wbscode)
                    .HasColumnName("WBSCode")
                    .HasMaxLength(700);

                entity.Property(e => e.Wbsname)
                    .HasColumnName("WBSName")
                    .HasMaxLength(700);

                entity.HasOne(d => d.OriginalTask)
                    .WithMany(p => p.InverseOriginalTask)
                    .HasForeignKey(d => d.OriginalTaskId)
                    .HasConstraintName("FK_ScheduleTaskScheduleTask1");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_ScheduleTaskScheduleTask");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ScheduleTasks)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectScheduleTask");

                entity.HasOne(d => d.StudyBoqitem)
                    .WithMany(p => p.ScheduleTasks)
                    .HasForeignKey(d => d.StudyBoqitemId)
                    .HasConstraintName("FK_ScheduleTasksStudyBOQItems");
            });

            modelBuilder.Entity<Sectors>(entity =>
            {
                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<StatementCommitteeMembers>(entity =>
            {
                entity.HasOne(d => d.CommitteeMember)
                    .WithMany(p => p.StatementCommitteeMembers)
                    .HasForeignKey(d => d.CommitteeMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommitteeMemberStatementCommitteeMembers");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementCommitteeMembers)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementCommitteeMembers");
            });

            modelBuilder.Entity<StatementDailies>(entity =>
            {
                entity.Property(e => e.Temperature).HasMaxLength(150);

                entity.Property(e => e.Weather).HasMaxLength(150);

                entity.Property(e => e.Wind).HasMaxLength(150);

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementDailies)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementDaily");
            });

            modelBuilder.Entity<StatementDecisions>(entity =>
            {
                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameFl).IsRequired();

                entity.Property(e => e.NameSl).IsRequired();
            });

            modelBuilder.Entity<StatementDelays>(entity =>
            {
                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_FK_StatementStatementDelay");

                entity.Property(e => e.Reasons).IsRequired();

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementDelays)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementDelay");
            });

            modelBuilder.Entity<StatementEndPeriodInspections>(entity =>
            {
                entity.Property(e => e.EndPeriodDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectActualProgress).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProjectDurationProgress).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProjectWeightProgress).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementEndPeriodInspections)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementEndPeriodInspection");
            });

            modelBuilder.Entity<StatementEndWorkInspections>(entity =>
            {
                entity.Property(e => e.EndWorkDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectActualProgress).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProjectDurationProgress).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProjectWeightProgress).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementEndWorkInspections)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementEndWorkInspection");
            });

            modelBuilder.Entity<StatementFinialAcceptances>(entity =>
            {
                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_FK_StatementStatementFinialAcceptance");

                entity.Property(e => e.ActualFinishDate).HasColumnType("datetime");

                entity.Property(e => e.Decision).IsRequired();

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementFinialAcceptances)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementFinialAcceptance");
            });

            modelBuilder.Entity<StatementInitialAcceptances>(entity =>
            {
                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_FK_StatementStatementInitialAcceptance");

                entity.Property(e => e.Decision).IsRequired();

                entity.Property(e => e.InitialAcceptanceDate).HasColumnType("datetime");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementInitialAcceptances)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementInitialAcceptance");
            });

            modelBuilder.Entity<StatementInitialGroupedAcceptances>(entity =>
            {
                entity.Property(e => e.Decision).IsRequired();

                entity.Property(e => e.InitialAcceptanceDate).HasColumnType("datetime");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementInitialGroupedAcceptances)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementInitialGroupedAcceptance");
            });

            modelBuilder.Entity<StatementInspectionWorkItems>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Height).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.Length).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.RequestWorkItemBoqinventoryId).HasColumnName("RequestWorkItemBOQInventoryId");

                entity.Property(e => e.StudyBoqitemId).HasColumnName("StudyBOQItemId");

                entity.Property(e => e.Width).HasColumnType("decimal(28, 4)");

                entity.HasOne(d => d.PaymentRequest)
                    .WithMany(p => p.StatementInspectionWorkItems)
                    .HasForeignKey(d => d.PaymentRequestId)
                    .HasConstraintName("FK_PaymentRequestStatementInspectionWorkItem");

                entity.HasOne(d => d.RequestWorkItemBoqinventory)
                    .WithMany(p => p.StatementInspectionWorkItems)
                    .HasForeignKey(d => d.RequestWorkItemBoqinventoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestWorkItemBOQInventoryStatementInspectionWorkItem");

                entity.HasOne(d => d.StatementInspection)
                    .WithMany(p => p.StatementInspectionWorkItems)
                    .HasForeignKey(d => d.StatementInspectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementInspectionStatementInspectionWorkItem");

                entity.HasOne(d => d.StudyBoqitem)
                    .WithMany(p => p.StatementInspectionWorkItems)
                    .HasForeignKey(d => d.StudyBoqitemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyBOQItemStatementInspectionWorkItem");
            });

            modelBuilder.Entity<StatementInspections>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.HasOne(d => d.RequestWorkItemsDelivery)
                    .WithMany(p => p.StatementInspections)
                    .HasForeignKey(d => d.RequestWorkItemsDeliveryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestWorkItemsDeliveryStatementInspection");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementInspections)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementInspection");
            });

            modelBuilder.Entity<StatementItemsInventories>(entity =>
            {
                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_FK_StatementStatementInventory");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementItemsInventories)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementInventory");
            });

            modelBuilder.Entity<StatementMeetingAttendences>(entity =>
            {
                entity.HasIndex(e => e.StatementMeetingId)
                    .HasName("IX_FK_StatementMeetingStatementMeetingAttendences");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Resource).IsRequired();

                entity.HasOne(d => d.StatementMeeting)
                    .WithMany(p => p.StatementMeetingAttendences)
                    .HasForeignKey(d => d.StatementMeetingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementMeetingStatementMeetingAttendences");
            });

            modelBuilder.Entity<StatementMeetings>(entity =>
            {
                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_FK_StatementStatementMeeting");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Place).IsRequired();

                entity.Property(e => e.Recommendations).IsRequired();

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Topics).IsRequired();

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementMeetings)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementMeeting");
            });

            modelBuilder.Entity<StatementMonthelyReport>(entity =>
            {
                entity.Property(e => e.ActualProgressItc)
                    .HasColumnName("ActualProgressITC")
                    .HasColumnType("decimal(28, 2)");

                entity.Property(e => e.CurrentPhaseItc).HasColumnName("CurrentPhaseITC");

                entity.Property(e => e.CurrentStatusItc).HasColumnName("CurrentStatusITC");

                entity.Property(e => e.DurationProgressItc)
                    .HasColumnName("DurationProgressITC")
                    .HasColumnType("decimal(28, 2)");

                entity.Property(e => e.FinancialProgressItc)
                    .HasColumnName("FinancialProgressITC")
                    .HasColumnType("decimal(28, 2)");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementMonthelyReport)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementMonthelyReport");
            });

            modelBuilder.Entity<StatementPeriodicals>(entity =>
            {
                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.ProgressPercentagDuration).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.ProgressPercentagPayments).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.ProgressPercentagWorkItems).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementPeriodicals)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementPeriodical");
            });

            modelBuilder.Entity<StatementProjectScheduleChangeTasks>(entity =>
            {
                entity.HasIndex(e => e.StatementProjectScheduleChangeId)
                    .HasName("IX_FK_StatementProjectScheduleChangeStatementProjectScheduleChangeTask");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.FromDateAfter).HasColumnType("datetime");

                entity.Property(e => e.FromDateBefore).HasColumnType("datetime");

                entity.Property(e => e.QuantityAfter).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.QuantityBefore).HasColumnType("decimal(28, 16)");

                entity.Property(e => e.ToDateAfter).HasColumnType("datetime");

                entity.Property(e => e.ToDateBefore).HasColumnType("datetime");

                entity.HasOne(d => d.StatementProjectScheduleChange)
                    .WithMany(p => p.StatementProjectScheduleChangeTasks)
                    .HasForeignKey(d => d.StatementProjectScheduleChangeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementProjectScheduleChangeStatementProjectScheduleChangeTask");
            });

            modelBuilder.Entity<StatementProjectScheduleChanges>(entity =>
            {
                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_FK_StatementStatementProjectScheduleChange");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementProjectScheduleChanges)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementProjectScheduleChange");
            });

            modelBuilder.Entity<StatementRemovals>(entity =>
            {
                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_FK_StatementStatementRemoval");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementRemovals)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementRemoval");
            });

            modelBuilder.Entity<StatementReportOfEquipments>(entity =>
            {
                entity.HasOne(d => d.ProjectEquipment)
                    .WithMany(p => p.StatementReportOfEquipments)
                    .HasForeignKey(d => d.ProjectEquipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectEquipmentStatementReportOfEquipment");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementReportOfEquipments)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementReportOfEquipment");
            });

            modelBuilder.Entity<StatementReportOfMaterials>(entity =>
            {
                entity.HasOne(d => d.ProjectMaterial)
                    .WithMany(p => p.StatementReportOfMaterials)
                    .HasForeignKey(d => d.ProjectMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectMaterialStatementReportOfMaterial");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementReportOfMaterials)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementReportOfMaterial");
            });

            modelBuilder.Entity<StatementReportOfTechnicalTeams>(entity =>
            {
                entity.HasOne(d => d.PersonnelJob)
                    .WithMany(p => p.StatementReportOfTechnicalTeams)
                    .HasForeignKey(d => d.PersonnelJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonnelJobStatementReportOfTechnicalTeam");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementReportOfTechnicalTeams)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementReportOfTechnicalTeam");
            });

            modelBuilder.Entity<StatementReportOfWorkItems>(entity =>
            {
                entity.Property(e => e.CompletePercentage).HasColumnType("decimal(28, 2)");

                entity.HasOne(d => d.Quality)
                    .WithMany(p => p.StatementReportOfWorkItems)
                    .HasForeignKey(d => d.QualityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkTypeQualityStatementReportOfWorkItem");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementReportOfWorkItems)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementReportOfWorkItem");

                entity.HasOne(d => d.WorkType)
                    .WithMany(p => p.StatementReportOfWorkItems)
                    .HasForeignKey(d => d.WorkTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkTypeStatementReportOfWorkItem");
            });

            modelBuilder.Entity<StatementResumptions>(entity =>
            {
                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_FK_StatementStatementResumption");

                entity.Property(e => e.ResumptionDate).HasColumnType("datetime");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementResumptions)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementResumption");
            });

            modelBuilder.Entity<StatementSafetyPrecautionCheckLists>(entity =>
            {
                entity.Property(e => e.IsAvailable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.StatementSafetyPrecaution)
                    .WithMany(p => p.StatementSafetyPrecautionCheckLists)
                    .HasForeignKey(d => d.StatementSafetyPrecautionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementSafetyPrecautionStatementSafetyPrecautionCheckList");

                entity.HasOne(d => d.StatementSafetyPrecautionRequirement)
                    .WithMany(p => p.StatementSafetyPrecautionCheckLists)
                    .HasForeignKey(d => d.StatementSafetyPrecautionRequirementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementSafetyPrecautionRequirementStatementSafetyPrecautionCheckList");
            });

            modelBuilder.Entity<StatementSafetyPrecautionRequirements>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<StatementSafetyPrecautions>(entity =>
            {
                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementSafetyPrecautions)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementSafetyPrecaution");
            });

            modelBuilder.Entity<StatementScheduledDelayReasons>(entity =>
            {
                entity.HasOne(d => d.LookupDelayReason)
                    .WithMany(p => p.StatementScheduledDelayReasons)
                    .HasForeignKey(d => d.LookupDelayReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LookupDelayReasonStatementScheduledDelayReason");

                entity.HasOne(d => d.StatementScheduled)
                    .WithMany(p => p.StatementScheduledDelayReasons)
                    .HasForeignKey(d => d.StatementScheduledId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementScheduledStatementScheduledDelayReason");
            });

            modelBuilder.Entity<StatementScheduleds>(entity =>
            {
                entity.Property(e => e.ProgressPercentagDuration).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.ProgressPercentagTimeplan).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.ProgressPercentagWorkItems).HasColumnType("decimal(28, 2)");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementScheduleds)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementScheduled");
            });

            modelBuilder.Entity<StatementSiteTakingOvers>(entity =>
            {
                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_FK_StatementStatementSiteTakingOverDetail");

                entity.Property(e => e.Decision).IsRequired();

                entity.Property(e => e.TakingOverDate).HasColumnType("datetime");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementSiteTakingOvers)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementSiteTakingOver");
            });

            modelBuilder.Entity<StatementSuspensions>(entity =>
            {
                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_FK_StatementStatementSuspension");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementSuspensions)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementSuspension");
            });

            modelBuilder.Entity<StatementTenderAwardings>(entity =>
            {
                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_FK_StatementStatementTenderAwarding");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementTenderAwardings)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementTenderAwarding");
            });

            modelBuilder.Entity<StatementTenderBidsClosings>(entity =>
            {
                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_FK_StatementStatementTenderBidsClosing");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementTenderBidsClosings)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementTenderBidsClosing");
            });

            modelBuilder.Entity<StatementTenderBidsEvaluations>(entity =>
            {
                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_FK_StatementStatementTenderBidsEvaluation");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementTenderBidsEvaluations)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementTenderBidsEvaluation");
            });

            modelBuilder.Entity<StatementTenderBidsSigningContracts>(entity =>
            {
                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_FK_StatementStatementTenderBidsSigningContract");

                entity.Property(e => e.FinalAssuranceBankName)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("(N'--')");

                entity.Property(e => e.FinalAssuranceNo)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FinalAssuranceValidFrom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FinalAssuranceValidTo)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FinalAssuranceValue)
                    .HasColumnType("decimal(28, 16)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementTenderBidsSigningContracts)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementTenderBidsSigningContract");
            });

            modelBuilder.Entity<StatementTenderBidsSubmittings>(entity =>
            {
                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_FK_StatementStatementTenderBidsSubmitting");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementTenderBidsSubmittings)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementTenderBidsSubmitting");
            });

            modelBuilder.Entity<StatementTenderBidsTransmittals>(entity =>
            {
                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_FK_StatementStatementTenderBidsTransmittal");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementTenderBidsTransmittals)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementTenderBidsTransmittal");
            });

            modelBuilder.Entity<StatementTenderLinkRequests>(entity =>
            {
                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementTenderLinkRequests)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementTenderLinkRequests_Statements");
            });

            modelBuilder.Entity<StatementTenderSupplement>(entity =>
            {
                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementTenderSupplement)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementSupplement");
            });

            modelBuilder.Entity<StatementUnplanneds>(entity =>
            {
                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementUnplanneds)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementUnplanned");
            });

            modelBuilder.Entity<StatementViolations>(entity =>
            {
                entity.HasIndex(e => e.PaymentRequestId)
                    .HasName("IX_FK_PaymentRequestStatementViolation");

                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_FK_StatementStatementViolation");

                entity.Property(e => e.PenaltiesDesc).IsRequired();

                entity.Property(e => e.PenaltiesValue).HasColumnType("decimal(28, 2)");

                entity.HasOne(d => d.PaymentRequest)
                    .WithMany(p => p.StatementViolations)
                    .HasForeignKey(d => d.PaymentRequestId)
                    .HasConstraintName("FK_PaymentRequestStatementViolation");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.StatementViolations)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementStatementViolation");
            });

            modelBuilder.Entity<Statements>(entity =>
            {
                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_ProjectStatement");

                entity.HasIndex(e => e.ProjectPersonnelId)
                    .HasName("IX_FK_ProjectPersonnelStatement");

                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Code).HasMaxLength(150);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Statements)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectStatement");

                entity.HasOne(d => d.ProjectPersonnel)
                    .WithMany(p => p.Statements)
                    .HasForeignKey(d => d.ProjectPersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectPersonnelStatement");
            });

            modelBuilder.Entity<StatementsDecisions>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.NameFl).IsRequired();

                entity.Property(e => e.NameSl).IsRequired();

                entity.Property(e => e.ProcessCode).IsRequired();
            });

            modelBuilder.Entity<StatmentCancelDraft>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Statment)
                    .WithMany(p => p.StatmentCancelDraft)
                    .HasForeignKey(d => d.StatmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatmentCancelDraft_Statements");
            });

            modelBuilder.Entity<StatmentCancelOwnerBudget>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Statment)
                    .WithMany(p => p.StatmentCancelOwnerBudget)
                    .HasForeignKey(d => d.StatmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatmentCancelOwnerBudget_Statements");
            });

            modelBuilder.Entity<StatmentCancelTender>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Statment)
                    .WithMany(p => p.StatmentCancelTender)
                    .HasForeignKey(d => d.StatmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatmentCancelTender_Statements");
            });

            modelBuilder.Entity<StatmentContractorWarning>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Statment)
                    .WithMany(p => p.StatmentContractorWarning)
                    .HasForeignKey(d => d.StatmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatmentContractorWarning_Statements");
            });

            modelBuilder.Entity<StatmentDraft>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Statment)
                    .WithMany(p => p.StatmentDraft)
                    .HasForeignKey(d => d.StatmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatmentDraft_Statements");
            });

            modelBuilder.Entity<StatmentDraftView>(entity =>
            {
                entity.Property(e => e.DraftViewDate).HasColumnType("datetime");

                entity.Property(e => e.DraftViewReasons).IsRequired();

                entity.HasOne(d => d.Statment)
                    .WithMany(p => p.StatmentDraftView)
                    .HasForeignKey(d => d.StatmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatmentDraftView_Statements");
            });

            modelBuilder.Entity<StatmentExtension>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Statment)
                    .WithMany(p => p.StatmentExtension)
                    .HasForeignKey(d => d.StatmentId)
                    .HasConstraintName("FK_StatmentExtension_Statements");
            });

            modelBuilder.Entity<StatmentFinalDrawWarning>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Statment)
                    .WithMany(p => p.StatmentFinalDrawWarning)
                    .HasForeignKey(d => d.StatmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatmentFinalDrawWarning_Statements");
            });

            modelBuilder.Entity<StudyBoqcomponentPoints>(entity =>
            {
                entity.ToTable("StudyBOQComponentPoints");

                entity.HasIndex(e => e.ComponentId)
                    .HasName("IX_FK_StudyBOQComponentStudyBOQComponentPoint");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.KmlfileName)
                    .HasColumnName("KMLFileName")
                    .HasMaxLength(250);

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.StudyBoqcomponentPoints)
                    .HasForeignKey(d => d.ComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyBOQComponentStudyBOQComponentPoint");
            });

            modelBuilder.Entity<StudyBoqcomponents>(entity =>
            {
                entity.ToTable("StudyBOQComponents");

                entity.HasIndex(e => e.ParentId)
                    .HasName("IX_FK_StudyBOQComponentStudyBOQComponent");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_ProjectStudyBOQComponent");

                entity.HasIndex(e => e.RoadLayerId)
                    .HasName("IX_FK_LookupRoadLayerStudyBOQComponent");

                entity.Property(e => e.Area).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Code).HasMaxLength(150);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_StudyBOQComponentStudyBOQComponent");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.StudyBoqcomponents)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectStudyBOQComponent");

                entity.HasOne(d => d.RoadLayer)
                    .WithMany(p => p.StudyBoqcomponents)
                    .HasForeignKey(d => d.RoadLayerId)
                    .HasConstraintName("FK_LookupRoadLayerStudyBOQComponent");
            });

            modelBuilder.Entity<StudyBoqitems>(entity =>
            {
                entity.ToTable("StudyBOQItems");

                entity.HasIndex(e => e.ComponentId)
                    .HasName("IX_FK_StudyBOQComponentStudyBOQItem");

                entity.HasIndex(e => e.ItemId)
                    .HasName("IX_FK_StudyBOQItemStudyBOQItem");

                entity.HasIndex(e => e.LookupMeasureUnitId)
                    .HasName("IX_FK_LookupMeasureUnitStudyBOQItem");

                entity.HasIndex(e => e.WorkTypeId)
                    .HasName("IX_FK_WorkTypeStudyBOQItem");

                entity.Property(e => e.Code).HasMaxLength(150);

                entity.Property(e => e.ConsultantPrice).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.ContractorPrice).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.DeliveredQuantity).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.FirstActivityDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.OriginalQuantity).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.PaidQuantity).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(28, 4)")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.StudyBoqitems)
                    .HasForeignKey(d => d.ComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyBOQComponentStudyBOQItem");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InverseItem)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_StudyBOQItemStudyBOQItem");

                entity.HasOne(d => d.LookupMeasureUnit)
                    .WithMany(p => p.StudyBoqitems)
                    .HasForeignKey(d => d.LookupMeasureUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LookupMeasureUnitStudyBOQItem");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.StudyBoqitems)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_ProjectsStudyBOQItem");

                entity.HasOne(d => d.WorkType)
                    .WithMany(p => p.StudyBoqitems)
                    .HasForeignKey(d => d.WorkTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkTypeStudyBOQItem");
            });

            modelBuilder.Entity<SystemConfigurations>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<TenderBidBoqitems>(entity =>
            {
                entity.ToTable("TenderBidBOQItems");

                entity.HasIndex(e => e.StudyBoqitemId)
                    .HasName("IX_FK_StudyBOQItemTenderBidBOQItem");

                entity.HasIndex(e => e.TenderBidId)
                    .HasName("IX_FK_TenderBidTenderBidBOQItem");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.Price).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.StudyBoqitemId).HasColumnName("StudyBOQItemId");

                entity.HasOne(d => d.StudyBoqitem)
                    .WithMany(p => p.TenderBidBoqitems)
                    .HasForeignKey(d => d.StudyBoqitemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyBOQItemTenderBidBOQItem");

                entity.HasOne(d => d.TenderBid)
                    .WithMany(p => p.TenderBidBoqitems)
                    .HasForeignKey(d => d.TenderBidId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenderBidTenderBidBOQItem");
            });

            modelBuilder.Entity<TenderBids>(entity =>
            {
                entity.HasIndex(e => e.ContractorId)
                    .HasName("IX_FK_ContractorTenderBid");

                entity.HasIndex(e => e.TenderId)
                    .HasName("IX_FK_TenderTenderBid");

                entity.Property(e => e.AssuranceBankName).HasMaxLength(150);

                entity.Property(e => e.AssuranceNo).HasMaxLength(150);

                entity.Property(e => e.AssuranceValidFrom).HasColumnType("datetime");

                entity.Property(e => e.AssuranceValidTo).HasColumnType("datetime");

                entity.Property(e => e.AssuranceValue).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.BidDate).HasColumnType("datetime");

                entity.Property(e => e.BidValue).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.HasOne(d => d.Contractor)
                    .WithMany(p => p.TenderBids)
                    .HasForeignKey(d => d.ContractorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractorTenderBid");

                entity.HasOne(d => d.Tender)
                    .WithMany(p => p.TenderBids)
                    .HasForeignKey(d => d.TenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenderTenderBid");
            });

            modelBuilder.Entity<Tenders>(entity =>
            {
                entity.HasIndex(e => e.AnnouncementId)
                    .HasName("IX_FK_TendersAnnouncementTender");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_ProjectTender");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastBidDate).HasColumnType("datetime");

                entity.Property(e => e.SubmittingBidsDate).HasColumnType("datetime");

                entity.Property(e => e.TenderNumber)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ValueDocumentes).HasColumnType("decimal(28, 2)");

                entity.HasOne(d => d.Announcement)
                    .WithMany(p => p.Tenders)
                    .HasForeignKey(d => d.AnnouncementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TendersAnnouncementTender");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Tenders)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectTender");
            });

            modelBuilder.Entity<TendersAnnouncementPapers>(entity =>
            {
                entity.HasIndex(e => e.AnnouncementId)
                    .HasName("IX_FK_TendersAnnouncementTendersAnnouncementPaper");

                entity.HasIndex(e => e.PaperId)
                    .HasName("IX_FK_TendersPaperTendersAnnouncementPaper");

                entity.Property(e => e.AnnouncementCost).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.PublishFiristDate).HasColumnType("datetime");

                entity.Property(e => e.PublishSecondDate).HasColumnType("datetime");

                entity.HasOne(d => d.Announcement)
                    .WithMany(p => p.TendersAnnouncementPapers)
                    .HasForeignKey(d => d.AnnouncementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TendersAnnouncementTendersAnnouncementPaper");

                entity.HasOne(d => d.Paper)
                    .WithMany(p => p.TendersAnnouncementPapers)
                    .HasForeignKey(d => d.PaperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TendersPaperTendersAnnouncementPaper");
            });

            modelBuilder.Entity<TendersAnnouncements>(entity =>
            {
                entity.Property(e => e.AnnouncementNo)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.LastTenderTermsDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TendersPapers>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.NameSl)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.PostalCode).HasMaxLength(150);
            });

            modelBuilder.Entity<ViolationTypes>(entity =>
            {
                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.IconFileName).HasMaxLength(250);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<VisitCancellations>(entity =>
            {
                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitVisitCancellation");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitCancellations)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitCancellation");
            });

            modelBuilder.Entity<VisitCommitteeMembers>(entity =>
            {
                entity.HasIndex(e => e.CommitteeMemberId)
                    .HasName("IX_FK_CommitteeMemberVisitCommitteeMembers");

                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitVisitCommitteeMembers");

                entity.HasOne(d => d.CommitteeMember)
                    .WithMany(p => p.VisitCommitteeMembers)
                    .HasForeignKey(d => d.CommitteeMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommitteeMemberVisitCommitteeMembers");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitCommitteeMembers)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitCommitteeMembers");
            });

            modelBuilder.Entity<VisitDailies>(entity =>
            {
                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitVisitDaily");

                entity.Property(e => e.Temperature).HasMaxLength(150);

                entity.Property(e => e.Weather).HasMaxLength(150);

                entity.Property(e => e.Wind).HasMaxLength(150);

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitDailies)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitDaily");
            });

            modelBuilder.Entity<VisitDecisions>(entity =>
            {
                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameFl).IsRequired();

                entity.Property(e => e.NameSl).IsRequired();
            });

            modelBuilder.Entity<VisitFiles>(entity =>
            {
                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitVisitFile");

                entity.HasIndex(e => e.VisitInspectionWorkItemId)
                    .HasName("IX_FK_VisitInspectionWorkItemVisitFile");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ImageName).HasMaxLength(250);

                entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsVisible).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitFiles)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitFile");

                entity.HasOne(d => d.VisitInspectionWorkItem)
                    .WithMany(p => p.VisitFiles)
                    .HasForeignKey(d => d.VisitInspectionWorkItemId)
                    .HasConstraintName("FK_VisitInspectionWorkItemVisitFile");
            });

            modelBuilder.Entity<VisitFinialAcceptances>(entity =>
            {
                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitVisitFinialAcceptance");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitFinialAcceptances)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitFinialAcceptance");
            });

            modelBuilder.Entity<VisitInitialAcceptances>(entity =>
            {
                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitVisitInitialAcceptance");

                entity.Property(e => e.DecisionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitInitialAcceptances)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitInitialAcceptance");
            });

            modelBuilder.Entity<VisitInspectionWorkItems>(entity =>
            {
                entity.HasIndex(e => e.PaymentRequestId)
                    .HasName("IX_FK_PaymentRequestVisitInspectionWorkItem");

                entity.HasIndex(e => e.RequestWorkItemBoqinventoryId)
                    .HasName("IX_FK_RequestWorkItemBOQInventoryVisitInspectionWorkItem");

                entity.HasIndex(e => e.StudyBoqitemId)
                    .HasName("IX_FK_StudyBOQItemVisitInspectionWorkItem");

                entity.HasIndex(e => e.VisitInspectionId)
                    .HasName("IX_FK_VisitInspectionReportVisitInspectionWorkItem");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Height).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.Length).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(28, 4)");

                entity.Property(e => e.RequestWorkItemBoqinventoryId).HasColumnName("RequestWorkItemBOQInventoryId");

                entity.Property(e => e.StudyBoqitemId).HasColumnName("StudyBOQItemId");

                entity.Property(e => e.Width).HasColumnType("decimal(28, 4)");

                entity.HasOne(d => d.PaymentRequest)
                    .WithMany(p => p.VisitInspectionWorkItems)
                    .HasForeignKey(d => d.PaymentRequestId)
                    .HasConstraintName("FK_PaymentRequestVisitInspectionWorkItem");

                entity.HasOne(d => d.RequestWorkItemBoqinventory)
                    .WithMany(p => p.VisitInspectionWorkItems)
                    .HasForeignKey(d => d.RequestWorkItemBoqinventoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestWorkItemBOQInventoryVisitInspectionWorkItem");

                entity.HasOne(d => d.StudyBoqitem)
                    .WithMany(p => p.VisitInspectionWorkItems)
                    .HasForeignKey(d => d.StudyBoqitemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyBOQItemVisitInspectionWorkItem");

                entity.HasOne(d => d.VisitInspection)
                    .WithMany(p => p.VisitInspectionWorkItems)
                    .HasForeignKey(d => d.VisitInspectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitInspectionVisitInspectionWorkItem");
            });

            modelBuilder.Entity<VisitInspections>(entity =>
            {
                entity.HasIndex(e => e.RequestWorkItemsDeliveryId)
                    .HasName("IX_FK_RequestWorkItemsDeliveryVisitInspection");

                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitVisitInspection");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.HasOne(d => d.RequestWorkItemsDelivery)
                    .WithMany(p => p.VisitInspections)
                    .HasForeignKey(d => d.RequestWorkItemsDeliveryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestWorkItemsDeliveryVisitInspection");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitInspections)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitInspection");
            });

            modelBuilder.Entity<VisitMonthelyReport>(entity =>
            {
                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitMonthelyReport)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitMonthelyReport");
            });

            modelBuilder.Entity<VisitPeriodicals>(entity =>
            {
                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitVisitPeriodical");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.ProgressPercentagDuration).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.ProgressPercentagPayments).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.ProgressPercentagWorkItems).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitPeriodicals)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitPeriodical");
            });

            modelBuilder.Entity<VisitReportOfEquipments>(entity =>
            {
                entity.HasIndex(e => e.ProjectEquipmentId)
                    .HasName("IX_FK_ProjectEquipmentVisitReportOfEquipment");

                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitVisitReportOfEquipment");

                entity.HasOne(d => d.ProjectEquipment)
                    .WithMany(p => p.VisitReportOfEquipments)
                    .HasForeignKey(d => d.ProjectEquipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectEquipmentVisitReportOfEquipment");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitReportOfEquipments)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitReportOfEquipment");
            });

            modelBuilder.Entity<VisitReportOfMaterials>(entity =>
            {
                entity.HasIndex(e => e.ProjectMaterialId)
                    .HasName("IX_FK_ProjectMaterialVisitReportOfMaterial");

                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitVisitReportOfMaterial");

                entity.HasOne(d => d.ProjectMaterial)
                    .WithMany(p => p.VisitReportOfMaterials)
                    .HasForeignKey(d => d.ProjectMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectMaterialVisitReportOfMaterial");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitReportOfMaterials)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitReportOfMaterial");
            });

            modelBuilder.Entity<VisitReportOfTechnicalTeams>(entity =>
            {
                entity.HasIndex(e => e.PersonnelJobId)
                    .HasName("IX_FK_PersonnelJobVisitReportOfTechnicalTeam");

                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitVisitReportOfTechnicalTeam");

                entity.HasOne(d => d.PersonnelJob)
                    .WithMany(p => p.VisitReportOfTechnicalTeams)
                    .HasForeignKey(d => d.PersonnelJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonnelJobVisitReportOfTechnicalTeam");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitReportOfTechnicalTeams)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitReportOfTechnicalTeam");
            });

            modelBuilder.Entity<VisitReportOfWorkItems>(entity =>
            {
                entity.HasIndex(e => e.QualityId)
                    .HasName("IX_FK_WorkTypeQualityVisitReportOfWorkItem");

                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitVisitReportOfWorkItem");

                entity.HasIndex(e => e.WorkTypeId)
                    .HasName("IX_FK_WorkTypeVisitReportOfWorkItem");

                entity.Property(e => e.CompletePercentage).HasColumnType("decimal(28, 2)");

                entity.HasOne(d => d.Quality)
                    .WithMany(p => p.VisitReportOfWorkItems)
                    .HasForeignKey(d => d.QualityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkTypeQualityVisitReportOfWorkItem");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitReportOfWorkItems)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitReportOfWorkItem");

                entity.HasOne(d => d.WorkType)
                    .WithMany(p => p.VisitReportOfWorkItems)
                    .HasForeignKey(d => d.WorkTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkTypeVisitReportOfWorkItem");
            });

            modelBuilder.Entity<VisitSafetyPrecautionCheckLists>(entity =>
            {
                entity.HasIndex(e => e.VisitSafetyPrecautionId)
                    .HasName("IX_FK_VisitSafetyPrecautionVisitSafetyPrecautionCheckList");

                entity.HasIndex(e => e.VisitSafetyPrecautionRequirementId)
                    .HasName("IX_FK_VisitSafetyPrecautionRequirementVisitSafetyPrecautionCheckList");

                entity.Property(e => e.IsAvailable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.VisitSafetyPrecaution)
                    .WithMany(p => p.VisitSafetyPrecautionCheckLists)
                    .HasForeignKey(d => d.VisitSafetyPrecautionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitSafetyPrecautionVisitSafetyPrecautionCheckList");

                entity.HasOne(d => d.VisitSafetyPrecautionRequirement)
                    .WithMany(p => p.VisitSafetyPrecautionCheckLists)
                    .HasForeignKey(d => d.VisitSafetyPrecautionRequirementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitSafetyPrecautionRequirementVisitSafetyPrecautionCheckList");
            });

            modelBuilder.Entity<VisitSafetyPrecautionRequirements>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<VisitSafetyPrecautions>(entity =>
            {
                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitVisitSafetyPrecaution");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitSafetyPrecautions)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitSafetyPrecaution");
            });

            modelBuilder.Entity<VisitScheduledDelayReasons>(entity =>
            {
                entity.HasIndex(e => e.LookupDelayReasonId)
                    .HasName("IX_FK_LookupDelayReasonVisitScheduledDelayReason");

                entity.HasIndex(e => e.VisitScheduledId)
                    .HasName("IX_FK_VisitScheduledVisitScheduledDelayReason");

                entity.HasOne(d => d.LookupDelayReason)
                    .WithMany(p => p.VisitScheduledDelayReasons)
                    .HasForeignKey(d => d.LookupDelayReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LookupDelayReasonVisitScheduledDelayReason");

                entity.HasOne(d => d.VisitScheduled)
                    .WithMany(p => p.VisitScheduledDelayReasons)
                    .HasForeignKey(d => d.VisitScheduledId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitScheduledVisitScheduledDelayReason");
            });

            modelBuilder.Entity<VisitScheduleds>(entity =>
            {
                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitVisitScheduled");

                entity.Property(e => e.ProgressPercentagDuration).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.ProgressPercentagTimeplan).HasColumnType("decimal(28, 2)");

                entity.Property(e => e.ProgressPercentagWorkItems).HasColumnType("decimal(28, 2)");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitScheduleds)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitScheduled");
            });

            modelBuilder.Entity<VisitSiteTakingOvers>(entity =>
            {
                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitVisitSiteTakingOver");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitSiteTakingOvers)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitSiteTakingOver");
            });

            modelBuilder.Entity<VisitSuspensions>(entity =>
            {
                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitVisitSuspension");

                entity.Property(e => e.Recommendation).IsRequired();

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitSuspensions)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitSuspension");
            });

            modelBuilder.Entity<VisitUnplanneds>(entity =>
            {
                entity.HasIndex(e => e.VisitId)
                    .HasName("IX_FK_VisitVisitUnplanned");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.VisitUnplanneds)
                    .HasForeignKey(d => d.VisitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisitVisitUnplanned");
            });

            modelBuilder.Entity<Visits>(entity =>
            {
                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_ProjectVisit");

                entity.HasIndex(e => e.ProjectPersonnelId)
                    .HasName("IX_FK_ProjectPersonnelVisit");

                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Code).HasMaxLength(150);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.Property(e => e.UserImage).HasMaxLength(250);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Visits)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectVisit");

                entity.HasOne(d => d.ProjectPersonnel)
                    .WithMany(p => p.Visits)
                    .HasForeignKey(d => d.ProjectPersonnelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectPersonnelVisit");
            });

            modelBuilder.Entity<WorkTypeItemPhases>(entity =>
            {
                entity.HasIndex(e => e.WorkTypeId)
                    .HasName("IX_FK_WorkTypeWorkTypeItemPhase");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.HasOne(d => d.WorkType)
                    .WithMany(p => p.WorkTypeItemPhases)
                    .HasForeignKey(d => d.WorkTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkTypeWorkTypeItemPhase");
            });

            modelBuilder.Entity<WorkTypeItems>(entity =>
            {
                entity.HasIndex(e => e.LookupMeasureUnitId)
                    .HasName("IX_FK_LookupMeasureUnitWorkTypeItem");

                entity.HasIndex(e => e.WorkTypeId)
                    .HasName("IX_FK_WorkTypeWorkTypeItems");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.HasOne(d => d.LookupMeasureUnit)
                    .WithMany(p => p.WorkTypeItems)
                    .HasForeignKey(d => d.LookupMeasureUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LookupMeasureUnitWorkTypeItem");

                entity.HasOne(d => d.WorkType)
                    .WithMany(p => p.WorkTypeItems)
                    .HasForeignKey(d => d.WorkTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkTypeWorkTypeItems");
            });

            modelBuilder.Entity<WorkTypeQualities>(entity =>
            {
                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.IconFileName).HasMaxLength(250);

                entity.Property(e => e.NameFl).HasMaxLength(150);

                entity.Property(e => e.NameSl).HasMaxLength(150);
            });

            modelBuilder.Entity<WorkTypes>(entity =>
            {
                entity.HasIndex(e => e.ProjectSubTypeId)
                    .HasName("IX_FK_ProjectSubTypeWorkType");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.LastModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasMaxLength(150);

                entity.HasOne(d => d.ProjectSubType)
                    .WithMany(p => p.WorkTypes)
                    .HasForeignKey(d => d.ProjectSubTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectSubTypeWorkType");
            });
        }
    }
}
