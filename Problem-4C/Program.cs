

using System;
using System.Text;
using System.Collections.Generic;


namespace ProblemSolving

{
    public class Program
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            var regs = new List<string>();
            //
            var output = new List<string>();
            var uniqs = new List<string>();
            //freq counter
            var freqCounter = new Dictionary<string, int>();
            var sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                regs.Add(Console.ReadLine());
            }

            foreach (string s in regs)
            {
                if (!uniqs.Contains(s))
                {
                    uniqs.Add(s);
                    output.Add("OK");
                    freqCounter.Add(s, 1);
                }
                else
                {
                    sb.Append(s);
                    sb.Append(freqCounter[s]++);
                    output.Add(sb.ToString());
                    sb.Clear();
                }
            }
            foreach(var s in output)
            {
                Console.WriteLine(s);
            }


        }
    }

}