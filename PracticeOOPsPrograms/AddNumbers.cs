using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPsPrograms
{
    //Default Constructor
    public class AddNumbers
    {
        public int a, b,sum;
        public AddNumbers() 
        {
            a = 10;
            b = 20;
            sum = a + b;
            Console.WriteLine("a vale :" + a);
            Console.WriteLine("b vale :" + b);
            Console.WriteLine("Default Constructor of add value: "+sum);
        }
    }
}
