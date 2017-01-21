namespace Problem1HungryGarfield
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            decimal JohnMoneyGarfild = decimal.Parse(Console.ReadLine());
            decimal kursDolar = decimal.Parse(Console.ReadLine());
            decimal PizzaPrice = decimal.Parse(Console.ReadLine());
            decimal LasagnalPrice = decimal.Parse(Console.ReadLine());
            decimal SandvichPrice = decimal.Parse(Console.ReadLine());
            decimal PizzaQuantityGarfield = decimal.Parse(Console.ReadLine());
            decimal LasagnalQuantityGarfield = decimal.Parse(Console.ReadLine());
            decimal SandvichQuantityGarfield = decimal.Parse(Console.ReadLine());

            decimal PizzaDolarsQuantity = (PizzaPrice / kursDolar) * PizzaQuantityGarfield;
            decimal LasagnalDolarsQuantity = (LasagnalPrice / kursDolar) * LasagnalQuantityGarfield;
            decimal SandvichDolarsQuantity = (SandvichPrice / kursDolar) * SandvichQuantityGarfield;

            decimal result = PizzaDolarsQuantity + LasagnalDolarsQuantity + SandvichDolarsQuantity;
            //Console.WriteLine(string.Format("{0:F2}",result ));
            ////Console.WriteLine(result);
            if (result < JohnMoneyGarfild)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", JohnMoneyGarfild - result);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:F2}.", Math.Abs(JohnMoneyGarfild - result));
            }
        }
    }
}
