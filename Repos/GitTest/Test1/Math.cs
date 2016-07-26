using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Math
    {
        internal Math()
        {
            Console.WriteLine("Actions activated...");
        }

        /// <summary>
        /// Add two numbers
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <returns></returns>
        internal double Addition(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }

        /// <summary>
        /// First number minus second number
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNUm"></param>
        /// <returns></returns>
        internal double Subtraction(double firstNum, double secondNUm)
        {
            return firstNum - secondNUm;
        }

        /// <summary>
        /// firstNum times secondNum
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <returns></returns>
        internal double Multiply(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }

        /// <summary>
        /// firstNum devided by secondNum
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <returns></returns>
        internal double Division(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }
    }
}
