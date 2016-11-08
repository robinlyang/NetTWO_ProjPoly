using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTWO_ProjPoly
{
    class sale
    {
        public double quantity, price;
        public virtual double charge()
        {
            return quantity * price;
        }
        public double taxit()
        {
            return 0.05 * charge();
        }
        public void print()
        {
            Console.WriteLine(charge() + taxit());
        }
    }
    class discount_sale : sale
    {
        public override double charge()
        {
            return 0.90 * quantity * price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            discount_sale ds = new discount_sale();
            ds.quantity = 3;
            ds.price = 60;
            ds.print();
            Console.ReadLine();
        }
    }
}
