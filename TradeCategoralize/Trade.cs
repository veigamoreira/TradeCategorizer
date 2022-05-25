using System;

namespace TradeCategoralize
{
    public class Trade : ITrade
    {
        public double Value { get; set; }

        public string ClientSector { get; set; }

        public DateTime NextPaymentDate { get; set; }

        public bool PEP { get; set; }


        public string ValidateTrade(Trade trade, DateTime dateBase)
        {
            if (trade.NextPaymentDate.AddDays(30) < dateBase )
                return "EXPIRED";
            if (trade.ClientSector.ToUpper() == "PRIVATE" && trade.Value > 1000000)
                return "HIGHRISK";
            if (trade.ClientSector.ToUpper() == "PUBLIC" && trade.Value > 1000000)
                return "MEDIUMRISK";

            return "UNCATEGORIZED";
        }
    }
}
