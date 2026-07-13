using NoviBet.Domain.Entities;
using NoviBet.Domain.Exceptions;
using NoviBet.Domain.Repositories;

namespace NoviBetInfrastructure.Repositories
{
    public class InMemoryWalletRepository : IWalletRepository
    {
        private readonly List<Wallet> _wallets = new();
        public void AddWallet(Wallet wallet)
        {
           var existingWallet = _wallets.FirstOrDefault(w => w.Id == wallet.Id);
            if (existingWallet != null)
            {
                throw new WalletAlreadyExistsException(existingWallet.Id);
            }
            _wallets.Add(wallet);
        }

        public Wallet? GetWalletById(Guid walletId) => _wallets.FirstOrDefault(w => w.Id == walletId);

        public IEnumerable<Wallet> GetWallets() => _wallets.AsReadOnly();
    }
}