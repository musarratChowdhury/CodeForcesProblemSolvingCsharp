using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary
{
    public partial class Sorting
    {
        public static void bubble_sort_ascending(int[] numbers)
        {
            //BASE INDEX = i
            for(int i = 0;i< numbers.Length;i++)
            {
                for(int j=i+1;j<numbers.Length;j++)
                {
                    if(numbers[i]>numbers[j])//ASCENDING ORDER
                    {
                        //swapping
                        int temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;  
                    }
                }
            }
        }
        public static void bubble_sort_descending(int[] numbers)
        {
            //BASE INDEX = i
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] < numbers[j])//DESCENDING ORDER
                    {
                        //swapping
                        int temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
        }
    }
}
