using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class MwprojectExecutiveConsultants
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int ExecutiveConsultantId { get; set; }
        public string Notes { get; set; }
    }
}
