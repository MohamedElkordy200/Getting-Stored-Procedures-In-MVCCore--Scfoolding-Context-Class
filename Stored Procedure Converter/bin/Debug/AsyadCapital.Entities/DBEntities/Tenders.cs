using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Tenders
    {
        public Tenders()
        {
            TenderBids = new HashSet<TenderBids>();
        }

        public int Id { get; set; }
        public int AnnouncementId { get; set; }
        public int ProjectId { get; set; }
        public string TenderNumber { get; set; }
        public decimal ValueDocumentes { get; set; }
        public DateTime SubmittingBidsDate { get; set; }
        public DateTime LastBidDate { get; set; }
        public string Terms { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual TendersAnnouncements Announcement { get; set; }
        public virtual Projects Project { get; set; }
        public virtual ICollection<TenderBids> TenderBids { get; set; }
    }
}
