﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class MathOperations
    {

        /// <summary>
        /// Sum Function -- Add up the numerical values seperated by ',' in second argument
        /// </summary>
        /// <param name="Args"></param>
        public int Sum(string Args)
        {
            try
            {
                int sum = 0;
                
                var Arguments=Args.Split(',');
                if (Arguments.Count() == 2)
                {
                    Console.WriteLine(" The Sum of Given Numbers is  {0}", (Convert.ToInt16(Arguments[0]) + Convert.ToInt16(Arguments[1])));
                    return (Convert.ToInt16(Arguments[0]) + Convert.ToInt16(Arguments[1]));
                }
                else if (Arguments.Count() == 1)
                {
                    Console.WriteLine(" The Sum of Given Numbers is  {0}", Arguments[0]);
                    return Convert.ToInt16(Arguments[0]);
                }
                else
                return sum;
            }
            catch { throw new ArgumentException(); }
        }

        /// <summary>
        /// Add Function -- Added Dynamic Delimeter to Argument paramenter
        /// </summary>
        /// <param name="Args"></param>
        public int Add(string Args)
        {
            try
            {
                int sum = 0;
                string splitter = ",";
                string _args = Args;
                if (Args.Contains("\\\\"))
                {
                    var Arguments = Args.Split(new string[] { "\\\\" }, StringSplitOptions.None);
                    if (Arguments.Count() < 3)
                    {
                        Console.WriteLine("Invalid Delimeter Argument string");
                        return 0;
                    }

                    if (Arguments[1] == "")
                    {
                        Console.WriteLine("Invalid Delimeter it cant be blank");
                        return 0;
                    }
                    else
                    {
                        splitter = Arguments[1];
                    }

                    _args = Arguments[2];
                }


                foreach (string val in _args.Split(new string[] { splitter }, StringSplitOptions.None))
                {
                    if (Convert.ToInt16(val) < 0)
                    {
                        Console.WriteLine("Error:Negative values not allowed!!");
                        return 0;
                    }
                    sum += Convert.ToInt16(val);
                }

                Console.WriteLine(" The Sum of Given Numbers is  " + sum);
                return sum;
            }
            catch { throw new ArgumentException(); }
        }
    }
}
