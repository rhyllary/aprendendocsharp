using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, R;
            Console.Write("entre o 1o. valor: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("entre o 2o. valor: ");
            B = int.Parse(Console.ReadLine());

            R = A + B;

            Console.WriteLine();
            Console.WriteLine("resultado = " + R);

            Console.WriteLine();
            Console.Write("tecle <enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
