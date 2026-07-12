using NoviBet.Domain.Enums;

namespace NoviBet.Domain.Entities
{
    public class Match(string home, string away) // Primary Constructor
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string HomeTeam { get; private set; } = home;
        public string AwayTeam { get; private set; } = away;
        public MatchStatus MatchStatus { get; private set; } = MatchStatus.Scheduled;
        public MatchResult? MatchResult { get; private set; } = null;


        //Functions
        public void FinishGame(MatchResult result)
        {
            if (MatchResult == result) throw new InvalidOperationException("Match is already finished.");

            MatchResult = result;
            MatchStatus = MatchStatus.Finished;
        }

    }
}
