using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Brands
    {
        public Brands()
        {
            Equipments = new HashSet<Equipments>();
            Models = new HashSet<Models>();
        }

        public int Id { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<Equipments> Equipments { get; set; }
        public virtual ICollection<Models> Models { get; set; }
    }
}
