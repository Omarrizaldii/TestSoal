using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JawabanTestNo1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Soal Nomor 1 bilangan prima dengan C# .Net \n ");
            Console.Write("Masukkan Batas Bilangan Prima : ");

            bool prima = true;

            int bilangan = int.Parse(Console.ReadLine());
            if (bilangan >= 2)
            {
                //loop hingga batas bilangan tercapai
                for (int i = 2; i <= bilangan; i++)
                {
                    //loop mulai dari 2 ke 1
                    for (int j = 2; j < i; j++)
                    {
                        //bukan bilangan prima jika i habis dibagi j
                        if ((i % j) == 0)
                        {
                            prima = false;
                            break;
                        }
                    }

                    if (prima)
                        Console.WriteLine(i);
                    prima = true;
                }
            }
            else
                Console.WriteLine("Tidak ada bilangan prima yang bisa dituliskan");
            Console.ReadLine();
        }
    }
}