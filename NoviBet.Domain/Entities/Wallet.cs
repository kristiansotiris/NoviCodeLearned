using NoviBet.Domain.Exceptions;

namespace NoviBet.Domain.Entities
{
    public class Wallet : IWallet
    {
        public Guid Id { get; private set; }
        public decimal Balance { get; private set; }
        public bool IsBlocked { get; private set; }
        public Guid PlayerId { get; }

        public Wallet()
        {
            Id = Guid.NewGuid();
            Balance = 0m;
            IsBlocked = false;
        }

        public void Deposit(decimal amount)
        {
            ValiDateTransaction(amount);
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            ValiDateTransaction(amount);
            Balance -= amount;
        }

        private void ValiDateTransaction(decimal amount)
        {
            if (IsBlocked)
                throw new WalletBlockedException(Id);

            if (amount <= 0)
                throw new InvalidAmountException(amount);
        }
    }
}
