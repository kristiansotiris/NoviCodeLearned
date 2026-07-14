using NoviBet.Domain.Entities;
using NoviBet.Domain.Repositories;

namespace NoviBetInfrastructure.Repositories
{
    public class InMemoryMatchRepository : IMatchRepository
    {
        private readonly List<Match> _matchList = new();
        public void AddMatch(Match match) => _matchList.Add(match);
        public Match? GetMatchById(Guid matchId) => _matchList.FirstOrDefault(m => m.Id == matchId);
        public IEnumerable<Match> GetAllMatches() => _matchList.AsReadOnly();
    }
}
