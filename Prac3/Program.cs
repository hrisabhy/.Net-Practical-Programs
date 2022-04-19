using System;

namespace Prac3
{
    class Program
    {
        struct student
        {
            public string Id, name, cname;
            public int day, month, year;
        }
        static void Main(string[] args)
        {
            student[] students = new student[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Enter Id:");
                students[i].Id = Console.ReadLine();
                Console.Write("Enter Name:");
                students[i].name = Console.ReadLine();
                Console.Write("Enter Course Name:");
                students[i].cname = Console.ReadLine();
                Console.Write("Day:");
                students[i].day = Int32.Parse(Console.ReadLine());
                Console.Write("Month:");
                students[i].month = Int32.Parse(Console.ReadLine());
                Console.Write("Year:");
                students[i].year = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Student list:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Student Id:" + students[i].Id);
                Console.WriteLine("Student Name:" + students[i].name);
                Console.WriteLine("Course Name:" + students[i].cname);
                Console.WriteLine("DOB:" + students[i].day + "/" + students[i].month + "/" + students[i].year);
            }
        }
    }
}
