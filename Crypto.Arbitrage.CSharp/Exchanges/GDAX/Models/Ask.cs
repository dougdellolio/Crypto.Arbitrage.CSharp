﻿namespace Crypto.Arbitrage.CSharp.Exchanges.GDAX.Models
{
    public class Ask : Quote
    {
        public Ask(
            decimal price,
            decimal size)
                : base(price, size)
        {
        }
    }
}
