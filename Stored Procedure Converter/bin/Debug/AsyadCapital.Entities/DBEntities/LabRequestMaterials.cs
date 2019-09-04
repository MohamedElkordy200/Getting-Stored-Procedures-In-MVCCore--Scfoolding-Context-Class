using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class LabRequestMaterials
    {
        public LabRequestMaterials()
        {
            LabRequestMaterialItems = new HashSet<LabRequestMaterialItems>();
        }

        public int Id { get; set; }
        public int LabRequestId { get; set; }
        public int LaboratoryId { get; set; }
        public DateTime TakeSampleDate { get; set; }
        public int DegreeOfImportance { get; set; }
        public bool? IsApproved { get; set; }
        public string Remarks { get; set; }

        public virtual LabRequests LabRequest { get; set; }
        public virtual Laboratories Laboratory { get; set; }
        public virtual ICollection<LabRequestMaterialItems> LabRequestMaterialItems { get; set; }
    }
}
