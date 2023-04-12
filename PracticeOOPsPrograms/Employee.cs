using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPsPrograms
{
    //Copy Constructor
    class Employee
    {
        private string name;
        private int age;
        public Employee(Employee emp) 
        {
            name = emp.name;
            age = emp.age;
        }
        public Employee(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }
        public string Details     
        {
            get
            {
                return "The age of " + name + " is " + age.ToString();
            }
        }
    }
}
