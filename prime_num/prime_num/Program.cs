using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] data = new int[10001][,];
            for (int i = 2; i < data.Length; i++)
            {
                data[i] = new int[2, 2];
                //Console.WriteLine("{0}", i, data[i]);

                bool asalmi = true;

                for (int bolen = 2; bolen < i; bolen++)
                {
                    if (i % bolen == 0) // sadece bu if e girerse sayı asaldır
                    {
                        asalmi = false;             // if ten sonra kontrol et asalmı = true ise bu if e hiç girilemmeiştir
                        break; // bir kere bile false olsa çık tekrar tekrar denemeye gerek yok 
                               //belirli bi koşul gerçekleşirse döngüden çık
                    }
                }
                if (asalmi)
                {
                    Console.WriteLine($" { i} asaldır ");
                }

            }


            Console.ReadLine();
        }
    }
}
