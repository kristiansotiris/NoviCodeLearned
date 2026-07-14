using NoviBet.Domain.Enums;
using NoviBet.Domain.Exceptions;

namespace NoviBet.Domain.Entities
{
    public class Match {
        public Guid Id { get; }
        public string HomeTeam { get; private set; }
        public string AwayTeam { get; private set; }
        public MatchStatus MatchStatus { get; private set; }
        public MatchResult? MatchResult { get; private set; }

        public Match(string homeTeam, string awayTeam)
        {
            if (string.IsNullOrWhiteSpace(homeTeam))
                throw new InvalidTeamNameException(homeTeam);

            if (string.IsNullOrWhiteSpace(awayTeam))
                throw new InvalidTeamNameException(awayTeam);

            //if (string.Equals(homeTeam, awayTeam, StringComparison.OrdinalIgnoreCase))


            Id = Guid.NewGuid();
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            MatchStatus =  MatchStatus.Scheduled;
            MatchResult = null;
        }

        //Functions
        public void FinishGame(MatchResult result)
        {
            if (MatchStatus == MatchStatus.Finished) throw new MatchAlreadyFinishedException(Id);

            MatchResult = result;
            MatchStatus = MatchStatus.Finished;
        }

    }
}
