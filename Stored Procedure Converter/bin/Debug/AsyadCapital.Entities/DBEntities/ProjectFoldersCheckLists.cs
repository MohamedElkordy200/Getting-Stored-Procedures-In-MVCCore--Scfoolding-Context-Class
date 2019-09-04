using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class ProjectFoldersCheckLists
    {
        public ProjectFoldersCheckLists()
        {
            InverseParent = new HashSet<ProjectFoldersCheckLists>();
        }

        public int Id { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public int? ParentId { get; set; }
        public string ReferenceId { get; set; }
        public string ReferenceType { get; set; }

        public virtual ProjectFoldersCheckLists Parent { get; set; }
        public virtual ICollection<ProjectFoldersCheckLists> InverseParent { get; set; }
    }
}
