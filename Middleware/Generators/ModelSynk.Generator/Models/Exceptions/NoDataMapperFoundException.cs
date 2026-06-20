using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSynk.Generator.Models.Exceptions
{
    public class NoDataMapperFoundException : Exception
    {
        public NoDataMapperFoundException() { }
        public NoDataMapperFoundException(string? message) : base(message)
        {
        }
    }
}
