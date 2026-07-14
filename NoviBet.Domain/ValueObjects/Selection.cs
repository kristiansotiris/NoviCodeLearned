using NoviBet.Domain.Enums;
using NoviBet.Domain.Exceptions;
namespace NoviBet.Domain.ValueObjects
{
    public record class Selection
    {
        public Guid MatchId { get; }
        public MatchResult MatchResult { get; }
        public Odds Odds { get; }


        public Selection(Guid matchId, MatchResult result, Odds odd)
        {

            if (matchId == Guid.Empty) throw new InvalidMatchIdException(matchId);

            MatchId = matchId;
            MatchResult = result;
            Odds = odd;
        }

        public bool IsWinning(MatchResult result) => MatchResult == result;
    }
}
