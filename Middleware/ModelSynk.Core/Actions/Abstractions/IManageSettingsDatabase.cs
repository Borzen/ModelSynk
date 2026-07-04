using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.Core.Actions.Abstractions
{
    public interface IManageSettingsDatabase
    {
        void RunDatabaseManagementScripts();
    }
}
