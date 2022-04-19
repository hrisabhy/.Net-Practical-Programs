using System;

namespace Prac4

{
    class furniture
    {
        public string material;
        public int price;

        public void getFurnitureInfo()
        {
            Console.WriteLine(material + " " + price);
        }
        
    }

    class Table : furniture
    {
        public int height;
        public int surface;
        public void getTableFurniture()
        {
            Console.WriteLine(height + " " + surface);
        }
    }
    
    class Employee
    {
        string Name;
        int basicSalary;
        public Employee(string name,int basicSalary)
        {
            this.Name = Name;
            this.basicSalary = basicSalary;

        }
        public void getInfo()
        {
            Console.WriteLine("Name:" + Name + "Basic Salary:" + basicSalary);
        }
    }

    interface gross
    {
        int getGrossSalaray(int basicSal);
    }
    class Program
    {
        static void Main(string[] args)
        {
            furniture f1 = new furniture();
            Table t1 = new Table();
            t1.material = "Wood";
            t1.price = 500;
            t1.height=120;
            t1.surface = 21;
            Console.WriteLine(t1.material+" "+ t1.price+ " " + t1.height+ " " + t1.surface);

        }
    }
}
