using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary
{
    public partial class ArrayAlgo 
    {
        public static int  MaxSubArraySum(int[] nums)
        {
            int  currentSum = 0;
            List<int> resultArr = new(); 

            for(int i = 0;i<nums.Length;i++)
            {
              
                if (currentSum + nums[i] < nums[i])
                {
                    currentSum = nums[i];
                    resultArr.Add(currentSum);

                }
                else
                {
                    currentSum += nums[i];
                    resultArr.Add(currentSum);
                }
            }

            return resultArr.Max();
        }
    }
}
