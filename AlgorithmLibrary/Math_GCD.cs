//

//Greatest Common Divisor(GCD)................Highest Common Factor (HCF)

//Two ways to find gcd of two numbers : 
//1.To find all the primefactors first:
//36 = 2 * 2 * 3 * 3
//60  =  2 * 2 * 3 * 5
//Then get the common factors as 2,2,3
//answer will be  = 2* 2* 3  = 12

//2.Euclidean Algorithm : GCD of two numbers doesn't change if smaller number is substracted from a bigger number;
//To Find the gcd of an array of numbers :
//gcd(a,b,c) = gcd(gcd(a,b),c);
//gcd(1,x) = 1;
//



namespace AlgorithmLibrary
{
public partial class Mathematics{
   public static int? GCDofAnArrayOFNumbers(int[] input)
   {
       int result = input[0];
       for(int i = 1;i<input.Length;i++)
       {
          result = GCDofTwoNumbers(result,input[i]);
          if(result==1)
          {
             return 1;
          }
       }
       return result;


   }
   public static int GCDofTwoNumbers(int num1,int num2)
   {
      if(num1==0)
         return num2 ;
      if(num2==0)
            return num1;
      if(num1==num2)
            return num1;

      if(num1>num2)
         return GCDofTwoNumbers(num1-num2,num2);
      else
        return GCDofTwoNumbers(num1,num2-num1);
      
   }
}
}

