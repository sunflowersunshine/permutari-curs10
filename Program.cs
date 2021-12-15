using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace permutari_curs10
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.WriteLine("Introduceti n: ");
            n = Convert.ToInt32(Console.ReadLine());
            new  permutariSolver(n).Solve();
            Console.ReadKey();

        }
    }
}
