using ModelSynk.DataAccess.Models.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.DataAccess.Repositories.Settings
{
    public interface IDataSourceConnectionRepository
    {
        List<DataSourceConnection> Get();
        DataSourceConnection Get(long id);
        long Create(DataSourceConnection connection);
        void Update(DataSourceConnection connection);
        void Delete(DataSourceConnection connection);
    }
}
