using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class TenderBids
    {
        public TenderBids()
        {
            TenderBidBoqitems = new HashSet<TenderBidBoqitems>();
        }

        public int Id { get; set; }
        public int ContractorId { get; set; }
        public int TenderId { get; set; }
        public int AwardStatus { get; set; }
        public bool IsMatching { get; set; }
        public DateTime BidDate { get; set; }
        public decimal BidValue { get; set; }
        public string AssuranceNo { get; set; }
        public decimal? AssuranceValue { get; set; }
        public DateTime? AssuranceValidFrom { get; set; }
        public DateTime? AssuranceValidTo { get; set; }
        public string AssuranceBankName { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsAcceptedBid { get; set; }
        public bool IsAwarded { get; set; }
        public int? ProjectDocumentId { get; set; }

        public virtual Contractors Contractor { get; set; }
        public virtual Tenders Tender { get; set; }
        public virtual ICollection<TenderBidBoqitems> TenderBidBoqitems { get; set; }
    }
}
