﻿using System.Collections.Generic;

namespace Crypto.Arbitrage.CSharp.Exchanges.Poloniex.Models
{
    public class OrderBook
    {
        public List<List<decimal>> Asks { get; set; }

        public List<List<decimal>> Bids { get; set; }

        public string IsFrozen { get; set; }

        public int Seq { get; set; }
    }
}
