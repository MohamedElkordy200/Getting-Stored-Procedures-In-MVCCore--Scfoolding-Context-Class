using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class TendersAnnouncementPapers
    {
        public int Id { get; set; }
        public int AnnouncementId { get; set; }
        public int PaperId { get; set; }
        public DateTime PublishFiristDate { get; set; }
        public DateTime PublishSecondDate { get; set; }
        public decimal AnnouncementCost { get; set; }

        public virtual TendersAnnouncements Announcement { get; set; }
        public virtual TendersPapers Paper { get; set; }
    }
}
