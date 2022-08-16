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
        public static int CountFirstEvenNumbers(int[] arr)
        {
            int L = 0, R = arr.Length;
            while(L<R)
            {
                int M = L + (R - L) / 2;
                if (arr[M]%2==0)
                {
                    L = M +1;
                }
                else
                {
                    R = M;
                }
            }
            return L;
        }
        public static double Get_Sqrt(int n)
        {
            double L = 0, R = n, M=0.0d;
            while(Math.Abs(L-R)>1E-6)
            {
                M = L+ (R - L) / 2.0; 
                if((M*M)>n)
                {
                    R = M;
                }else
                {
                    L = M;
                }
            }
            return M;
        }
        public static int GetLowerBound(int[] arr,int value)
        {
            int L = 0;
            int R = arr.Length;

            while(L<R)
            {
                int M = L + (R - L) / 2;
                if (arr[M]>=value)
                {
                    R = M;
                }
                else
                {
                    L = M + 1;
                }
            }
            return L;
        }
        public static int GetUpperBound(int[] arr, int value)
        {
            int L = 0;
            int R = arr.Length;
             while(L<R)
            {
                int M = L + (R - L) / 2;
                if (arr[M] > value)
                {
                    R = M;
                }else
                {
                    L = M + 1;
                }

            }
            return L;
        }
    }
}
