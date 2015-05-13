using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class LastDigitOfNumber
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(GetLastDigitsAsWord(input));
        }
         static string GetLastDigitsAsWord(int number)
        {

             string word="";
             int lastNumber = number % 10;
             switch (lastNumber)
             {
                 case 0: word = "zero"; break;
                 case 1: word = "one"; break;
                 case 2: word = "two"; break;
                 case 3: word = "three"; break;
                 case 4: word = "four"; break;
                 case 5: word = "five"; break;
                 case 6: word = "six"; break;
                 case 7: word = "seven"; break;
                 case 8: word = "eitgh"; break;
                 case 9: word = "nine"; break;

                 
             }

             return word;
        }
    }

