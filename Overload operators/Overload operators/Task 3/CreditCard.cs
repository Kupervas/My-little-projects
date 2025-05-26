using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_operators.Task_3
{
    public class CreditCard
    {
        public decimal Amount { get; set; }
        public int Cvc { get; set; }

        public CreditCard(decimal amount, int cvc)
        {
            Amount = amount;
            Cvc = cvc;
        }

        public static CreditCard operator +(CreditCard card, decimal sum)
        {
            return new CreditCard(card.Amount + sum, card.Cvc);
        }

        public static CreditCard operator -(CreditCard card, decimal sum)
        {
            return new CreditCard(card.Amount - sum, card.Cvc);
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            if (ReferenceEquals(card1, card2)) return true;
            if (card1 is null || card2 is null) return false;
            return card1.Cvc == card2.Cvc;
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return !(card1 == card2);
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Amount < card2.Amount;
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Amount > card2.Amount;
        }
        public override bool Equals(object obj)
        {
            if (obj is CreditCard card)
                return this == card;
            return false;
        }

        public override int GetHashCode()
        {
            return Cvc.GetHashCode();
        }
    }
} 