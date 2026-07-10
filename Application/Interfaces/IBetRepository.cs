using NoviBet.Domain.Entities;
using NoviBet.Domain.Enums;

namespace Application.Interfaces
{
    public interface IBetRepository
    {
        void CreateBet(Bet bet);
        IReadOnlyList<Bet> GetPlayerBets(Guid playerId);
        IReadOnlyList<Bet> GetBetsByStatus(BetStatus betStatus);
        IReadOnlyList<Bet> GetAllBets();

    }
}
