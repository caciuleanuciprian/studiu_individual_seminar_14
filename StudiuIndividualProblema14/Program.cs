using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiuIndividualProblema14
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, suma = 0;

            Console.WriteLine("n= ");
            n = int.Parse(Console.ReadLine());

            while(n != 0)
            {
                suma = suma + (n % 10);
                n = n / 10;
            }

            Console.WriteLine(suma);

            Console.ReadLine();

        }
    }
}
