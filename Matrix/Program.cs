using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int extension = 1011001101;

            for(int i = 1; i <= 10; i=+1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("01110 10101    101010101101          0101010   01011010" + extension);
                Console.Write("011    0 10 1 0 10 10 0 10 10 10 10 10 10 11 0" + extension);
                Console.Write("0101101  011010 11011010 1  101 1 110 01 10 0000 101 010 10101" + extension);
                Console.Write("01 01 1 01 1 1 0 1  10111" + extension);
                Console.Write("00101       011011011010101    01001101010101010101110  101 0101 01110 10 1010   01 01 0 11" + extension);
                Console.Write("1010 1 011 11010 0 011    1 0 101010 1   10      101101010 1 01010 01 01100101010 0        111 0111" + extension);
                Console.Write("10 11101 0101 00 0 010 101 01101 10 1101 011 10101 00  01" + extension);
                Console.Write("1010 1 1 1010 0101 01 01 10101 0 101 11 0 0  0      01 0101101" + extension);
                Console.Write("10 11101 0101 00 0 010 101 01101 10 1101 011 10101 00  01" + extension);
            }
        }
    }
}
