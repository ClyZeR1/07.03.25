using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Employee : Person
    {
        public string company;
        public string job;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public string Job
        {
            get { return job; }
            set { job = value; }
        }

        public Employee(string name, string surname, int age, string company, string job)
            : base(name, surname, age)
        {
            this.company = company;
            this.job = job;
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Company: {company}, Job: {job}");
        }
    }
}
