using System;
using System.Linq;//✨✨✨✨
using System.Text;
using System.Collections.Generic;



namespace AlgorithmLibrary
{
    public partial class Strings
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
            return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit)
            && s.Any(char.IsPunctuation);
        }

        //normalize string
        public static string NormalizeString(string input)
        {
            string normalized = input.ToLower().Trim().Replace(",", "");
            //   string lowercased =  input.ToLower();
            //   string trimmed = lowercased.Trim();
            return normalized;
        }
        //search something in the string
        public static void ParseContents(string s)
        {
            foreach (char c in s)
            {
                Console.WriteLine(c);
            }
        }
        #region IsAtEvenIndex
        public static Boolean IsAtEvenIndex(string s, char item)
        {
            if (String.IsNullOrEmpty(s))
            {
                return false;

            }
            for (int i = 0; i < s.Length / 2 + 1; i += 2)
            {
                if (item == s[i])
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
        #region Reverse
        public static String Reverse(String input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return input;
            }

            //strings are immutable;
            //So lets use stringbuilder
            var sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            return sb.ToString();

        }
        #endregion
        #region Reverse2
        public static string Reverse2(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return s;
            }

            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }
        #endregion
        #region PalindromeCheck
        public static bool PalindromeCheck(string a, string b)
        {
            if (Reverse(a) == b)
            {
                return true;
            }
            return false;
        }
        #endregion
        #region MakeFirstLetterUpperCaseOnly
        public static string MakeFirstLetterUpperCaseOnly(string input)

        {
            var normalized = input.ToLower();
            var sb = new StringBuilder();


            for (int i = 0; i < normalized.Length; i++)
            {
                if (i == 0)
                    sb.Append(Char.ToUpper(normalized[i]));
                else
                    sb.Append(normalized[i]);
            }

            System.Console.WriteLine(sb);
            return sb.ToString();
        }
        #endregion
        #region ReverseEachWord
        public static string ReverseEachWord(string input)
        {
            //stringbuilder
            var sb = new StringBuilder();
            //base case
            if (String.IsNullOrEmpty(input))
            {
                return input;
            }
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(Reverse(words[i]));
                if (i != words.Length - 1)
                    sb.Append(" ");
            }
            return sb.ToString();
        }
        #endregion
        #region GiveAllTheUniqueChars
        public static List<char> GiveAlltheuniqChars(string input)
        {
            var listofChars = new List<char>();
            var charArr = input.ToCharArray();

            foreach (char c in charArr)
            {
                if (!listofChars.Contains(c))
                {
                    listofChars.Add(c);
                }
            }


            return listofChars;

        }
        #endregion
        #region ToUpper
        public static char ToUpper(char s)
        {
            if (s >= 97 && s <= (97 + 25))
            {
                s = (char)(s - 32);
            }
            return s;
        }
        #endregion
        #region ToLower
        public static char ToLower(char s)
        {
            if (s >= 65 && s <= (65 + 25))
            {
                s = (char)(s + 32);
            }
            return s;
        }
        #endregion
        #region isUniqueChar
        public static bool isUniqueChar(string s)
        {
            int[] map = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c >= 'A' && c <= 'Z')
                {
                    if (map[c - 'A'] != 0)
                    {
                        Console.WriteLine("duplicate found!");
                        return false;
                    }
                    else
                    {
                        map[c - 'A'] = 1;
                    }
                }
                else if(c>='a'&& c <= 'z')
                {
                    if (map[c - 'a'] != 0)
                    {
                        Console.WriteLine("duplicate found!");
                        return false;
                    }
                    else
                    {
                        map[c - 'a'] = 1;
                    }
                }
            }
            Console.WriteLine("No duplicate found!");



            return true;
        }
        #endregion
    }
}