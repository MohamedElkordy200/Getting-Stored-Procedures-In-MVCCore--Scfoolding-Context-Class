using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class OwnerBudgets
    {
        public OwnerBudgets()
        {
            OwnerBudgetItems = new HashSet<OwnerBudgetItems>();
        }

        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string Year { get; set; }
        public int? BudgetYear { get; set; }
        public decimal? FirstSectionValue { get; set; }
        public decimal? SecondSectionValue { get; set; }
        public decimal? ThirdSectionValue { get; set; }
        public decimal? ThirdSectionDirectRevenues { get; set; }
        public decimal? FourthSectionValue { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Owners Owner { get; set; }
        public virtual ICollection<OwnerBudgetItems> OwnerBudgetItems { get; set; }
    }
}
