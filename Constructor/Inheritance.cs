using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    //public class Employee
    //{
    //    public float salary = 100;        // class field
    //}

    //public class Programmer : Employee
    //{
    //    public float bonus = 100;         // class field
    //}

    //class TestInheritance
    //{
    //    public static void Main(string[] args)
    //    {
    //        Programmer p1 = new Programmer();
    //        Console.WriteLine("Salary" + p1.salary);
    //        Console.WriteLine("Bonus" + p1.bonus);
    //    }
    //}

    public class animal
    {
        public void eat()                         // class method
        {
            Console.WriteLine("Eating food");
        }
    }
    public class dog : animal
    {
        public void bark()                      // class method
        {
            Console.WriteLine("Barking...");
        }
    }

    class TestInheritance2
    {
        public static void Main(string[] args)
        {
            dog d1 = new dog();          // class object created
            d1.eat();                      // call method
            d1.bark();
        }
    }
}
