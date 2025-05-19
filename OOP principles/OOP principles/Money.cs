using System;

namespace OOP_principles
{
    internal class Money
    {
        private int wholePart;
        private int fractionPart;

        public Money(int wholePart, int fractionPart)
        {
            SetMoney(wholePart, fractionPart);
        }

        public int WholePart
        {
            get { return wholePart; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Ціла частина не може бути від'ємною");
                wholePart = value;
            }
        }

        public int FractionPart
        {
            get { return fractionPart; }
            set
            {
                if (value < 0 || value > 99)
                    throw new ArgumentException("Копійки мають бути в межах 0-99");
                fractionPart = value;
            }
        }

        public void SetMoney(int wholePart, int fractionPart)
        {
            if (fractionPart >= 100)
            {
                wholePart += fractionPart / 100;
                fractionPart %= 100;
            }
            WholePart = wholePart;
            FractionPart = fractionPart;
        }

        public void Display()
        {
            Console.WriteLine($"{WholePart}.{FractionPart:D2}");
        }

        public void Add(Money other)
        {
            int newFractionPart = this.FractionPart + other.FractionPart;
            int newWholePart = this.WholePart + other.WholePart + (newFractionPart / 100);
            SetMoney(newWholePart, newFractionPart % 100);
        }

        public void Subtract(Money other)
        {
            int totalCents = (WholePart * 100 + FractionPart) - (other.WholePart * 100 + other.FractionPart);
            if (totalCents < 0)
                throw new Exception("Результат не може бути від'ємним");
            SetMoney(totalCents / 100, totalCents % 100);
        }
    }
}