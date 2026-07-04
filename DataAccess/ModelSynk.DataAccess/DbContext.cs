using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.DataAccess
{
    public abstract class DbContext : IDisposable
    {
        public abstract void Dispose();
    }
}
