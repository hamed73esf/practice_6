using System;
using System.ComponentModel;

class test
{
    public static void Main()
    {
        int temp = 0;
        Console.WriteLine("enter x:");
        string a = Console.ReadLine();
        if (a == "0")
        {
            Console.WriteLine("adad bala 0 vared kon");
            Console.WriteLine("enter x:");
            a = Console.ReadLine();
        }
        Console.WriteLine("enter y:");
        string b = Console.ReadLine();
        if (b == "0")
        {
            Console.WriteLine("adad bala 0 vared kon");
            Console.WriteLine("enter y:");
            b = Console.ReadLine();
        }
        int x = Convert.ToInt32(a);
        int y = Convert.ToInt32(b);
            if (y > x)
            {
                temp = y;
                y = x;
                x = temp;
            }
        Console.Write("KMM=");
        Console.WriteLine(KMM(x, y));
        Console.Write("BMM=");
        Console.Write(BMM(x, y));
    }
    private static double KMM(int x, int y)
    {
        double m =0;
        int n = 0;
        do
        {
            n++;
            m = x * n;
        }
        while (m % y != 0);
        return m;
    }
    private static double BMM(int x, int y)
    {
        int m = 0;
        int n = 0;
        int p = 0;
        do
        {
            m++;
            if (x % m == 0)
            {
                n = x / m;
                if (y % n == 0)
                {
                    p = n;
                }
            }
        }
        while ((y % m) == 0);
        if(p == 0)
        {
            Console.Write("BMM nadarad    ");
        }
            return (p);
    }
}