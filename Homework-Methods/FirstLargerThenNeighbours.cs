using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class irstLargerThenNeighbours
    {
        static void Main(string[] args)
        {
            int[] seqenceOne = { 1, 2, 4, 5, 1, 0, 5 };
            int[] seqenceTwo= { 1, 2, 3, 4, 5, 6, 6 };
            int[] seqenceThree = {1 ,1 ,1 };

          
           
                Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(seqenceOne));
                Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(seqenceTwo));
                Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(seqenceThree));
            
        }

        static int GetIndexOfFirstElementLargerThanNeighbours(int [] larger)
        {
            int position=-1;
            for (int i = 0; i < larger.Length; i++)
            {
                if (i == 0)
                {
                    if (larger[i + 1] < larger[i])
                    {
                        position = i;
                        return position;
                    }
                    

                }
                else if (i == larger.Length - 1)
                {
                    if (larger[i - 1] < larger[i])
                    {
                        position = i;
                        return position;
                    }

                }
                else
                {
                    if (larger[i - 1] < larger[i] && larger[i + 1] < larger[i])
                    {
                        position = i;
                        return position;
                    }
                }  
            }
            return position;

        }
    }

