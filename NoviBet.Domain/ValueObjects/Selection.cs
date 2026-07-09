using NoviBet.Domain.Enums;
using NoviBet.Domain.Exceptions;
namespace NoviBet.Domain.ValueObjects
{
    public record class Selection
    {
        public Guid MatchId { get; }
        public MatchResult MatchResult { get; }
        public Odds Odds { get; }



        public Selection(Guid id, MatchResult result, Odds odd)
        {
            if (id == Guid.Empty) throw new InvalidMatchIdException(id);

            MatchResult = result;
            Odds = odd;
        }
    }
}
