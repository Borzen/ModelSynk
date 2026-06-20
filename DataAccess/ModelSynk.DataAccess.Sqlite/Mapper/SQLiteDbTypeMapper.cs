using ModelSynk.DataAccess.Mappers;
using ModelSynk.DataAccess.Models.Mapping;
using ModelSynk.DataAccess.Sqlite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.DataAccess.Sqlite.Mapper
{
    public class SQLiteDbTypeMapper : DbTypeMapper<SQLiteTableDefinition>
    {
        private readonly string _dataProvider;
        public override string DataProvider
        {
            get { return _dataProvider; }
        }

        public SQLiteDbTypeMapper()
        {
            _dataProvider = "SQLite";
        }

        public override ObjectDefinition MapTableToObject(string tableName, List<SQLiteTableDefinition> tableColumns)
        {
            List<PropertyDefinition> propertyDefinitions = new List<PropertyDefinition>();

            foreach (var tableColumn in tableColumns)
            {
                propertyDefinitions.Add(new PropertyDefinition()
                {
                    Name = tableColumn.Name,
                    Type = tableColumn.Type,
                    Nullable = tableColumn.NotNull,
                    DefaultValue = tableColumn.dflt_value,
                    IsPK = tableColumn.PK,
                });
            }

            return new ObjectDefinition()
            {
                Name = tableName,
                PropertyDefinitions = propertyDefinitions
            };
        }
    }
}
