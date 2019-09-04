using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class MobilePushNotifications
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string DeviceId { get; set; }
        public int TypeId { get; set; }
        public bool? IsRegistered { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
