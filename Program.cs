using System.Runtime.CompilerServices;
using System.Collections.Generic;


namespace Baseline;

class Program
{
    static void Main(string[] args)
    {
        GenerateInt();
    }

    // 2
    public static List<int> DoubleList(List<int> l)
    {
        List<int> newList = new List<int>();
        l.ForEach(i => newList.Add(i * 2));
        return newList;
    }

    public static List<int> divideByThreeList(List<int> l)
    {
        List<int> newList = new List<int>();
        l.ForEach(i =>
        {
            if (i % 3 == 0)
                newList.Add(i);
        });

        return newList;
    }

    // 3
    public static void rectangle(int y, int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                if (i == 0 || i == x - 1 || j == 0 || j == y - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    // 5
    public static void FindEnumValue(string str)
    {
        Dictionary<string, Order> order = new Dictionary<string, Order>();
        order.Add("exit", Order.EXIT);
        order.Add("first", Order.FIRST);
        order.Add("second", Order.SECOND);
        order.Add("third", Order.THIRD);

        if (str.Equals("exit"))
        {
            return;
        }
        if (order.ContainsKey(str))
        {
            Console.WriteLine(order[str]);
        }
        Console.WriteLine("invalid input");
    }

    // 6
    public static void Round()
    {
        string? numVal = Console.ReadLine();
        double num;
        bool parsed = double.TryParse(numVal, out num);
        if (parsed && num >= 0.0)
        {
            Console.WriteLine(Math.Round(num));
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }

    // 7
    public static void GenerateInt()
    {
        string? numVal = Console.ReadLine();
        double num;
        bool parsed = double.TryParse(numVal, out num);
        // I made conditions to validate the input
        if (parsed && num >= 0.0)
        {
            Console.WriteLine((int)num);
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }

    // 8
    public static void Power()
    {
        string? numVal = Console.ReadLine();
        double num;
        bool parsed = double.TryParse(numVal, out num);
        if (parsed)
        {
            Console.WriteLine(Math.Pow(num, 2));
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }

    // 9
    // a
    public static void PerfectNumbersForLoop()
    {
        for (int i = 1; i < 1000000; i++)
        {
            if (isPerfectForLoop(i))
            {
                Console.Write(i + ", ");
            }
        }
    }

    static bool isPerfectForLoop(int n)
    {
        int sum = 1;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                if (i * i != n)
                    sum = sum + i + n / i;
                else
                    sum = sum + i;
            }
        }
        if (sum == n && n != 1)
            return true;

        return false;
    }

    // b
    public static void PerfectNumbersWhileLoop()
    {
        int i = 1;
        while (i < 1000000)
        {
            if (isPerfectForLoop(i))
            {
                Console.Write(i + ", ");
            }
            i++;
        }
    }

    static bool isPerfectWhileLoop(int n)
    {
        int sum = 1;
        int i = 2;

        while (i * i <= n)
        {
            if (n % i == 0)
            {
                if (i * i != n)
                    sum = sum + i + n / i;
                else
                    sum = sum + i;
            }
            i++;
        }
        if (sum == n && n != 1)
            return true;

        return false;
    }

    // 10
    public static void SumOfDigits()
    {
        string? numVal = Console.ReadLine();
        double num;
        bool parsed = double.TryParse(numVal, out num);
        if (parsed)
        {
            int sum = 0;
            // while (num % 10 > 0)
            // {
            //     num *= 10;
            // }
            int n = (int)num;
            while (num > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }
}
