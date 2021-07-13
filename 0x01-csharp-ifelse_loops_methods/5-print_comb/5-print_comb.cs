using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string sep = ", ";
            for (i = 0; i < 99; i++)
            {
                Console.Write("{0}{1}", i.ToString(), sep);
            }
            Console.WriteLine(i);
        }
    }
}
