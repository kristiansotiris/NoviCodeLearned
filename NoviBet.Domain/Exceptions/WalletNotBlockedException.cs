using System;
using System.Collections.Generic;
using System.Text;

namespace NoviBet.Domain.Exceptions
{
    public sealed class WalletNotBlockedException : WalletExceptions
    {
        public override string ErrorCode => "WALLET_NOT_BLOCKED";
        public WalletNotBlockedException(Guid walletId)
            : base($"Wallet with ID {walletId} is not blocked.")
        {
        }
    }
}
