using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.DataAccess.Models.Mapping
{
    public class ObjectDefinition
    {
        public string Name { get; set; }

        public List<PropertyDefinition> PropertyDefinitions { get; set; } = new List<PropertyDefinition>();
    }
}
