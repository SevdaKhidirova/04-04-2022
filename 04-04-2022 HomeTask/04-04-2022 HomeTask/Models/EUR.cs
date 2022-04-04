using System;
using System.Collections.Generic;
using System.Text;

namespace _04_04_2022_HomeTask.Models
{
    class EUR
    {
        public double Amount { get; set; }

        public EUR(double Amount)
        {
            this.Amount = Amount;
        }
        public static implicit operator AZN(EUR eur)
        {
            return new AZN(eur.Amount * 1.87);
        }

        public static implicit operator USD(EUR eur)
        {
            return new USD(eur.Amount * 1.1);
        }
    }
}
