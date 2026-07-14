using NoviBet.Domain.Exceptions;

namespace NoviBet.Domain.Entities
{
    public class Wallet : IWallet
    {
        public Guid Id { get; }
        public decimal Balance { get; private set; }
        public bool IsBlocked { get; private set; }
        public Guid PlayerId { get; }

        public Wallet(Guid playerId)
        {
            if(playerId == Guid.Empty)
                throw new ArgumentException("Player ID cannot be empty.", nameof(playerId));

            Id = Guid.NewGuid();
            Balance = 0m;
            IsBlocked = false;
            PlayerId = playerId;
        }

        public void Deposit(decimal amount)
        {
            ValiDateTransaction(amount);
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            ValiDateTransaction(amount); 
            if(amount > Balance)
                throw new InsufficientFundsException(amount, Balance);
            Balance -= amount;
        }

        public void BlockWallet()
        {
            if(IsBlocked)
                throw new WalletAlreadyBlockedException(Id);
            IsBlocked = true;
        }

        public void UnblockWallet()
        {
            if (!IsBlocked)
                throw new WalletNotBlockedException(Id);
            IsBlocked = false;
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
