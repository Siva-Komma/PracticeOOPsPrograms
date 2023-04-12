using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPsPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OOP's Practice programs");
            AddNumbers num= new AddNumbers();   
            Console.WriteLine(num.sum +"\n");
           
            Substraction sub = new Substraction(20, 10);
            Console.WriteLine(sub.sub +"\n");

            Employee emp1 = new Employee("Vithal", 23);  
            Employee emp2 = new Employee(emp1);          
            Console.WriteLine(emp2.Details);

            Student.Marks();

            Console.WriteLine("\nPrivate constructor");
            Counter.currentview = 500;
            Counter.visitedCount();
            Console.WriteLine("Now the view count is: {0}", Counter.currentview);

            Console.WriteLine("\nInterface example");
            Pig myPig = new Pig();  
            myPig.animalSound();

            Console.WriteLine("\nAccess Modifiers example");
            AccessMod mod= new AccessMod();
            mod.Add();//public
            mod.Mul();//internal
            AccessMod2 mod1 =new AccessMod2();//protected
            mod1.Add();
            mod1.Mul();
            Console.ReadLine();
        }
    }
}
