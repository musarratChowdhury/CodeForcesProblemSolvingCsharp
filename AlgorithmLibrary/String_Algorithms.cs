using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary
{

    public partial class Strings
    {
        public static int TimeComplexityCounter = 0;

        public static int BruteForceSearch(string text, string pattern)
        {
            return BruteForceSearch(text.ToCharArray(), pattern.ToCharArray());
        }
        internal static int BruteForceSearch(char[] text, char[] pattern)
        {
            int i = 0, j = 0;
            int n = text.Length;
            int m = pattern.Length;

            while (i <= n - m)
            {
                j = 0;
                while (j < m && pattern[j] == text[i + j])
                {
                    j++;
                    TimeComplexityCounter++;
                }
                if (j == m)
                {
                    return (i);
                }
                i++;
                TimeComplexityCounter++;


            }
            return -1;
        }
        public static int KMP(string text, string pattern)
        {
            return KMP(text.ToCharArray(), pattern.ToCharArray());
        }
        private static int KMP(char[] text, char[] pattern)
        {
            int i = 0, j = 0;
            int n = text.Length;
            int m = pattern.Length;

            int[] ShiftArr = new int[m + 1];

            KMPPreprocess(pattern, ShiftArr);

            while (i < n)
            {
                while (j >= 0 && text[i] != pattern[j])
                {
                    j = ShiftArr[j];
                }
                i++;
                j++;
                TimeComplexityCounter++;
                if (j == m)
                {
                    return (i - m);
                }
            }
            return -1;



        }
        private static void KMPPreprocess(char[] pattern, int[] ShiftArr)
        {
            int m = pattern.Length;
            int i = 0, j = -1;
            ShiftArr[i] = -1;
            while (i < m)
            {
                while (j >= 0 && pattern[i] != pattern[j])
                {
                    j = ShiftArr[j];

                }
                i++;
                j++;
                TimeComplexityCounter++;
                ShiftArr[i] = j;
            }
        }
        //using KMP algorithm to find the count of occurances fo the pattern in a text
        public static int KMPFindCount(char[] text, char[] pattern)
        {
            int i = 0, j = 0, count = 0;
            int n = text.Length;
            int m = pattern.Length;
            int[] ShiftArr = new int[m + 1];
            KMPPreprocess(pattern, ShiftArr);

            while (i < n)
            {
                while (j >= 0 && text[i] != pattern[j])
                {
                    j = ShiftArr[j];
                }
                i++;
                j++;
                if (j == m)
                {
                    count++;
                    j = ShiftArr[j];
                }
            }
            return count;
        }
        //ORDER MATCHING
        //Given a long text string and a pattern string, Find if the charachters fo pattern string are in the same order in text string.
        //EX; text string : ABCDEFGHIJKLMNOPQRSTUVWXYZ
        //pattern string: JOST
        public static bool OrderMatch(string source, string pattern)
        {
            return match(source.ToCharArray(), pattern.ToCharArray());
        }
        private static bool match(char[] source, char[] pattern)
        {
            int iPattern = 0;
            int patternLength = pattern.Length;
            for (int iSource = 0; iSource < source.Length; iSource++)
            {
                if (source[iSource] == pattern[iPattern])
                {
                    iPattern++;
                }
                if (iPattern == patternLength)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
