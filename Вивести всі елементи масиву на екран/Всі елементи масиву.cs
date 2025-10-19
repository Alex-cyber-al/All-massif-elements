using System;
using System.Net.NetworkInformation;
class Program
    {
    static void Main()
    {
        int[] numbers = new int[10];
        numbers[0] = 2;
        numbers[1] = 4;
        numbers[2] = 6;
        numbers[3] = 8;
        numbers[4] = 10;
        numbers[5] = 12;
        numbers[6] = 14;
        numbers[7] = 16;
        numbers[8] = 18;
        numbers[9] = 20;
        Console.WriteLine("Масив чисел:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

    }
}




