using ModelSynk.DataAccess.Models.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.DataAccess.Sqlite.Models
{
    public class SQLiteTableDefinition : TableDefinition
    {
        public long CID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool NotNull { get; set; }
        public string dflt_value { get; set; }
        public bool PK { get; set; }
    }
}
