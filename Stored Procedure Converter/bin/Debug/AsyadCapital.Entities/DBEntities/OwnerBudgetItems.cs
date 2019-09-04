using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class OwnerBudgetItems
    {
        public OwnerBudgetItems()
        {
            OwnerBudgetProjects = new HashSet<OwnerBudgetProjects>();
        }

        public int Id { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string Code { get; set; }
        public decimal? ContractCost { get; set; }
        public string ComapctNameFl { get; set; }
        public string ComapctNameSl { get; set; }
        public string ComapctCode { get; set; }
        public decimal? CompactContractCost { get; set; }
        public int OwnerBudgetId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual OwnerBudgets OwnerBudget { get; set; }
        public virtual ICollection<OwnerBudgetProjects> OwnerBudgetProjects { get; set; }
    }
}
