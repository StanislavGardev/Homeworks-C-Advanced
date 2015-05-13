using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class NumberCalculations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ener bouble numbers separated by space");
            double [] doubleNum=Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Console.WriteLine("Ener decimal numbers separated by space");
            double [] decimalNum=Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Console.WriteLine("Minimum double: {0}",MinNumber(doubleNum));
            Console.WriteLine("Maximum double: {0}", MaxNumber(doubleNum));
            Console.WriteLine("Average double: {0}", Average(doubleNum));
            Console.WriteLine("Sum double: {0}",Sum(doubleNum));
            Console.WriteLine("Product double: {0}", Product(doubleNum));
            Console.WriteLine();
            Console.WriteLine("Minimum decimal: {0}", MinNumber(decimalNum));
            Console.WriteLine("Maximum decimal: {0}", MaxNumber(decimalNum));
            Console.WriteLine("Average decimal: {0}", Average(decimalNum));
            Console.WriteLine("Sum decimal: {0}", Sum(decimalNum));
            Console.WriteLine("Product decimal: {0}", Product(decimalNum));


        }


        static double MaxNumber(double[] num)
        {
            double maxValue = double.MinValue;
            for (int i = 0; i < num.Length; i++)
            {
                if (maxValue<num[i])
                {
                    maxValue = num[i];
                }
            }
            return maxValue;
        }
        static double MinNumber(double[] num)
        {
            double minValue = double.MaxValue;
            for (int i = 0; i < num.Length; i++)
            {
                if (minValue > num[i])
                {
                    minValue = num[i];
                }
            }
            return minValue;
        }
        static double Average(double[] num)
        {
            double avarage = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                avarage += num[i];
            }
            avarage /= num.Length;
            return avarage;
        }
        static double Sum(double[] num)
        {
            double sum = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                sum += num[i];
            }
            return sum;
        }
        static double Product(double[] num)
        {
            double product = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                product *= num[i];
            }
            return product;
        }
        //decimals

        static decimal MaxNumber(decimal[] num)
        {
            decimal maxValue = decimal.MinValue;
            for (int i = 0; i < num.Length; i++)
            {
                if (maxValue < num[i])
                {
                    maxValue = num[i];
                }
            }
            return maxValue;
        }
        static decimal MinNumber(decimal[] num)
        {
            decimal minValue = decimal.MaxValue;
            for (int i = 0; i < num.Length; i++)
            {
                if (minValue > num[i])
                {
                    minValue = num[i];
                }
            }
            return minValue;
        }
        static decimal Avarage(decimal[] num)
        {
            decimal avarage = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                avarage += num[i];
            }
            avarage /= num.Length;
            return avarage;
        }
        static decimal Sum(decimal[] num)
        {
            decimal sum = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                sum += num[i];
            }
            return sum;
        }
        static decimal Product(decimal[] num)
        {
            decimal product = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                product *= num[i];
            }
            return product;
        }
    }

