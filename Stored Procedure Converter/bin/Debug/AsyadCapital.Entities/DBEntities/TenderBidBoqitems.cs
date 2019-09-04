using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class TenderBidBoqitems
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int TenderBidId { get; set; }
        public int StudyBoqitemId { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual StudyBoqitems StudyBoqitem { get; set; }
        public virtual TenderBids TenderBid { get; set; }
    }
}
