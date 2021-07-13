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
                Console.Write("{0}{1}", i.ToString("D2"), sep);
            }
            Console.WriteLine(i.ToString("D2"));
        }
    }
}
