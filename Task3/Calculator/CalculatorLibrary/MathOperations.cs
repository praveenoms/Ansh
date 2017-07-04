using System;
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
        /// Sum Function -- Add up the numerical values seperated by ',' in second argument
        /// </summary>
        /// <param name="Args"></param>
        public int Add(string Args)
        {
             try
            {
                int sum = 0;
                foreach (string newline in Args.Split(new string[] { Environment.NewLine }, StringSplitOptions.None))
                {
                    foreach (string val in newline.Split(','))
                    {
                        sum += Convert.ToInt16(val);
                    }
                }
                Console.WriteLine(" The Sum of Given Numbers is  " + sum);
                return sum;
            }
            catch { throw new ArgumentException(); }
        }
    }
}
