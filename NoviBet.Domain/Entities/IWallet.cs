namespace NoviBet.Domain.Entities
{
    public interface IWallet
    {
        Guid Id { get; }
        decimal Balance { get; }
        bool IsBlocked { get; }

    }
}
