using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class StatementDailies
    {
        public int Id { get; set; }
        public int StatementId { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Weather { get; set; }
        public string Obstacles { get; set; }

        public virtual Statements Statement { get; set; }
    }
}
