using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace ModelSynk.DataAccess.Sqlite.Exceptions
{
    public class SettingsDbException : DbException
    {
        public SettingsDbException(string message) : base(message) { }

        public SettingsDbException(string message, Exception ex) : base(message, ex) { }
    }
}
