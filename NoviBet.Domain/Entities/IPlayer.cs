using NoviBet.Domain.Enums;

namespace NoviBet.Domain.Entities
{
    public interface IPlayer
    {
        Guid Id { get; }
        string Name { get; }
        PlayersRole Role { get; }

    }
}
