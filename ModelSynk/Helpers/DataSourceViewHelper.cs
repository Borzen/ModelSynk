using Avalonia.Controls;
using ModelSynk.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelSynk.Helpers
{
    internal class DataSourceViewHelper
    {
        public static string GetDataSourceLogo(DataSourceType dataSource)
        {
            switch (dataSource)
            {
                case DataSourceType.SQLite:
                    return "/Assets/DataSourceLogos/sqlite-icon.svg";
                default:
                    return "";
            }
        }

        public static IEnumerable<DataSourceType> GetDataSourceComboBoxItems()
        {
            return Enum.GetValues(typeof(DataSourceType)).Cast<DataSourceType>();
        }
    }
}
