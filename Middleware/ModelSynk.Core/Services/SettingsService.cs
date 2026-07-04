using ModelSynk.Core.Services.Abstractions;
using ModelSynk.DataAccess.Models.Settings;
using ModelSynk.DataAccess.Repositories.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.Core.Services
{
    internal class SettingsService : ISettingsService
    {
        private readonly IDataSourceConnectionRepository _dataSourceConnectionRepository;

        public List<DataSourceConnection> GetActiveConnections()
        {
            throw new NotImplementedException();
        }
    }
}
