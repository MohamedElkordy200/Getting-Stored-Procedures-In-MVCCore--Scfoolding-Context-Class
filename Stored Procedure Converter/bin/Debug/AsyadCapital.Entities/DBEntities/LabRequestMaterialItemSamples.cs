using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class LabRequestMaterialItemSamples
    {
        public LabRequestMaterialItemSamples()
        {
            LabRequestMaterialItemTests = new HashSet<LabRequestMaterialItemTests>();
        }

        public int Id { get; set; }
        public int LabRequestMaterialItemId { get; set; }
        public string Barcode { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual LabRequestMaterialItems LabRequestMaterialItem { get; set; }
        public virtual ICollection<LabRequestMaterialItemTests> LabRequestMaterialItemTests { get; set; }
    }
}
