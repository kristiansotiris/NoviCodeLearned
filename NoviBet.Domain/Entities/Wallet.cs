namespace NoviBet.Domain.Entities
{
    public class Wallet : IWallet
    {
        public Guid Id { get; private set; }
        public decimal Balance { get; private set; }
        public bool IsBlocked { get; private set; }


        public Wallet()
        {
            Id = Guid.NewGuid();
            Balance = 0m;
            IsBlocked = false;
        }
    }
}
