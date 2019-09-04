using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class PaymentProjectConfiguration
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int PersonnelId { get; set; }
        public string ParentRoleCode { get; set; }
        public string RoleCode { get; set; }
        public string ParentRoleName { get; set; }
        public string RoleName { get; set; }
        public int OrderIndex { get; set; }
        public bool CanEditDiscount { get; set; }
        public bool CanEditViolations { get; set; }
        public bool CanPayment { get; set; }
        public bool? CanReply { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
