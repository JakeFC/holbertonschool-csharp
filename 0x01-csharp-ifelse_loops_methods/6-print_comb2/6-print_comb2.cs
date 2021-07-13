using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string sep = ", ";
            for (i = 0; i < 89; i++)
            {
                if (i % 10 > i / 10)
                    Console.Write("{0}{1}", i.ToString("D2"), sep);
            }
            Console.WriteLine(i.ToString("D2"));
        }
    }
}
