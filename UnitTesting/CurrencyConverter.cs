using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class CurrencyConverter
    {
        private const decimal EuroRate = 4.2m; 
        private const decimal UsdRate = 4.5m;
        private const decimal GbpRate = 5.0m;
        private const decimal JpyRate = 0.03m; 

        public decimal PLNToEuro(decimal amount)
        {
            return amount * EuroRate;
        }

        public decimal PLNToUsd(decimal amount)
        {
            return amount * UsdRate;
        }

        public decimal PLNToGbp(decimal amount)
        {
            return amount * GbpRate;
        }

        public decimal PLNToJpy(decimal amount)
        {
            return amount * JpyRate;
        }
    }
}
