using ModelSynk.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.DataAccess.Models.Settings
{
    public class DataSourceConnection
    {
        public long DataSourceConnectionId { get; set; }
        public string Name { get; set; }
        public string ConnectionString { get; set; }
        public DataSourceType Type { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; } = DateTime.Now;
    }
}
