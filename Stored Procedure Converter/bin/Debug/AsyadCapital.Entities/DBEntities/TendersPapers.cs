using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class TendersPapers
    {
        public TendersPapers()
        {
            TendersAnnouncementPapers = new HashSet<TendersAnnouncementPapers>();
        }

        public int Id { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string PostalCode { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<TendersAnnouncementPapers> TendersAnnouncementPapers { get; set; }
    }
}
