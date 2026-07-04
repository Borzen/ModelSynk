using ModelSynk.DataAccess.Models.Settings;
using ModelSynk.DataAccess.Repositories.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.DataAccess.Sqlite.Repositories
{
    internal class DataSourceConnectionRepository : IDataSourceConnectionRepository
    {
        private readonly SqliteDbContext _dbContext;

        public DataSourceConnectionRepository(SqliteDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        List<DataSourceConnection> IDataSourceConnectionRepository.Get()
        {
            throw new NotImplementedException();
        }

        public DataSourceConnection Get(long id)
        {
            throw new NotImplementedException();
        }

        public long Create(DataSourceConnection connection)
        {
            throw new NotImplementedException();
        }

        public void Update(DataSourceConnection connection)
        {
            throw new NotImplementedException();
        }

        public void Delete(DataSourceConnection connection)
        {
            throw new NotImplementedException();
        }
    }
}
