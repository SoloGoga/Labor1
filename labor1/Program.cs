using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labor1
{
    class Program
    {
        static void Main(string[] args)
        {
            double mnoz1, mnoz2, ans;

            Console.WriteLine("Введите числа, произведения которых вы хотите найти.");

            mnoz1 = Convert.ToDouble(Console.ReadLine());

            mnoz2 = Convert.ToDouble(Console.ReadLine());

            ans = mnoz1 * mnoz2;

            Console.Write(mnoz1 + " * " + mnoz2 + " = " + ans);

            Console.ReadLine();
        }

    }
}
