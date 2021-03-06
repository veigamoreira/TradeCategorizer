using System;
using System.Collections.Generic;
using System.Text;

namespace TradeCategoralize
{
    interface ITrade
    {

        double Value { get; } //indicates the transaction amount in dollars
        string ClientSector { get; } //indicates the client´s sector which can be "Public" or "Private"
        DateTime NextPaymentDate { get; } //indicates when the next payment from the client to the bank is expected

        string ValidateTrade(Trade trade, DateTime dateBase); //operation
    }
}
