using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementMeetingAttendences
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Resource { get; set; }
        public int StatementMeetingId { get; set; }

        public virtual StatementMeetings StatementMeeting { get; set; }
    }
}
