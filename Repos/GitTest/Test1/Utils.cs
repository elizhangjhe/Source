using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Utils
    {
        /// <summary>
        /// Write string in console window
        /// </summary>
        /// <param name="context"></param>
        internal static void ConsoleString(string context)
        {
            Console.WriteLine(context);
        }

        /// <summary>
        /// Write integer in console window
        /// </summary>
        /// <param name="context"></param>
        internal static void ConsoleString(int context)
        {
            Console.WriteLine(context.ToString());
        }

        /// <summary>
        /// Write double in console window
        /// </summary>
        /// <param name="context"></param>
        internal static void ConsoleString(double context)
        {
            Console.WriteLine(context.ToString());
        }
       
    }
}
