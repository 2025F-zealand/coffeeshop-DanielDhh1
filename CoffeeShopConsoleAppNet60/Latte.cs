using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee, IMilk
    {
        public Latte(int discount = 0) : base(discount) { }
        public override int Price()
        {
            return 40 - Discount;
        }
        public override string Strength()
        {
            return "Weak";
        }
        public int mlMilk()
        {
            return 200;
        }
    }
}
