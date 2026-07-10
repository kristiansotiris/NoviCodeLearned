using System.Text.RegularExpressions;

namespace Application.Interfaces
{
    public interface IMatchRepository
    {
        void AddMatch(Match match);
        Match? GetMatchById(Guid Id);
        IReadOnlyList<Match> GetAllMatches();

    }
}
