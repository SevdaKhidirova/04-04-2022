using System;
using System.Collections.Generic;
using System.Text;

namespace _04_04_2022_HomeTask.Models
{
    class AZN
    {
        public double Amount { get; set; }

        public AZN(double Amount)
        {
            this.Amount = Amount;
        }
      
        public static implicit operator USD(AZN azn)
        {
            return new USD(azn.Amount / 1.7);
        }
        public static implicit operator EUR(AZN azn)
        {
            return new EUR(azn.Amount * 0.54);
        }

        public static bool operator ==(AZN azn,USD usd)
        {
            if ((azn.Amount * 1.7 == usd.Amount))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(AZN azn, USD usd)
        {
            if ((azn.Amount * 1.7 == usd.Amount))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}



