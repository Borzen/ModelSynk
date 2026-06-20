using ModelSynk.Generator.Actions.Abstractions;
using ModelSynk.Generator.Mappers;
using ModelSynk.Generator.Models;
using ModelSynk.Generator.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.Generator.Actions
{
    public abstract class CreateModel<T> : ICreateModel<T>
    {
        public virtual string Language { 
            get
            {
                return string.Empty;
            }
        }

        public abstract List<LanguageMapper<T>> Mappers { get; }

        public virtual ModelDefinition GenerateModelDefinitonFromDataMapper(DataSourceObject dataSourceObject, string dataSource)
        {
            var mapper = Mappers.Where(x => x.DataSource == dataSource && x.Language == Language).FirstOrDefault();
            if(mapper is null)
            {
                throw new NoDataMapperFoundException($"No data mapper found that uses {dataSource} for {Language}");
            }
            return mapper.MapDataSourceToLanguage(dataSourceObject);
        }

        public abstract T GenerateLanguageModelFromlBase(ModelDefinition model, ModelDefinitionExtensions extendedData);

        public abstract void GenerateModelForLanguage(T modelDefiniton, string exportPath);
    }
}
