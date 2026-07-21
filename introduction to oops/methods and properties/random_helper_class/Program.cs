using System;

class RandomHelper
{
    static Random r = new Random();

    static int RandInt(int min, int max)
    {
        return r.Next(min, max + 1);
    }

    static double RandDouble(int min, int max)
    {
        return min + r.NextDouble() * (max - min);
    }

    static void Main()
    {
        Console.WriteLine("Random Integer : " + RandInt(1, 10));

        Console.WriteLine("Random Double : " + RandDouble(1, 10));
    }
}
