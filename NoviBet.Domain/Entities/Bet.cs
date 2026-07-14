using NoviBet.Domain.Enums;
using NoviBet.Domain.ValueObjects;
using NoviBet.Domain.Exceptions;

namespace NoviBet.Domain.Entities
{
    public class Bet
    {
        private readonly List<Selection> _selections = new List<Selection>();
        public IReadOnlyList<Selection> Selections => _selections;
        public Guid Id { get; }
        public Guid PlayerId { get; }
        public decimal Stake { get; }
        public BetStatus BetStatus { get; private set; }
        public decimal PotentialWinnings => Stake * TotalOdds();

        public Bet(Guid playerid, decimal stake, IReadOnlyList<Selection> selections)
        {
            if (selections is null || selections.Count == 0)
                throw new InvalidSelectionsException();

            if (stake <= 0)
                throw new InvalidStakeException(stake);

            Id = Guid.NewGuid();
            PlayerId = playerid;
            Stake = stake;
            BetStatus = BetStatus.Pending;
            _selections = [.. selections];
        }


        public decimal TotalOdds()
        {
            decimal total = 1m;

            foreach (var selections in _selections)
            {
                total *= selections.Odds.Value;
            }

            return total;
        }

        public void Settle(IReadOnlyDictionary<Guid, MatchResult> results)
        {
            if (BetStatus != BetStatus.Pending)
                throw new BetAlreadySettledException(Id);

            bool allMatchesHaveResults = _selections.All(s => results.ContainsKey(s.MatchId));


            if (!allMatchesHaveResults)
                throw new CannotSettleBetException(Id);

            bool allWon = _selections.All(s => results[s.MatchId] == s.MatchResult);

            BetStatus = allWon ? BetStatus.Won : BetStatus.Lost;

        }

    }
}
