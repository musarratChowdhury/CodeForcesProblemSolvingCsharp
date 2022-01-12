//

//

//
using System.Collections;
//
namespace AlgorithmLibrary
{
   public partial class Mathematics
   {
      public static int[] FindAllPrimeFactors(int input,bool isUnique)
      {

         var arrList = new ArrayList();
         var uniqArrList  = new ArrayList();
            //given an integer is 9 ,its prime factors are 3*3

            while(input%2==0)
            {
               input = input/2;
               arrList.Add(2);
            }

            for(int i  = 3;i<input/2;i+=2)
            {
               while(input%i==0)
               {
                  input/=i;
                  arrList.Add(i);
               }
            }

            if(input>2)
            {
               arrList.Add(input);
            }

            if(isUnique)
            {
              foreach (var x in arrList)
			      {
			     	if (!uniqArrList.Contains(x))
			    	{
				   	uniqArrList.Add(x);
			   	}
			      }
               return (int[])uniqArrList.ToArray(typeof(int));
            }
            
         

         return (int[])arrList.ToArray(typeof(int));

      }
   }
}