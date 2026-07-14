using NoviBet.Domain.Enums;
using NoviBet.Domain.Exceptions;

namespace NoviBet.Domain.Entities
{
    public class Player : IPlayer
    {
        public Guid Id { get; }
        public string Name { get; private set; }
        public PlayersRole Role { get; }

        public Player(string name, PlayersRole role)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new InvalidPlayerNameException(name);

            Id = Guid.NewGuid();
            Name = name;
            Role = role;
        }

        public void Rename(string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
                throw new InvalidPlayerNameException(newName);

            if (this.Name == newName) return;

            Name = newName;
        }
    }
}
