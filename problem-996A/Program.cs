using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;



//

// Hit the lottery
/// <summary>
/// dollar bills : 1,5,10,20,100
/// </summary>
//
namespace problem_580A
{
    class Program
    {
        static void Main(string[] args)
        {

            var amount = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            
            var denominations = new int[] {1,5,10,20,100};

            while(amount>0)
            {
                if(amount/denominations[denominations.Length-1]>=1)
                {
                    count += amount / denominations[denominations.Length - 1];

                    amount %= denominations[denominations.Length-1];  
                }else if(amount  / denominations[denominations.Length-2]>=1)
                {
                    count+=amount/denominations[denominations.Length-2];
                    amount %= denominations[denominations.Length - 2];

                }
                else if (amount / denominations[denominations.Length - 3] >= 1)
                {
                    count+=amount/denominations[denominations.Length-3];
                    amount %= denominations[denominations.Length - 3];

                }
                else if (amount / denominations[denominations.Length - 4] >= 1)
                {
                    count+=amount/denominations[denominations.Length-4];
                    amount %= denominations[denominations.Length - 4];

                }
                else if (amount / denominations[denominations.Length - 5] >= 1)
                {
                    count+=amount/denominations[denominations.Length-5];
                    amount %= denominations[denominations.Length - 5];

                }
            }
            Console.WriteLine(count);
            
            
        }
    }
}
