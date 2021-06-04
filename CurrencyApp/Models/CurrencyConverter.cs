using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApp.Models
{
    public class CurrencyConverter
    {
        public decimal USD { get; set; }
        public decimal ConvertToUSD(decimal priceRUB) => priceRUB / USD;

        public decimal EUR { get; set; }
        public decimal ConvertToEUR(decimal priceRUB) => priceRUB / EUR;
    }
}
