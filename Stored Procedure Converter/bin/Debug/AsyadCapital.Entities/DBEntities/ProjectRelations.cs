using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectRelations
    {
        public int Id { get; set; }
        public int MainProjectId { get; set; }
        public int RelatedProjectId { get; set; }
    }
}
