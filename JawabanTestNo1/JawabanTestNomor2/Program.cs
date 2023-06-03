using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JawabanTestNomor2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Soal no 2\n");
            Console.WriteLine("Masukan nilai : ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}