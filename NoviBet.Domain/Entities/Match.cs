using NoviBet.Domain.Enums;

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
            Id = Guid.NewGuid();
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            MatchStatus =  MatchStatus.Scheduled;
            MatchResult = null;
        }

        //Functions
        public void FinishGame(MatchResult result)
        {
            if (MatchResult == result) throw new InvalidOperationException("Match is already finished.");

            MatchResult = result;
            MatchStatus = MatchStatus.Finished;
        }

    }
}
