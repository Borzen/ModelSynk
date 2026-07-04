using DbUp;
using ModelSynk.DataAccess.DataServices;
using ModelSynk.DataAccess.Helpers;
using ModelSynk.DataAccess.Sqlite.Exceptions;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ModelSynk.DataAccess.Sqlite.DataServices
{
    internal class ManagementDataService : IManagementDataService
    {
        public void UpdateDb()
        {
            if(!File.Exists(DataAccessStringConstants.SettingsDbLocation))
            {
                var settingsDirectory = Path.GetDirectoryName(DataAccessStringConstants.SettingsDbLocation);
                Directory.CreateDirectory(settingsDirectory);
                File.Create(DataAccessStringConstants.SettingsDbLocation);
            }

            var connectionString = "Data Source= " + DataAccessStringConstants.SettingsDbLocation;
            var upgrader = DeployChanges.To.SqliteDatabase(connectionString).WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly(), (assemblyPath) =>
            {
                if(assemblyPath.Contains("ModelSynk.DataAccess.Sqlite.SqlScripts.SettingsDbScripts"))
                {
                    return true;
                }
                return false;
            }).Build();

            var result = upgrader.PerformUpgrade();

            if(!result.Successful)
            {
                throw new SettingsDbException("Error Updating Settings Db", result.Error);
            }

            Console.WriteLine();
        }
    }
}
