using static System.Console;
namespace problem_1352C_KthNotDivisibleByN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(ReadLine());
            while(t>0)
            {
                var line1 = ReadLine().Split(" ");
                int n = Convert.ToInt32(line1[0]);
                int k = Convert.ToInt32(line1[1]);

                int result = ((k - 1) / (n - 1)) + k;
                WriteLine(result);  
                t--;
            }
          



            //Console.WriteLine(n+ " " + k);  

           
        }
    }
}