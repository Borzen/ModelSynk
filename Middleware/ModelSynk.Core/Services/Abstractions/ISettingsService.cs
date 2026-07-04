using ModelSynk.DataAccess.Models.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.Core.Services.Abstractions
{
    public interface ISettingsService
    {
        List<DataSourceConnection> GetActiveConnections();
    }
}
