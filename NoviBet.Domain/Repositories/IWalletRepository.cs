    using NoviBet.Domain.Entities;

    namespace NoviBet.Domain.Repositories
    {
        public interface IWalletRepository
        {
            Wallet? GetWalletById(Guid walletId);
            IEnumerable<Wallet> GetWallets();
            void AddWallet(Wallet wallet);
        }
    }
