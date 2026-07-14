using System;
using System.Collections.Generic;
using System.Text;

namespace NoviBet.Domain.Exceptions
{
    public sealed class MatchNotFoundException : MatchExceptions
    {
        public override string ErrorCode => "MATCH_NOT_FOUND";

        public Guid Id { get; }
        public MatchNotFoundException(string message) : base(message) { }
        public MatchNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public MatchNotFoundException(Guid id) : base($"Match with id: {id} is not found.")
        {
            Id = id;
        }
        
    }
}
