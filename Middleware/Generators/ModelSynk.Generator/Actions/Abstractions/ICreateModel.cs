using ModelSynk.Generator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.Generator.Actions.Abstractions
{
    public interface ICreateModel<T>
    {
        string Language { get; }

        public T GenerateLanguageModelFromlBase(ModelDefinition model, ModelDefinitionExtensions extendedData);

        public void GenerateModelForLanguage(T modelDefiniton, string exportPath);
    }
}
