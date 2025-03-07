using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Vladimir", "Banulyak",17);
            person.Output();

            Console.WriteLine();

            Employee employee = new Employee("Dmitriy", "Starodub", 18, "Sheriff", "Developer");
            employee.Output();

            Console.WriteLine();


            Person personEmployee = new Employee("Ivan", "Ivanov", 17, "Call-centr", "Manager");
            personEmployee.Output();
            Console.ReadKey();
        }
    }
}