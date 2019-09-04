using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class CommentFiles
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public int VisitFileId { get; set; }

        public virtual Comments Comment { get; set; }
        public virtual VisitFiles VisitFile { get; set; }
    }
}
