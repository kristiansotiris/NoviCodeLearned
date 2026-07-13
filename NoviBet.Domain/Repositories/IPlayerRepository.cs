
using NoviBet.Domain.Entities;

namespace NoviBet.Domain.Repositories
{
    public interface IPlayerRepository
    {
        Player? GetPlayerById(Guid playerId);
        void AddPlayer(Player player);
        void RemovePlayer(Guid playerId);
        IEnumerable<Player> GetAllPlayers();
        Player? GetPlayerByName(string name);

    }
}
