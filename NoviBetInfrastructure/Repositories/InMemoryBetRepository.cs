
using NoviBet.Domain.Entities;
using NoviBet.Domain.Repositories;

namespace NoviBetInfrastructure.Repositories
{
    public class InMemoryBetRepository : IBetRepository
    {
        private readonly List<Bet> _bets = new();
        public void AddBet(Bet bet) => _bets.Add(bet);

        public Bet? GetBetById(Guid betId) => _bets.FirstOrDefault(b => b.Id == betId);
    }
}
