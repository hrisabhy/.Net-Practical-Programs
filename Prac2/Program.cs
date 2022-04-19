using System;

namespace Prac2
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1, var2;
            Console.Write("Enter var1:");
            var1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter var2:");
            var2 = Int32.Parse(Console.ReadLine());
            if((var1>10 && var2<=10) || (var2>10 && var1 <= 10))
            {
                Console.WriteLine("Both numbers are not greater than 10");
            }
        }
    }
}
