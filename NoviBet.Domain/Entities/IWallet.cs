namespace NoviBet.Domain.Entities
{
    public interface IWallet
    {
        Guid Id { get; }
        decimal Balance { get; }
        bool IsBlocked { get; }
        Guid PlayerId { get; }

        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        void BlockWallet();
        void UnblockWallet();

    }
}
