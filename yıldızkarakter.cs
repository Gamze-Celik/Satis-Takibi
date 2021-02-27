
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yildizz
{
    class Program
    {
        static void Main(string[] args)
        {
            { 
            for (int i = 0; i <= 12; i = i + 2)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("*");
            }
            for (int j = 1; j <= 5; j++)
            {
                Console.SetCursorPosition(6, j);
                Console.Write("*");
            }
            for (int k = 18; k <= 26; k = k + 2)
            {
                Console.SetCursorPosition(k, 0);
                Console.Write("*");
            }
            for (int l = 1; l <= 4; l++)
            {
                Console.SetCursorPosition(18, l);
                Console.Write("*");
            }
            for (int n = 18; n <= 26; n++)
            {
                Console.SetCursorPosition(n, 5);
                Console.Write("*");
            }
         Console.ReadKey();
        }

    }
    }
}
