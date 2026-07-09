
using NoviBet.Domain.Exceptions;

namespace NoviBet.Domain.ValueObjects
{
    public record Odds
    {
        public decimal Value { get; }

        public Odds(decimal value)
        {
            if (value <= 1.0m) throw new InvalidOddsException(value);

            Value = value;
        }


    }
}
