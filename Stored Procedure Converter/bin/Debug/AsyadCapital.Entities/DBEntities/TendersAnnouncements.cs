using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class TendersAnnouncements
    {
        public TendersAnnouncements()
        {
            Tenders = new HashSet<Tenders>();
            TendersAnnouncementPapers = new HashSet<TendersAnnouncementPapers>();
        }

        public int Id { get; set; }
        public string AnnouncementNo { get; set; }
        public TimeSpan LastBidTime { get; set; }
        public TimeSpan SubmittingBidsTime { get; set; }
        public DateTime LastTenderTermsDate { get; set; }
        public string SubmittingBidsPlace { get; set; }
        public string TenderTermsPlace { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<Tenders> Tenders { get; set; }
        public virtual ICollection<TendersAnnouncementPapers> TendersAnnouncementPapers { get; set; }
    }
}
