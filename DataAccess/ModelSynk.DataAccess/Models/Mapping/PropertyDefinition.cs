using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.DataAccess.Models.Mapping
{
    public class PropertyDefinition
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public bool Nullable { get; set; }
        public string DefaultValue { get; set; }

        public bool IsPK { get; set; }
    }
}
