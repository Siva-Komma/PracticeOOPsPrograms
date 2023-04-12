using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPsPrograms
{
    public class Counter
    {
        private Counter() { }
        public static int currentview;
        public static int visitedCount()
        {
            return ++currentview;
        }
    }
}
