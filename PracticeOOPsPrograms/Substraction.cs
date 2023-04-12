using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPsPrograms
{
    //Parameterised Constructor
    public class Substraction
    {
        public int sub;
        public Substraction(int a,int b)
        {
            sub = a - b;
            Console.WriteLine("a vale :" + a);
            Console.WriteLine("b vale :" + b);
            Console.WriteLine("Parameterised Constructor of vale :" + sub);
        }
    }
}
