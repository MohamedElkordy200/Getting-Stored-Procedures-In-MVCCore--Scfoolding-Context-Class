using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectDepartmentWorkTypes
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? DepartmentId { get; set; }
        public int? WorkTypeId { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public decimal? FinancialRelationshipCost { get; set; }
        public decimal? TotalPaidAmount { get; set; }
        public decimal? ProjectsChildBudget { get; set; }
        public decimal? Remaining { get; set; }
        public decimal? ContractPercentage { get; set; }
        public decimal? StudyCost { get; set; }
        public decimal? FinancialProgress { get; set; }
    }
}
