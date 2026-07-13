using System;
using System.Collections.Generic;
using System.Text;

namespace NoviBet.Domain.Exceptions
{
    public sealed class InvalidTeamNameException : MatchExceptions
    {
        public override string ErrorCode => "INVALID_TEAM_NAME";
        public string Name { get; }
        public InvalidTeamNameException(string name) : base($"Invalid input: {name} Team Name")
        {
            Name = name;
        }

    }
}
