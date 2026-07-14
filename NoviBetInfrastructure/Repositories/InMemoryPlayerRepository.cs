using NoviBet.Domain.Entities;
using NoviBet.Domain.Exceptions;
using NoviBet.Domain.Repositories;

namespace NoviBetInfrastructure.Repositories
{
    public class InMemoryPlayerRepository : IPlayerRepository
    {
        private readonly List<Player> _players = new();
        public void AddPlayer(Player player) => _players.Add(player);

        public IEnumerable<Player> GetAllPlayers() => _players.AsReadOnly();

        public Player? GetPlayerById(Guid playerId) => _players.FirstOrDefault(p => p.Id == playerId);

        public Player? GetPlayerByName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new InvalidPlayerNameException(name);

            return _players.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        }

        public void RemovePlayer(Guid playerId)
        {
            if(playerId == Guid.Empty)
                throw new PlayerIsNotFoundException(playerId);

             var player = _players.FirstOrDefault(p => p.Id == playerId);

            if (player != null)
            {
                _players.Remove(player);
            }
        }
    }
}
