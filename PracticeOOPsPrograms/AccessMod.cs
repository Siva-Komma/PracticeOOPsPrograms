using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPsPrograms
{
    class AccessMod
    {
        public void Add()
        {
            Console.WriteLine("public access modifier");
            int a = 10, b = 12;
            int sum = a + b; 
            Console.WriteLine("sum is: "+sum+"\n");
        }
        private void Sub()
        //Private method is only Accessble with in the class
        {
            Console.WriteLine("private access modifier");
            int a = 10, b = 12;
            int sub = b - a;
            Console.WriteLine("sub is: " + sub+"\n");
        }
        internal void Mul()
        {
            Console.WriteLine("Internal access modifier");
            Sub();
        }
    }
    class AccessMod2:AccessMod
    {
        public int num2;
    }
}
