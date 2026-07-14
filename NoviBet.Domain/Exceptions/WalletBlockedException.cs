using System;
using System.Collections.Generic;
using System.Text;

namespace NoviBet.Domain.Exceptions
{
    public sealed class WalletBlockedException : WalletExceptions
    {
        public override string ErrorCode => "WALLET_BLOCKED";
        public Guid WalletId { get; }

        public WalletBlockedException(Guid walletId) : base($"Your wallet with ${walletId} is blocked")
        {
            WalletId = walletId;
        }
    }
}
