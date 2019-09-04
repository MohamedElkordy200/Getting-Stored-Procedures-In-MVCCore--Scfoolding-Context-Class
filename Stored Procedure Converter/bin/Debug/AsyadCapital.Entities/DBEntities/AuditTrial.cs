using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class AuditTrial
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int? ProjectId { get; set; }
        public int? PersonnelId { get; set; }
        public string AuditTrialCode { get; set; }
        public DateTime? Date { get; set; }
        public string Ipaddress { get; set; }
        public string MacAddress { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string PageUrl { get; set; }
        public int? ActivityTaskId { get; set; }
        public int? ReferenceId { get; set; }

        public virtual Personnels Personnel { get; set; }
        public virtual Projects Project { get; set; }
    }
}
