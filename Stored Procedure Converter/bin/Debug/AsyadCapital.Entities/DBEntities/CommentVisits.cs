using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class CommentVisits
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public int VisitId { get; set; }

        public virtual Comments Comment { get; set; }
        public virtual Visits Visit { get; set; }
    }
}
