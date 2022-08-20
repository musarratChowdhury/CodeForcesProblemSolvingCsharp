using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary
{
    public partial class Mathematics
    {
        public static int GetPower(int a,int b)
        {
            if (b == 0) return 1;
            if(b%2==0)
            {
                int temp = GetPower(a, b / 2);
                return temp * temp;
            }
            return a * GetPower(a, b - 1);
        }
        public static double GetSqrt(int n)
        {
            double L = 0, R = n, M = 0.0d;
            while (Math.Abs(L - R) > 1E-6)
            {
                M = L + (R - L) / 2.0;
                if ((M * M) > n)
                {
                    R = M;
                }
                else
                {
                    L = M;
                }
            }
            return M;
        }
    }
}
