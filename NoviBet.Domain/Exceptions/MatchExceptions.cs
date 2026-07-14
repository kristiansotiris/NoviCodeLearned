using System;
using System.Collections.Generic;
using System.Text;

namespace NoviBet.Domain.Exceptions
{
    public abstract class MatchExceptions : Exception
    {
        public abstract string ErrorCode { get; }

        public MatchExceptions(string message) : base(message) { }
        public MatchExceptions(string message,  Exception innerException) : base(message, innerException) { }
    }
}
