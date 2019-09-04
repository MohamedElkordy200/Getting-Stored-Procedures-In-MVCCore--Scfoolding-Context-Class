using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class MwprojectIronCement
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public decimal? ProjectCost { get; set; }
        public decimal? IronQuantity { get; set; }
        public decimal? CementQuantity { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? ExchangeDate { get; set; }
        public decimal? AppropriatedPrice { get; set; }
        public decimal? Discount { get; set; }
        public string Notes { get; set; }
        public int? ProjectId { get; set; }
        public string Code { get; set; }
    }
}
