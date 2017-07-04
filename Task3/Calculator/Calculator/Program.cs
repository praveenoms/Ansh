using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations _MthOperation = new MathOperations();
            if (args.Count() > 0)
            {
                switch (args[0].ToString().ToUpper())
                {
                    case "SUM":
                       _MthOperation.Sum((args.Count() > 1 ? args[1].ToString() : "0")); ; // Check if any Argument is passed after the operation
                        break;
                    case "ADD":
                        _MthOperation.Add((args.Count() > 1 ? args[1].ToString() : "0")); // Check if any Argument is passed after the operation
                        break;

                }
            }
        }
    }
}
