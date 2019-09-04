using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementTenderBidsSigningContracts
    {
        public int Id { get; set; }
        public int StatementId { get; set; }
        public string FinalAssuranceNo { get; set; }
        public decimal? FinalAssuranceValue { get; set; }
        public DateTime? FinalAssuranceValidFrom { get; set; }
        public DateTime? FinalAssuranceValidTo { get; set; }
        public string FinalAssuranceBankName { get; set; }

        public virtual Statements Statement { get; set; }
    }
}
