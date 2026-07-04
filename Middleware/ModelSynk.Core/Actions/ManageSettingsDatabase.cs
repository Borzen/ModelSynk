using ModelSynk.Core.Actions.Abstractions;
using ModelSynk.DataAccess.DataServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.Core.Actions
{
    internal class ManageSettingsDatabase : IManageSettingsDatabase
    {
        private readonly IManagementDataService _managementDataService;

        public ManageSettingsDatabase(IManagementDataService managementDataService)
        {
            _managementDataService = managementDataService;
        }

        public void RunDatabaseManagementScripts()
        {
            _managementDataService.UpdateDb();
        }
    }
}
