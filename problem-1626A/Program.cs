using System;
using System.Collections.Generic;
using System.Text;

namespace problem_1626A
{
    class Program
    {
        static void Main(string[] args)
        {
            var ntestCase = Convert.ToInt32(Console.ReadLine());
            var words = new List<string>() ;
            for(int i =0;i<ntestCase;i++)
            {
                    words.Add(Console.ReadLine());
            }
            //
            //base case 1
            //if there is no pair return as it is
            //base case 2 
            //if there is only one pair return as it is
            
          
            foreach(var word in words)
            {
                 var aobject =  NumberOfPairss(word);

                if(aobject.count>1)
                {
                    var pairs = aobject.pairs;
                    var uniqs = aobject.uniqs;
                    var sb = new StringBuilder();

                    foreach(var uniq in uniqs)
                    {
                        if(!pairs.Contains(uniq))
                        sb.Append(uniq);
                    }
                    foreach(var pair in pairs)
                    {
                        sb.Append(pair);
                        sb.Append(pair);
                    }

                    System.Console.WriteLine(sb);

                }else{
                    System.Console.WriteLine(word);
                }
            }

        }
        static (int count,List<char>  pairs,List<char> uniqs) NumberOfPairss(string input)
        {
            var uniqletters = new List<char>();
            var pairs = new List<char>();
            var charArr = input.ToCharArray();
            foreach(char c in charArr)
            {
                if(!uniqletters.Contains(c))
                {
                    uniqletters.Add(c);
                }else{
                    pairs.Add(c);
                }
            }
            return (pairs.Count, pairs,uniqletters);
        }
       
    }
}
