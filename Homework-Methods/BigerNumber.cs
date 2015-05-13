using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class BigerNumber
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int maxNumber = GetMax(firstNumber, secondNumber);
            Console.WriteLine(maxNumber);
        }
        static int GetMax(int a,int b)
        {
            int bigestNum = a;
            if (a<b)
            {
                bigestNum = b;
            }
            return bigestNum;
        }
    }

