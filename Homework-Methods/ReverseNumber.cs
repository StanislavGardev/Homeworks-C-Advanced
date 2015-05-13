using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ReverseNumber
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double reversed = GetReversedNumber(input);

            Console.WriteLine(reversed);
        }
        static double GetReversedNumber(double num)
        {
                      
            double res =double.Parse(string.Join("",num.ToString().TrimStart('-').Reverse()));
           
            return res;

        }
    }

