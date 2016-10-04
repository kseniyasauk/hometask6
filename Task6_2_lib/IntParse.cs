using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6_2_lib
{
    public class IntParse
    {
        public int ConvertToInteger(string input)
        {
            int defaultValue = -1;
            //string pattern = @"^\-?[0-9]+$";
            //Regex rgx = new Regex(pattern);
            //Match match = rgx.Match(input);
            try
            {
                defaultValue = checked(Convert.ToInt32(input));
                Console.WriteLine($"Number is: {defaultValue}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            
            //Console.ReadKey();
            return defaultValue;

            
        }
    }
}
