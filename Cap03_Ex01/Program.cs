using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, R;

            Console.Write("entre o valor <A>: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("entre o valor <B>: ");
            B = int.Parse(Console.ReadLine());

            R = A + B;

            Console.WriteLine("resultado = {0}", R);

            Console.WriteLine();
            Console.Write("tecle <enter> para encerrar.... ");
            Console.ReadLine();
        }
    }
}
