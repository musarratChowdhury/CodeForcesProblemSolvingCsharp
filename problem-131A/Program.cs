using System;
using System.Linq;
using System.Text;


namespace problem_131A
{
    class Program
    {
        private static bool isCapsOn = true;

        static void Main(string[] args)
        {
            var inputL = Console.ReadLine();
            var sb = new StringBuilder();
            if(inputL.All(char.IsUpper))
            {
                System.Console.WriteLine(inputL.ToLower());
                return;
            }
            
            if(CapsOn(inputL))
            {
                var normalized =  inputL.ToLower();
               
              
              for(int i =0 ;i<normalized.Length;i++)
              {
                  if(i==0)
                  sb.Append(Char.ToUpper(normalized[i]));
                  else
                  sb.Append(normalized[i]);
              } 
                
                System.Console.WriteLine(sb);
                return;
                
            }
            
            System.Console.WriteLine(inputL);
        }
        static bool CapsOn(string input)
        {
            
            var subword =input.Substring(1,input.Length-1);
            
            
            if(subword.All(char.IsUpper))
            {
                isCapsOn = true;
            }else{
                isCapsOn  =false;
            }
            
            return isCapsOn;
        }
    }
}
