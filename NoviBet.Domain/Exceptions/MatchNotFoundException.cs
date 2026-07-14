using System;
using System.Collections.Generic;
using System.Text;

namespace NoviBet.Domain.Exceptions
{
    public sealed class MatchNotFoundException : MatchExceptions
    {
        public override string ErrorCode => "MATCH_NOT_FOUND";

        public MatchNotFoundException(string message) : base(message) { }
        public MatchNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
        
    }
}
