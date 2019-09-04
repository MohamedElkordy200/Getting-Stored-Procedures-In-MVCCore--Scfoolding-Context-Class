using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class LabRequestMaterialItemTests
    {
        public int Id { get; set; }
        public int LabRequestMaterialItemSampleId { get; set; }
        public bool TestResult { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public int LaboratoryTestId { get; set; }

        public virtual LabRequestMaterialItemSamples LabRequestMaterialItemSample { get; set; }
        public virtual LaboratoryTests LaboratoryTest { get; set; }
    }
}
