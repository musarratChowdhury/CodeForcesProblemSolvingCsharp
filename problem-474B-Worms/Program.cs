namespace problem_474B_Worms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int n = Convert.ToInt32(Console.ReadLine());//the number of moles

            var line2 = Console.ReadLine().Split(" ");
            var pilesWWorms = new List<int>();
            var sum = 0;
            foreach(var x in line2)
            {
                sum += Convert.ToInt32(x);
                pilesWWorms.Add(sum);
            }
            int q = Convert.ToInt32(Console.ReadLine());
            var line3 = Console.ReadLine().Split(" ");
            foreach(var y in line3)
            {
                int label = Convert.ToInt32(y);
                int pileNo = GetLowerBound(pilesWWorms, label)+1;
                Console.WriteLine(pileNo);
            }


        }
        public static int GetLowerBound(List<int> arr, int value)
        {
            int L = 0;
            int R = arr.Count;

            while (L < R)
            {
                int M = L + (R - L) / 2;
                if (arr[M] >= value)
                {
                    R = M;
                }
                else
                {
                    L = M + 1;
                }
            }
            return L;
        }
        //public static int GetUpperBound(int[] arr,int value)
        //{
        //    return GetLowerBound(arr, value + 1);
        //}
    }
}