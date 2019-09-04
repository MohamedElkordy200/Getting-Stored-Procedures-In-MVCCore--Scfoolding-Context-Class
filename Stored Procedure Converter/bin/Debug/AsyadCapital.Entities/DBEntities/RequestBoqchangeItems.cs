using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class RequestBoqchangeItems
    {
        public int Id { get; set; }
        public int StudyBoqitemId { get; set; }
        public int RequestBoqchangeId { get; set; }
        public decimal QuantityBefore { get; set; }
        public decimal QuantityAfter { get; set; }
        public bool IsNew { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Notes { get; set; }
        public bool? IsProcurementprocess { get; set; }
        public decimal? PriceBefore { get; set; }
        public decimal? PriceAfter { get; set; }

        public virtual RequestBoqchanges RequestBoqchange { get; set; }
        public virtual StudyBoqitems StudyBoqitem { get; set; }
    }
}
