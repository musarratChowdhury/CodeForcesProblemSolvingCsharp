using System;
using System.Linq;//✨✨✨✨
using System.Text;



namespace AlgorithmLibrary
{
   public class Strings
   {
      //if all the characters in this string s is uppercase . All can be used with linq only
      public static bool isUppercase(String s)
      {
         return s.All(char.IsUpper);
      }
      public static bool isLowercase(String s)
      {
         return s.All(char.IsLower);
      }
      public static bool isDigit(string s)
      {
         return s.All(char.IsDigit);
      }
      public static bool isLetter(string s)
      {
         return s.All(char.IsLetter);
      }
      public static bool isPasswordComplex(string s)
      {
         return s.Any(char.IsUpper)&&s.Any(char.IsLower)&&s.Any(char.IsDigit)
         &&s.Any(char.IsPunctuation);
      }

      //normalize string
      public static string NormalizeString(string input)
      {
         string normalized = input.ToLower().Trim().Replace(",","");
      //   string lowercased =  input.ToLower();
      //   string trimmed = lowercased.Trim();
        return normalized;
      }
      //search something in the string
      public static void ParseContents(string s)
      {
         foreach(char c in s)
         {
            Console.WriteLine(c);
         }
      }
      public static Boolean IsAtEvenIndex(string s ,char item)
      {
         if(String.IsNullOrEmpty(s))
         {
            return false;

         }
         for(int i = 0;i<s.Length/2+1;i+=2)
         {
            if(item == s[i])
            {
                  return true;
            }
         }
         return false;
      }
      public static String Reverse(String input)
      {
         if(String.IsNullOrEmpty(input))
         {
            return input;
         }

         //strings are immutable;
         //So lets use stringbuilder
         var sb = new StringBuilder();
         for(int i = input.Length-1;i>=0;i--)
         {
            sb.Append(input[i]);
         }
         return sb.ToString();

      }
      public static string Reverse2(string s)
      {
         if(String.IsNullOrEmpty(s))
         {
            return s;
         }

         char[] arr = s.ToCharArray();
         Array.Reverse(arr);
         return new String(arr);
      }
      public static bool PalindromeCheck(string a ,string b)
      {
         if(Reverse(a)==b)
         {
            return true;
         }
         return false;
      }
      public static string ReverseEachWord(string input)
      {
         //stringbuilder
         var sb = new StringBuilder();
         //base case
         if(String.IsNullOrEmpty(input))
         {
            return input;
         }
         string[] words = input.Split(' ');
         for(int i = 0;i<words.Length;i++)
         {
               sb.Append(Reverse(words[i]));
               if(i!=words.Length-1)
               sb.Append(" ");
         }
         return sb.ToString();
      }
   }
}