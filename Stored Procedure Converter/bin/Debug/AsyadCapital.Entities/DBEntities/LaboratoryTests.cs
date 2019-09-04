using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class LaboratoryTests
    {
        public LaboratoryTests()
        {
            LabRequestMaterialItemTests = new HashSet<LabRequestMaterialItemTests>();
            LabRequestWorkItemTests = new HashSet<LabRequestWorkItemTests>();
        }

        public int Id { get; set; }
        public int LaboratoryTestTypeId { get; set; }
        public int WorkTypeId { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string ScientificName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual LaboratoryTestTypes LaboratoryTestType { get; set; }
        public virtual WorkTypes WorkType { get; set; }
        public virtual ICollection<LabRequestMaterialItemTests> LabRequestMaterialItemTests { get; set; }
        public virtual ICollection<LabRequestWorkItemTests> LabRequestWorkItemTests { get; set; }
    }
}
