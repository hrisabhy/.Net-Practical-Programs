using System;

namespace Prac1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, prod;
            Console.WriteLine("Enter n1:");
            n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter n2:");
            n2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter n3:");
            n3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter n4:");
            n4 = Int32.Parse(Console.ReadLine());
            prod = n1 * n2 * n3 * n4;
            Console.WriteLine(n1+"*"+n2+"*"+n3+"*"+n4+"="+prod);
        }
    }
}
