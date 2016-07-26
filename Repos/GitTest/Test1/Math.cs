﻿using System;
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
        internal double Division(double firstNum, double secondNUm)
        {
            return firstNum - secondNUm;
        }
    }
}