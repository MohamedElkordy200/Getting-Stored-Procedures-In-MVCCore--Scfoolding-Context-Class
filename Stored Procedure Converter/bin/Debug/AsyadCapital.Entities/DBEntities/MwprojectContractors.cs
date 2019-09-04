using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class MwprojectContractors
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int ContractorId { get; set; }
        public string Notes { get; set; }
    }
}
