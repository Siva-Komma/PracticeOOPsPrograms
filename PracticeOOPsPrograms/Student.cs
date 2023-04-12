using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPsPrograms
{
    //Static Constructor
    public class Student
    {
        static Student()
        {
            Console.WriteLine("\nStatic Constructor");
        }
        public static void Marks()
        {
            int maths = 10; int english = 20;
            Console.WriteLine("maths value: " + maths);
            Console.WriteLine("english value: " + english);
        }
    }
}
