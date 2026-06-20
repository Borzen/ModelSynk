using ModelSynk.Core.Helpers;
using ModelSynk.Generator.CSharp.Models;
using ModelSynk.Generator.Mappers;
using ModelSynk.Generator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.Generator.CSharp.Mappers
{
    public class SqliteMapper : LanguageMapper<CSharpModelDefinition>
    {
        private readonly string _language;
        private readonly string _databaseType;
        public override string Language
        {
            get { return _language; }
        }

        public override string DataSource
        {
            get { return _databaseType; }
        }

        public SqliteMapper()
        {
            _language = StringValues.Languages.CSharp;
            _databaseType = StringValues.DataSources.SQLite;
        }

        public override VariableDefinition MapDataSourcePropertyToLanguage(string name, string type, bool isNull)
        {
            string cSharpType = "object";
            switch (type.ToUpperInvariant())
            {
                case StringValues.SQLiteDataTypes.INTEGER:
                    cSharpType = typeof(long).Name;
                    break;
                case StringValues.SQLiteDataTypes.REAL:
                    cSharpType = typeof(double).Name;
                    break;
                case StringValues.SQLiteDataTypes.TEXT:
                    cSharpType = typeof(string).Name;
                    break;
                case StringValues.SQLiteDataTypes.BLOB:
                    cSharpType = typeof(byte[]).Name;
                    break;
                default:
                    cSharpType = typeof(object).Name;
                    break;
            }

            return new VariableDefinition
            {
                Name = name,
                Type = cSharpType,
                IsNull = isNull
            };
        }
    }
}
