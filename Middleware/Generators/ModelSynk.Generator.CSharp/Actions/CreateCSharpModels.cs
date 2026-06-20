using ModelSynk.Core.Helpers;
using ModelSynk.Generator.Actions;
using ModelSynk.Generator.Actions.Abstractions;
using ModelSynk.Generator.CSharp.Mappers;
using ModelSynk.Generator.CSharp.Models;
using ModelSynk.Generator.CSharp.Templates;
using ModelSynk.Generator.Mappers;
using ModelSynk.Generator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.Core.Actions
{
    public class CreateCSharpModels : CreateModel<CSharpModelDefinition>
    {
        private readonly string _language;

        private readonly List<LanguageMapper<CSharpModelDefinition>> _mappers;

        public override string Language
        {
            get { return _language; }
        }

        public override List<LanguageMapper<CSharpModelDefinition>> Mappers {
            get { return _mappers; }
        }

        public CreateCSharpModels()
        {
            _mappers = new List<LanguageMapper<CSharpModelDefinition>>()
            {
                new SqliteMapper()
            };
            _language = StringValues.Languages.CSharp;
        }

        public override CSharpModelDefinition GenerateLanguageModelFromlBase(ModelDefinition model, ModelDefinitionExtensions extendedData)
        {
            var cSharpModel = model as CSharpModelDefinition;
            if (string.IsNullOrEmpty(extendedData.Namespace))
            {
                cSharpModel.Namespace = "YOU DIDNT DEFINE A NAMESPACE";
            }
            else
            {
                cSharpModel.Namespace = extendedData.Namespace;
            }
            return cSharpModel;
        }

        public override void GenerateModelForLanguage(CSharpModelDefinition modelDefiniton, string exportPath)
        {
            POCOTemplate template = new POCOTemplate(modelDefiniton);
            string modelFile = template.TransformText();
            string modelFilePath = Path.Combine(exportPath, modelDefiniton.Name + ".cs");
            File.WriteAllText(modelFilePath, modelFile);
        }


    }
}
