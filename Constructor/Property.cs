using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Employee
    {
        private string name;

        public string Name;
        {
           get
             {
               return name;
             }
          set
             {
               name = value;
              }
        }
     }

    class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee();
        e1.Name = "Vikas";
        Console.WriteLine("Employee Name" + e1.Name);
        Console.ReadLine();
    }
  }
}