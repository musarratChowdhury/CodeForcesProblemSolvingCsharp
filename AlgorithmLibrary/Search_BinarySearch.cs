using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary
{
    public class Search_Algorithm
    {
        public static bool DoesExist(int[] arr,int elem)
        {
            int L = 0, R = arr.Length - 1;
            while(L<=R)
            {
                int M = L + (R - L) / 2;
                if (arr[M] == elem) return true;
                else if (arr[M] > elem) R = M - 1;
                else L = M + 1;
            }
            return false;
        }
    }
}
