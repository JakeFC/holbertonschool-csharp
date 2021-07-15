using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] arr = new int[size];
        string sep = " ";
        for (int i = 0; i < size; i++)
        {
            arr[i] = i;
            if (i == size - 1)
                sep = "";
            Console.Write(i.ToString() + sep);
        }
        Console.WriteLine();
        return arr;
    }
}