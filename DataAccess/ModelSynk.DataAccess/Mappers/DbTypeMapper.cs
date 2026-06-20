using ModelSynk.DataAccess.Models.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.DataAccess.Mappers
{
    public abstract class DbTypeMapper<T>
    {
        public abstract string DataProvider { get; }

        public abstract ObjectDefinition MapTableToObject(string tableName, List<T> tableColumns);
    }
}
