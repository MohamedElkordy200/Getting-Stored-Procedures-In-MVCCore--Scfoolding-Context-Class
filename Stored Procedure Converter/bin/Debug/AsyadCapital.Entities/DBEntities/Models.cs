﻿using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Models
    {
        public Models()
        {
            Equipments = new HashSet<Equipments>();
        }

        public int Id { get; set; }
        public int BrandId { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Brands Brand { get; set; }
        public virtual ICollection<Equipments> Equipments { get; set; }
    }
}
