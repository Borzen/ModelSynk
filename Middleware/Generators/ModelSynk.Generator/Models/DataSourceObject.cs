using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.Generator.Models
{
    public class DataSourceObject
    {
        public string Name { get; set; }

        public List<DataSourceProperty> Properties { get; set; }

        public DataSourceObject(string name, List<dynamic> properties)
        {
            Name = name;
            Properties = properties.Cast<DataSourceProperty>().ToList();
        }
    }
}
