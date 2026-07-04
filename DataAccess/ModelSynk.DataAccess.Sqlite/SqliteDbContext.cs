using Dapper;
using Microsoft.Data.Sqlite;
using ModelSynk.DataAccess.Helpers;
using ModelSynk.DataAccess.Sqlite.DataServices;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace ModelSynk.DataAccess.Sqlite
{
    internal class SqliteDbContext : DbContext
    {
        private readonly SqliteConnection _connection;

        public SqliteDbContext()
        {
            try
            {
                _connection = new SqliteConnection("Data Source= " + DataAccessStringConstants.SettingsDbLocation);
                _connection.Open();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public SqliteDbContext(string dbFolderLocation)
        {

        }

        public override void Dispose()
        {
            _connection.Close();
            _connection.Dispose();
        }

        public IEnumerable<T> RunQery<T>(string sql, object? queryParams = null, DbTransaction? transaction = null)
        {
            if (transaction is null)
            {
                transaction = _connection.BeginTransaction();
            }
            using (transaction)
            {
                try
                {
                    IEnumerable<T> results = null;
                    if (queryParams != null)
                    {
                        results = _connection.Query<T>(sql, queryParams, transaction: transaction);
                    }
                    else
                    {
                        results = _connection.Query<T>(sql, transaction: transaction);
                    }
                    transaction.Commit();
                    return results;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void RunScript(string sql, object? queryParams = null, DbTransaction? transaction = null)
        {
            if (transaction is null)
            {
                transaction = _connection.BeginTransaction();
            }
            using (transaction)
            {
                try
                {
                    if (queryParams != null)
                    {
                        _connection.Execute(sql, queryParams, transaction: transaction);
                    }
                    else
                    {
                        _connection.Execute(sql, transaction: transaction);
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
