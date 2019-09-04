using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class MwprojectBorrow
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public decimal? ProjectCost { get; set; }
        public decimal? BorrowPrice { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? ExchangeDate { get; set; }
        public decimal? PaidPrice { get; set; }
        public DateTime? PaidDate { get; set; }
        public string Notes { get; set; }
        public int? ProjectId { get; set; }
        public string Code { get; set; }
    }
}
