using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Comments
    {
        public Comments()
        {
            CommentFiles = new HashSet<CommentFiles>();
            CommentVisits = new HashSet<CommentVisits>();
        }

        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string CommentType { get; set; }
        public DateTime Date { get; set; }
        public string Code { get; set; }
        public string CommentText { get; set; }
        public bool IsApproved { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? UserId { get; set; }

        public virtual Projects Project { get; set; }
        public virtual ICollection<CommentFiles> CommentFiles { get; set; }
        public virtual ICollection<CommentVisits> CommentVisits { get; set; }
    }
}
