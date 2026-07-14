using NoviBet.Domain.Entities;

namespace NoviBet.Domain.Repositories
{
    public interface IMatchRepository
    {
        void AddMatch(Match match);
        Match? GetMatchById(Guid matchId);
        IEnumerable<Match> GetAllMatches();

    }
}
