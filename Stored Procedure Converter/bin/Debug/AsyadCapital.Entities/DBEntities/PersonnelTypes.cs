using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class PersonnelTypes
    {
        public PersonnelTypes()
        {
            LookupDocumentCategories = new HashSet<LookupDocumentCategories>();
            LookupDocumentTypes = new HashSet<LookupDocumentTypes>();
            PersonnelJobs = new HashSet<PersonnelJobs>();
            Personnels = new HashSet<Personnels>();
        }

        public int Id { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public bool IsActive { get; set; }
        public string Color { get; set; }
        public string IconFileName { get; set; }

        public virtual ICollection<LookupDocumentCategories> LookupDocumentCategories { get; set; }
        public virtual ICollection<LookupDocumentTypes> LookupDocumentTypes { get; set; }
        public virtual ICollection<PersonnelJobs> PersonnelJobs { get; set; }
        public virtual ICollection<Personnels> Personnels { get; set; }
    }
}
