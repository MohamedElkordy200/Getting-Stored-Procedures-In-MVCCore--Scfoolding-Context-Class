using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectGroups
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string NameFl { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public bool? IsActive { get; set; }
        public int? ParentId { get; set; }
        public decimal? ProjectValue { get; set; }
        public int? IScopeProjectId { get; set; }
    }
}
