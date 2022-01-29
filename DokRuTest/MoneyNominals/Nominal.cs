using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokRuTest.MoneyNominals
{
    public class Nominal
    {
        public string Name { get => name;  }
        public double Value { get => value; }

        protected string name;
        protected double value;

        public double CountCoinsInAmaunt(double amount)
        {
            if (amount <= 0)
            {
                return 0;
            }

            return Math.Floor(amount / value);
        }
    }
}
