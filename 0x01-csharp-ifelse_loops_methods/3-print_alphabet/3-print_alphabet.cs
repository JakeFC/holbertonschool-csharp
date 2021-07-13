using System;

namespace _3_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            for (c = 'a'; c <= 'z'; c++)
                if (c != 'q' && c != 'e')
                    Console.Write(c);
        }
    }
}
