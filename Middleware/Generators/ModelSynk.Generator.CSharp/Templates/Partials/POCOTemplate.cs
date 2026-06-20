using ModelSynk.Generator.CSharp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.Generator.CSharp.Templates
{
    public partial class POCOTemplate
    {
        public CSharpModelDefinition _modelDefiniton;
        public POCOTemplate(CSharpModelDefinition modelDefiniton)
        {
            _modelDefiniton = modelDefiniton;
        }
    }
}
