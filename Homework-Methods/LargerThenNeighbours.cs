using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class LargerThenNeighbours
    {
        static void Main(string[] args)
        {
          int[]numbers={1,3,4,5,1,0,5};

            for (int i  = 0; i < numbers.Length; i++)
			{
			 Console.WriteLine(IsLargerThanNeighbours(numbers,i));
			}
        }

       public static bool IsLargerThanNeighbours(int[] nums ,int i)
        {
            bool result=false;
            if (i==0)
	        {
	    	 result=nums[i+1]<nums[i];

	        }
            else if (i==nums.Length-1)
            {
                result = nums[i - 1] < nums[i];
            }
            else
            {
                result = nums[i - 1] < nums[i] && nums[i + 1] < nums[i];
            }

            return result;
        }
    }

