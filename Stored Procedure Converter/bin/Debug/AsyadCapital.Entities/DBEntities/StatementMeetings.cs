using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementMeetings
    {
        public StatementMeetings()
        {
            StatementMeetingAttendences = new HashSet<StatementMeetingAttendences>();
        }

        public int Id { get; set; }
        public int StatementId { get; set; }
        public string Topics { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public string Recommendations { get; set; }
        public string Title { get; set; }

        public virtual Statements Statement { get; set; }
        public virtual ICollection<StatementMeetingAttendences> StatementMeetingAttendences { get; set; }
    }
}
