using System.Runtime.CompilerServices;
using System.Collections.Generic;


namespace Baseline;

class Program
{
    static void Main(string[] args)
    {
        GenerateInt();
    }

    public static void rectangle(int y, int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                if (i == 0 || i == x - 1 || j == 0 || j == y - 1)
                {
                    System.Console.Write("*");
                }
                else
                {
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine();
        }
    }

    public static List<int> doubleList(List<int> l)
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
            System.Console.WriteLine(order[str]);
        }
        System.Console.WriteLine("invalid input");
    }

    public static void Round()
    {
        string? numVal = Console.ReadLine();
        double num;
        bool parsed = double.TryParse(numVal, out num);
        if (parsed && num >= 0.0)
        {
            System.Console.WriteLine(Math.Round(num));
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }
    public static void GenerateInt()
    {
        string? numVal = Console.ReadLine();
        double num;
        bool parsed = double.TryParse(numVal, out num);
        // I made conditions to validate the input
        if (parsed && num >= 0.0)
        {
            string n = ((decimal)num - (int)num).ToString().Substring(2);
            int result = Int16.Parse(n);
            System.Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }



}
