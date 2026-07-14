
using NoviBet.Domain.Entities;
using NoviBet.Domain.Repositories;
using NoviBet.Domain.ValueObjects;
using NoviBet.Domain.Exceptions;
using NoviBet.Domain.Enums;

namespace Application.Services
{
    public class BetService
    {
        private readonly IWalletRepository _walletRepository;
        private readonly IBetRepository _betRepository;
        private readonly IPlayerRepository _playerRepository;
        private readonly IMatchRepository _matchRepository;

        public BetService(IWalletRepository walletRepository, IBetRepository betRepository, IPlayerRepository playerRepository, IMatchRepository matchrepository)
        {
            _walletRepository = walletRepository;
            _playerRepository = playerRepository;
            _betRepository = betRepository;
            _matchRepository = matchrepository;
        }

        public Bet PlaceBet(Guid playerId, decimal stake, IReadOnlyList<Selection> selections)
        {
           if(playerId == Guid.Empty)
                throw new ArgumentException("Player cannot be empty", nameof(playerId));


            var existingPlayer = _playerRepository.GetPlayerById(playerId)?? throw new PlayerIsNotFoundException(playerId);
            var wallet = _walletRepository.GetByPlayerId(playerId) ?? throw new WalletNotFoundException(existingPlayer.Id);

            var bet = new Bet(playerId, stake, selections);

            foreach (var selection in selections)
            {
                var match = _matchRepository.GetMatchById(selection.MatchId) ?? throw new MatchNotFoundException("Match not found");
                if (match.MatchStatus != MatchStatus.Scheduled)
                    throw new MatchNotOpenForBettingException("Match is not available for betting.");
            }

            wallet.Withdraw(stake);
            _betRepository.AddBet(bet);
            return bet;
        }

        public void SettleBet(Guid betId)
        {
            var bet = _betRepository.GetBetById(betId) ?? throw new BetNotFoundException(betId);

            var results = new Dictionary<Guid, MatchResult>();

            foreach (var selection in bet.Selections)
            {
                var match = _matchRepository.GetMatchById(selection.MatchId) ?? throw new MatchNotFoundException(selection.MatchId);

                if (match.MatchResult is not null)
                    results[selection.MatchId] = match.MatchResult.Value;

                bet.Settle(results);

                if (bet.BetStatus == BetStatus.Won)
                {
                    var wallet = _walletRepository.GetByPlayerId(bet.PlayerId) ?? throw new WalletNotFoundException(bet.PlayerId);

                    wallet.Deposit(bet.PotentialWinnings);
                }
            }

        }
    }
}
