using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Employee                                         // class create Employee
{
    public int id;                                      // parameter
    public string name;
    public float salary;

    public Employee(int i, string n, float s)      // constructor create
    {
        id = i;
        name = n;
        salary = s;
    }

    public void display()                                  // method add
    {
        Console.WriteLine(id + " " + name + " " + salary);
        Console.ReadLine();
    }

    static void Main(string[] args)
    {
        Employee e1 = new Employee(101, "Vikas", 500);          // object create
        Employee e2 = new Employee(102, "Upadhyay", 1000);
        e1.display();                                          // call method by object.methodname
        e2.display();
    }
}

