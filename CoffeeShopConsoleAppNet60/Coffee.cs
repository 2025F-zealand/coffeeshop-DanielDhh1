using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public int Discount { get; set; }

        public Coffee(int discount = 0)
        {
            if (discount > 5)
            {
                throw new ArgumentException("Rabatten kan ikke være højere end 5 DKK.");
            }
            Discount = discount;
        }
        public virtual int Price()
        {
            return 20 - Discount;
        }
        public abstract string Strength();
    }
}
