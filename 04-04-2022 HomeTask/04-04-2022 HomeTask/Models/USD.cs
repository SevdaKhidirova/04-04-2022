using System;
using System.Collections.Generic;
using System.Text;

namespace _04_04_2022_HomeTask.Models
{
    class USD
    {
        public double Amount { get; set; }

        public USD(double Amount)
        {
            this.Amount = Amount;
        }

        public static implicit operator AZN(USD usd)
        {
            return new AZN(usd.Amount * 1.7);
        }
        public static implicit operator EUR(USD usd)
        {
            return new EUR(usd.Amount * 0.91);
        }
    }
}
