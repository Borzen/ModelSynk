using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.Generator.Models
{
    public class ModelDefinition
    {
        public string Name { get; set; }

        public List<VariableDefinition> VariableDefinitions { get; set; }
    }
}
