using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Blackcoffee : Coffee
    {
        public Blackcoffee(int discount = 0) : base(discount) { }
        
        public override int Price()
        {
            return 20;
        }
        public override string Strength()
        {
            return "Strong";
        }
    }
}
