using NoviBet.Domain.Entities;

namespace NoviBet.Domain.Repositories
{
    public interface IBetRepository
    {
        void AddBet(Bet bet);
        Bet? GetBetById(Guid betId);
    }
}
