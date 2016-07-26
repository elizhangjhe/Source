using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Math act = new Math();

            Utils.ConsoleString(act.Addition(10, 20));
            

            Console.ReadLine();
        }
    }
}
