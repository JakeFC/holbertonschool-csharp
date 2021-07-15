using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine();
            return;
        }
        int i = array.Length - 1;
        string sep = " ";
        for (; i >= 0; i--)
        {
            if (i == 0)
                sep = "";
            Console.Write(array[i].ToString() + sep);
        }
        Console.WriteLine();
    }
}