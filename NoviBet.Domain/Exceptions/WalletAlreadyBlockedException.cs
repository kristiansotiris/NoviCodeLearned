using System;
using System.Collections.Generic;
using System.Text;

namespace NoviBet.Domain.Exceptions
{
    public sealed class WalletAlreadyBlockedException : WalletExceptions
    {
        public override string ErrorCode => "WALLET_ALREADY_BLOCKED";

        public WalletAlreadyBlockedException(Guid walletId)
            : base($"Wallet with ID {walletId} is already blocked.")
        {
        }
    }
}
