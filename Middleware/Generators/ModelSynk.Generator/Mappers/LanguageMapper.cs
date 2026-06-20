using ModelSynk.Generator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.Generator.Mappers
{
    public abstract class LanguageMapper<T>
    {
        public abstract string Language {  get; }
        public abstract string DataSource { get; }

        public virtual ModelDefinition MapDataSourceToLanguage(DataSourceObject dataSourceObject)
        {
            List<VariableDefinition> variableDefinitions = new List<VariableDefinition>();
            foreach (var property in dataSourceObject.Properties)
            {
                variableDefinitions.Add(MapDataSourcePropertyToLanguage(property.Name, property.Type, property.Nullable));
            }

            return new ModelDefinition
            {
                Name = dataSourceObject.Name,
                VariableDefinitions = variableDefinitions,
            };
        }

        public abstract VariableDefinition MapDataSourcePropertyToLanguage(string name, string type, bool isNull);
    }
}
